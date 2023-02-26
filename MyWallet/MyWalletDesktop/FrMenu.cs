using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWalletDesktop
{
    public partial class FrMenu : Form
    {
        public FrMenu()
        {
            InitializeComponent();
        }

        private void onLoginAction()
        {
            Views.FrLogin frLogin = new Views.FrLogin();
            frLogin.ShowDialog();
        }

        private void FrMenu_Load(object sender, EventArgs e)
        {
            onLoginAction();
        }
    }
}
