using Stylet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStyletExample.Pages
{
    public class UserPageViewModel : Screen
    {
        private string _actualName;

        public string Name { get; set; }
        public string ActualName
        {
            get
            {
                return _actualName;
            }
            set
            {
                SetAndNotify(ref _actualName, value);
            }
        }


        public UserPageViewModel()
        {
            Name = "张三";
            ActualName = "海盗";
        }


        public void ChangeName()
        {
            ActualName = Name;
        }

    }
}
