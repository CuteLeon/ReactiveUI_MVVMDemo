using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ReactiveUI;
using Commands.ViewModels;

namespace Commands
{
    public partial class MainForm : Form, IViewFor<CommandViewModel>
    {
        public MainForm()
        {
            InitializeComponent();
            
            this.WhenActivated(action=> {
                //绑定无参命令
                action(this.BindCommand(ViewModel, vm=> vm.CommandWithoutParam, v=>v.CommandWOParamButton));

                //绑定有参命令
                action(this.BindCommand(ViewModel, vm => vm.CommandWithParam, v => v.CommandWParamButton, this.WhenAnyValue(v => v.WithParamValueTextBox.Text),"MouseLeave"));

                //绑定所需参数
                action(this.Bind(ViewModel, vm => vm.ParamRequired1, v => v.RequiredParamValue1TextBox.Text));
                action(this.Bind(ViewModel, vm => vm.ParamRequired2, v => v.RequiredParamValue2TextBox.Text));
                //绑定需参命令
                action(this.BindCommand(ViewModel, vm => vm.CommandRequireParam, v => v.CommandRParamButton,"MouseEnter"));
            });
            
            ViewModel = new CommandViewModel();
        }

        public CommandViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (CommandViewModel)value;
        }

    }
}
