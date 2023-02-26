namespace MyWalletDesktop.Views
{
    partial class FrLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.edt_user_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_user_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoginAction = new System.Windows.Forms.Button();
            this.linkNewAccount = new System.Windows.Forms.LinkLabel();
            this.errorLabelDisplay = new System.Windows.Forms.Label();
            this.btn_close_application = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edt_user_name
            // 
            this.edt_user_name.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_user_name.Location = new System.Drawing.Point(44, 131);
            this.edt_user_name.Name = "edt_user_name";
            this.edt_user_name.Size = new System.Drawing.Size(289, 24);
            this.edt_user_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // edt_user_password
            // 
            this.edt_user_password.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_user_password.Location = new System.Drawing.Point(44, 188);
            this.edt_user_password.Name = "edt_user_password";
            this.edt_user_password.PasswordChar = '*';
            this.edt_user_password.Size = new System.Drawing.Size(289, 24);
            this.edt_user_password.TabIndex = 1;
            this.edt_user_password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.edt_user_password_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            // 
            // btnLoginAction
            // 
            this.btnLoginAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginAction.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAction.Location = new System.Drawing.Point(44, 234);
            this.btnLoginAction.Name = "btnLoginAction";
            this.btnLoginAction.Size = new System.Drawing.Size(289, 37);
            this.btnLoginAction.TabIndex = 2;
            this.btnLoginAction.Text = "Entrar";
            this.btnLoginAction.UseVisualStyleBackColor = true;
            this.btnLoginAction.Click += new System.EventHandler(this.btnLoginAction_Click);
            // 
            // linkNewAccount
            // 
            this.linkNewAccount.AutoSize = true;
            this.linkNewAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkNewAccount.Location = new System.Drawing.Point(107, 315);
            this.linkNewAccount.Name = "linkNewAccount";
            this.linkNewAccount.Size = new System.Drawing.Size(171, 13);
            this.linkNewAccount.TabIndex = 7;
            this.linkNewAccount.TabStop = true;
            this.linkNewAccount.Text = "Clique Aqui Para Criar Uma Conta!";
            this.linkNewAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNewAccount_LinkClicked);
            // 
            // errorLabelDisplay
            // 
            this.errorLabelDisplay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabelDisplay.ForeColor = System.Drawing.Color.Red;
            this.errorLabelDisplay.Location = new System.Drawing.Point(12, 38);
            this.errorLabelDisplay.Name = "errorLabelDisplay";
            this.errorLabelDisplay.Size = new System.Drawing.Size(358, 23);
            this.errorLabelDisplay.TabIndex = 8;
            this.errorLabelDisplay.Text = "Mensagem de Erro";
            this.errorLabelDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabelDisplay.Visible = false;
            // 
            // btn_close_application
            // 
            this.btn_close_application.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close_application.Location = new System.Drawing.Point(284, 12);
            this.btn_close_application.Name = "btn_close_application";
            this.btn_close_application.Size = new System.Drawing.Size(86, 23);
            this.btn_close_application.TabIndex = 9;
            this.btn_close_application.Text = "Fechar";
            this.btn_close_application.UseVisualStyleBackColor = true;
            this.btn_close_application.Click += new System.EventHandler(this.btn_close_application_Click);
            // 
            // FrLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 370);
            this.ControlBox = false;
            this.Controls.Add(this.btn_close_application);
            this.Controls.Add(this.errorLabelDisplay);
            this.Controls.Add(this.linkNewAccount);
            this.Controls.Add(this.btnLoginAction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edt_user_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edt_user_name);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edt_user_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edt_user_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoginAction;
        private System.Windows.Forms.LinkLabel linkNewAccount;
        private System.Windows.Forms.Label errorLabelDisplay;
        private System.Windows.Forms.Button btn_close_application;
    }
}