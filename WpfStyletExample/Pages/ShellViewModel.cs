using System;
using System.Windows;
using Stylet;
using StyletIoC;

namespace WpfStyletExample.Pages
{
    public class ShellViewModel : Screen
    {
        private string _title;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                SetAndNotify(ref _title, value);
            }
        }
        [Inject]
        public UserPageViewModel UserPage { get; private set; }


        public void ChangeTitle()
        {

            Title = "使用Stylet Command改变标题";
        }

        private IWindowManager _windowManager;

        public ShellViewModel(IWindowManager windowManager)
        {
            Title = "Stylet MVVM 框架学习";
            //UserPage = userPage;
            _windowManager= windowManager;
        }

        /// <summary>
        /// 打开一个About窗口，模态显示
        /// </summary>
        public void ShowDialogAbout()
        {
            _windowManager.ShowDialog(new AboutViewModel());
        }

        /// <summary>
        /// 打开一个About窗口，非模态显示
        /// </summary>
        public void ShowAbout()
        {
            _windowManager.ShowWindow(new AboutViewModel());
        }

        /// <summary>
        /// 打开一个消息对话框，输入参数跟windows消息框一样
        /// </summary>
        public void ShowMsg()
        {
            _windowManager.ShowMessageBox("这是一个重要消息", "重要", MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }
}
