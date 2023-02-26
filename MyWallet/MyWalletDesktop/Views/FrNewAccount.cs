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
using MyWalletDesktop.Utilities;

namespace MyWalletDesktop.Views
{
    public partial class FrNewAccount : Form
    {
        public FrNewAccount()
        {
            InitializeComponent();
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show($"ERRO - {message}");
            return;
        }

        private void btnCancelAction_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddingAction_Click(object sender, EventArgs e)
        {
            try
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

                LoginController loginController = new LoginController();
                var hasExists = loginController.hasExistsUser(edt_user_name.Text);

                if (hasExists)
                {
                    errorLabelDisplay.Text = "O Usuário Informado Já Existe!";
                    errorLabelDisplay.Visible = true;

                    return;
                }


                var hasCreatedUser = loginController.CreateNewUser(edt_user_name.Text, edt_user_password.Text);


                if (UserSession.CurrentUser.userError != "")
                {
                    ShowErrorMessage(UserSession.CurrentUser.userError);
                }

                if (!hasCreatedUser)
                {
                    errorLabelDisplay.Text = "Não Foi Possível Cadastrar o Usuário! Tente Novamente.";
                    errorLabelDisplay.Visible = true;

                    return;
                }

                Close();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
                return;
            }




        }

    }

 
}
