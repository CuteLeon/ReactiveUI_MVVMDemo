using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bindings.ViewModels
{
    public class PersonViewModel : ReactiveObject
    {
        private Guid guid;
        private string name;
        private DateTime birthday;
        private int age;

        public PersonViewModel()
        {
            GUID = Guid.NewGuid();
            Name = "<默认姓名>";
            Birthday = DateTime.Now.Date;
        }

        /// <summary>
        /// GUID
        /// </summary>
        /// <remarks>不向外部绑定的属性</remarks>
        public Guid GUID { get; private set; }

        /// <summary>
        /// 姓名
        /// </summary>
        /// <remarks>向外部双向绑定的属性，允许读写</remarks>
        public string Name
        {
            get => name;
            set => this.RaiseAndSetIfChanged(ref name, value);
        }

        /// <summary>
        /// 生日
        /// </summary>
        /// <remarks>向外部双向绑定的属性，允许读写并联动其他属性</remarks>
        public DateTime Birthday
        {
            get => birthday;
            set
            {
                this.RaiseAndSetIfChanged(ref birthday, value);
                //联动年龄属性
                Age = (int)(DateTime.Now.Subtract(value).TotalDays/365);
            }
        }

        /// <summary>
        /// 年龄
        /// </summary>
        /// <remarks>向外部单项绑定的属性，只允许外部读取，并在发生变化后通知外部</remarks>
        public int Age
        {
            get => age;
            private set
            {
                age = value;
                this.RaisePropertyChanged("Age");
            }
        }

    }
}
