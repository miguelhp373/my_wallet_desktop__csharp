using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWalletDesktop.Models
{
    public class User
    {
        public bool userAuth { get; set; }
        public int userId { get; set; }
        public string userName { get; set; }
        public string userPass { get; set; }
        public bool userADM { get; set; }
        public bool userActive { get; set; }
        public string userError { get; set; }

    }
}
