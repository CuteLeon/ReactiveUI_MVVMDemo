using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Bindings.ViewModels;
using ReactiveUI;

namespace Bindings
{
    public partial class MainForm : Form, IViewFor<PersonViewModel>
    {
        public MainForm()
        {
            InitializeComponent();

            //绑定View激活时数据联动
            this.WhenActivated(action => {
                //单向绑定GUID
                action(this.OneWayBind(ViewModel, vm => vm.GUID, v => v.GUIDValueLabel.Text, guid=>guid.ToString("N").ToUpper()));

                //双向绑定姓名
                action(this.Bind(ViewModel, vm => vm.Name, v => v.NameValueTextBox.Text));
                action(this.OneWayBind(ViewModel, vm => vm.Name, v => v.Text, name=> $"当前用户：{name}"));

                //双向绑定生日
                action(this.Bind(ViewModel, vm => vm.Birthday, v => v.BirthdayDateTimePicker.Value, birthday => birthday.Date, value => value.Date));

                //单向绑定年龄
                action(this.OneWayBind(ViewModel, vm => vm.Age, v => v.AgeValueLabel.Text));
            });
        }

        public PersonViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (PersonViewModel)value;
        }

    }
}
