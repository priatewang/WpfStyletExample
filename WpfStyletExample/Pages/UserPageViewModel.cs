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

        #region 测试命令/事件

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


        public void ChangeName()
        {
            ActualName = Name;
        }

        public void ChangingName()
        {
            ActualName = "改名ing";
        }

        public void ChangedName()
        {
            ActualName = "改名完成";
        }
        #endregion

        #region 测试事件是否可用


        private string _testTxt;

        public string TestTxt
        {
            get
            {
                return _testTxt;
            }
            set
            {
                SetAndNotify(ref _testTxt, value);
            }
        }
        private bool _canTestCmd;

        public bool CanTestCmd
        {
            get
            {
                return _canTestCmd;
            }
            set
            {
                SetAndNotify(ref _canTestCmd, value);
            }
        }

        #endregion

        public UserPageViewModel()
        {
            Name = "张三";
            ActualName = "海盗";
        }


        public void TestCmd()
        {
            TestTxt = "测试成功";
        }

        public void ChangeTestCmd()
        {
            CanTestCmd = !CanTestCmd;
        }

        private string _outText;
        public string OutText
        {
            get
            {
                return _outText;
            }
            set
            {
                SetAndNotify(ref _outText, value);
            }
        }

        public void OutUseTest()
        {
            OutText = "Shell操作修改成功";
        }

    }
}
