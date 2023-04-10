using System;
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


        public ShellViewModel()
        {
            Title = "Stylet MVVM 框架学习";
            //UserPage = userPage;
        }


    }
}
