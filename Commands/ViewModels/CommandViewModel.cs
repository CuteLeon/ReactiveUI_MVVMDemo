using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using ReactiveUI;

namespace Commands.ViewModels
{
    public class CommandViewModel : ReactiveObject
    {
        /// <summary>
        /// 无参命令
        /// </summary>
        public ReactiveCommand CommandWithoutParam { get; }

        /// <summary>
        /// 有参命令
        /// </summary>
        public ReactiveCommand CommandWithParam { get; }

        /// <summary>
        /// 需参命令
        /// </summary>
        public ReactiveCommand CommandRequireParam { get; }

        public CommandViewModel()
        {
            //创建无参命令
            CommandWithoutParam = ReactiveCommand.Create(FunctionWhithoutParam);
            //创建有参命令
            CommandWithParam = ReactiveCommand.Create<string>(FunctionWithParam);
            //创建需参命令
            CommandRequireParam = ReactiveCommand.Create(FunctionRequireParam,
                //设计所需参数要求
                this.WhenAnyValue(vm => vm.ParamRequired1, vm => vm.ParamRequired2).Select(param => !string.IsNullOrEmpty(param.Item1) && !string.IsNullOrEmpty(param.Item2)));
        }
        
        private string paramRequired1;
        /// <summary>
        /// 需要的参数1
        /// </summary>
        public string ParamRequired1
        {
            get => paramRequired1;
            set => this.RaiseAndSetIfChanged(ref paramRequired1, value);
        }

        private string paramRequired2;
        /// <summary>
        /// 需要的参数2
        /// </summary>
        public string ParamRequired2
        {
            get => paramRequired2;
            set => this.RaiseAndSetIfChanged(ref paramRequired2, value);
        }

        /// <summary>
        /// 无参方法
        /// </summary>
        private void FunctionWhithoutParam() => MessageBox.Show("调用了无参方法 ...");

        /// <summary>
        /// 有参方法
        /// </summary>
        private void FunctionWithParam(string param) => MessageBox.Show($"调用了有参方法：{param}");

        /// <summary>
        /// 需参方法
        /// </summary>
        private void FunctionRequireParam() => MessageBox.Show($"调用了需参方法：{paramRequired1} & {paramRequired2}");
        
    }
}
