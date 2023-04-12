using Stylet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStyletExample.Pages
{
    public class AboutViewModel :Screen
    {
        public string Version { get; set; }
        public string Owner { get; set; }



        public AboutViewModel()
        {
            Owner = "Xxxx公司";

            Version = "1.0.999999";
        }
    }
}
