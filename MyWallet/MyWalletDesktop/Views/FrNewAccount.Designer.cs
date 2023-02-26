namespace MyWalletDesktop.Views
{
    partial class FrNewAccount
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
            this.btnAddingAction = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_user_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_user_name = new System.Windows.Forms.TextBox();
            this.btnCancelAction = new System.Windows.Forms.Button();
            this.errorLabelDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddingAction
            // 
            this.btnAddingAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddingAction.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddingAction.Location = new System.Drawing.Point(46, 228);
            this.btnAddingAction.Name = "btnAddingAction";
            this.btnAddingAction.Size = new System.Drawing.Size(289, 37);
            this.btnAddingAction.TabIndex = 2;
            this.btnAddingAction.Text = "Cadastrar";
            this.btnAddingAction.UseVisualStyleBackColor = true;
            this.btnAddingAction.Click += new System.EventHandler(this.btnAddingAction_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Usuário";
            // 
            // edt_user_password
            // 
            this.edt_user_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edt_user_password.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_user_password.Location = new System.Drawing.Point(46, 182);
            this.edt_user_password.MaxLength = 50;
            this.edt_user_password.Name = "edt_user_password";
            this.edt_user_password.PasswordChar = '*';
            this.edt_user_password.Size = new System.Drawing.Size(289, 24);
            this.edt_user_password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Criar Nova Conta";
            // 
            // edt_user_name
            // 
            this.edt_user_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edt_user_name.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_user_name.Location = new System.Drawing.Point(46, 125);
            this.edt_user_name.MaxLength = 100;
            this.edt_user_name.Name = "edt_user_name";
            this.edt_user_name.Size = new System.Drawing.Size(289, 24);
            this.edt_user_name.TabIndex = 0;
            // 
            // btnCancelAction
            // 
            this.btnCancelAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelAction.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAction.Location = new System.Drawing.Point(46, 283);
            this.btnCancelAction.Name = "btnCancelAction";
            this.btnCancelAction.Size = new System.Drawing.Size(289, 37);
            this.btnCancelAction.TabIndex = 3;
            this.btnCancelAction.Text = "Voltar ao Login";
            this.btnCancelAction.UseVisualStyleBackColor = true;
            this.btnCancelAction.Click += new System.EventHandler(this.btnCancelAction_Click);
            // 
            // errorLabelDisplay
            // 
            this.errorLabelDisplay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabelDisplay.ForeColor = System.Drawing.Color.Red;
            this.errorLabelDisplay.Location = new System.Drawing.Point(12, 20);
            this.errorLabelDisplay.Name = "errorLabelDisplay";
            this.errorLabelDisplay.Size = new System.Drawing.Size(358, 23);
            this.errorLabelDisplay.TabIndex = 12;
            this.errorLabelDisplay.Text = "Mensagem de Erro";
            this.errorLabelDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabelDisplay.Visible = false;
            // 
            // FrNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 370);
            this.ControlBox = false;
            this.Controls.Add(this.errorLabelDisplay);
            this.Controls.Add(this.btnCancelAction);
            this.Controls.Add(this.btnAddingAction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edt_user_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edt_user_name);
            this.Name = "FrNewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddingAction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edt_user_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edt_user_name;
        private System.Windows.Forms.Button btnCancelAction;
        private System.Windows.Forms.Label errorLabelDisplay;
    }
}