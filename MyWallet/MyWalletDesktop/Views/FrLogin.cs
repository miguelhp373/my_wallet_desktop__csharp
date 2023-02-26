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

namespace MyWalletDesktop.Views
{
    public partial class FrLogin : Form
    {
        public FrLogin()
        {
            InitializeComponent();
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show($"ERRO - {message}");
            return;
        }

        private void btnLoginAction_Click(object sender, EventArgs e)
        {
            if (edt_user_name.Text.Trim() == "")
            {
                errorLabelDisplay.Text = "Preecha o Nome do Usuário Corretamente";
                errorLabelDisplay.Visible = true;
                return;
            }

            if (edt_user_password.Text.Trim() == "")
            {
                errorLabelDisplay.Text = "Preecha A Senha Corretamente";
                errorLabelDisplay.Visible = true;
                return;
            }

            try
            {
                LoginController loginController = new LoginController();
                loginController.LoginActionUser(edt_user_name.Text, edt_user_password.Text);

                if (UserSession.CurrentUser.userError != "")
                {
                    ShowErrorMessage(UserSession.CurrentUser.userError);
                    errorLabelDisplay.Text = "Não Foi Possivel Realizar o Login! Tente Novamente.";
                    errorLabelDisplay.Visible = true;
                    return;
                }

                if (UserSession.CurrentUser.userAuth)
                {
                    Close();
                } 
                else
                {
                    errorLabelDisplay.Text = "Não Foi Possivel Realizar o Login! Tente Novamente.";
                    errorLabelDisplay.Visible = true;
                    return;
                }

                
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
                return;
            }
        }

        private void linkNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrNewAccount frNewAccount = new FrNewAccount();
            frNewAccount.ShowDialog();
        }

        private void btn_close_application_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }     

        private void edt_user_password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLoginAction_Click(btnLoginAction, e);
            }
        }
    }
}
