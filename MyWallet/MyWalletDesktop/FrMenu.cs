using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWalletDesktop.Controllers;
using MyWalletDesktop.Models;
using MyWalletDesktop.Utilities;
using MyWalletDesktop.Views;

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
            FrLogin frLogin = new FrLogin();
            frLogin.ShowDialog();
        }

        private void isLoadDataForApplication()
        {
            display_user_name.Text = "Bem Vindo " + UserSession.CurrentUser.userName;
        }

        private void selectPageOfControl(int isPageIndex)
        {
            pages_control.SelectedIndex = isPageIndex;
        }

        private void FrMenu_Load(object sender, EventArgs e)
        {
            onLoginAction();

            if (!UserSession.CurrentUser.userAuth)
            {
                FrLogin frLogin = new FrLogin();
                frLogin.ShowDialog();
            }

            isLoadDataForApplication();
            selectPageOfControl(0);


        }

        private void btn_close_application_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectPageOfControl(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectPageOfControl(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectPageOfControl(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectPageOfControl(3);
        }
    }
}
