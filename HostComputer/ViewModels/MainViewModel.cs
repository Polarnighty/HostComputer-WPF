using HostComputer.Base;
using HostComputer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostComputer.ViewModels
{
    public class MainViewModel
    {
        public MainModel MainModel { get; set; } = new MainModel();


        private CommandBase _closeCommand;

        public CommandBase CloseCommand
        {
            get
            {
                if (_closeCommand == null)
                {
                    _closeCommand = new CommandBase();
                    _closeCommand.DoExecute = new Action<object>(obj =>
                    {
                        (obj as System.Windows.Window).DialogResult = false;
                    });
                }
                return _closeCommand;
            }
        }

        private CommandBase _menuItemCommand;

        public CommandBase MenuItemCommand
        {
            get
            {
                if (_menuItemCommand == null)
                {
                    _menuItemCommand = new CommandBase();
                    _menuItemCommand.DoExecute = new Action<object>(obj =>
                    {
                        NavPage(obj.ToString());
                    });
                }
                return _menuItemCommand;
            }
        }


        private void NavPage(string name)
        {
            Type type = Type.GetType(name);
            this.MainModel.MainContent = (System.Windows.UIElement)Activator.CreateInstance(type);
        }

        public MainViewModel()
        {
            this.NavPage("HostComputer.Views.MonitorView");

            Task.Run(async () =>
            {
                while (true)
                {
                    await Task.Delay(500);
                    this.MainModel.Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                }
            });
        }

    }
}
