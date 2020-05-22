namespace AWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.WrittenUsername = new System.Windows.Forms.TextBox();
            this.WrittenPwd = new System.Windows.Forms.TextBox();
            this.PwdBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.WrittenLN = new System.Windows.Forms.TextBox();
            this.LastnameBox = new System.Windows.Forms.TextBox();
            this.WrittenFN = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.WrittenRPwd = new System.Windows.Forms.TextBox();
            this.RPwdBox = new System.Windows.Forms.TextBox();
            this.WrittenRUsername = new System.Windows.Forms.TextBox();
            this.RUsernameBox = new System.Windows.Forms.TextBox();
            this.TransferBox = new System.Windows.Forms.TextBox();
            this.WrittenTransfert = new System.Windows.Forms.TextBox();
            this.POButton = new System.Windows.Forms.Button();
            this.FButton = new System.Windows.Forms.Button();
            this.RemainBox = new System.Windows.Forms.TextBox();
            this.ImpresBox = new System.Windows.Forms.TextBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.BalanceBox = new System.Windows.Forms.TextBox();
            this.AccountBox = new System.Windows.Forms.TextBox();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.ConnectorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(33, 12);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.ReadOnly = true;
            this.UsernameBox.Size = new System.Drawing.Size(78, 22);
            this.UsernameBox.TabIndex = 0;
            this.UsernameBox.Text = "Username";
            // 
            // WrittenUsername
            // 
            this.WrittenUsername.Location = new System.Drawing.Point(117, 12);
            this.WrittenUsername.Name = "WrittenUsername";
            this.WrittenUsername.Size = new System.Drawing.Size(157, 22);
            this.WrittenUsername.TabIndex = 1;
            // 
            // WrittenPwd
            // 
            this.WrittenPwd.Location = new System.Drawing.Point(117, 40);
            this.WrittenPwd.Name = "WrittenPwd";
            this.WrittenPwd.Size = new System.Drawing.Size(157, 22);
            this.WrittenPwd.TabIndex = 3;
            this.WrittenPwd.UseSystemPasswordChar = true;
            // 
            // PwdBox
            // 
            this.PwdBox.Location = new System.Drawing.Point(33, 40);
            this.PwdBox.Name = "PwdBox";
            this.PwdBox.ReadOnly = true;
            this.PwdBox.Size = new System.Drawing.Size(78, 22);
            this.PwdBox.TabIndex = 2;
            this.PwdBox.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(299, 12);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 50);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(380, 12);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 50);
            this.RegisterButton.TabIndex = 5;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // WrittenLN
            // 
            this.WrittenLN.Location = new System.Drawing.Point(559, 40);
            this.WrittenLN.Name = "WrittenLN";
            this.WrittenLN.Size = new System.Drawing.Size(157, 22);
            this.WrittenLN.TabIndex = 9;
            this.WrittenLN.Visible = false;
            // 
            // LastnameBox
            // 
            this.LastnameBox.Location = new System.Drawing.Point(475, 40);
            this.LastnameBox.Name = "LastnameBox";
            this.LastnameBox.ReadOnly = true;
            this.LastnameBox.Size = new System.Drawing.Size(78, 22);
            this.LastnameBox.TabIndex = 8;
            this.LastnameBox.Text = "Lastname";
            this.LastnameBox.Visible = false;
            // 
            // WrittenFN
            // 
            this.WrittenFN.Location = new System.Drawing.Point(559, 12);
            this.WrittenFN.Name = "WrittenFN";
            this.WrittenFN.Size = new System.Drawing.Size(157, 22);
            this.WrittenFN.TabIndex = 7;
            this.WrittenFN.Visible = false;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(475, 12);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.ReadOnly = true;
            this.FirstNameBox.Size = new System.Drawing.Size(78, 22);
            this.FirstNameBox.TabIndex = 6;
            this.FirstNameBox.Text = "Firstname";
            this.FirstNameBox.Visible = false;
            this.FirstNameBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // WrittenRPwd
            // 
            this.WrittenRPwd.Location = new System.Drawing.Point(559, 96);
            this.WrittenRPwd.Name = "WrittenRPwd";
            this.WrittenRPwd.Size = new System.Drawing.Size(157, 22);
            this.WrittenRPwd.TabIndex = 13;
            this.WrittenRPwd.UseSystemPasswordChar = true;
            this.WrittenRPwd.Visible = false;
            // 
            // RPwdBox
            // 
            this.RPwdBox.Location = new System.Drawing.Point(475, 96);
            this.RPwdBox.Name = "RPwdBox";
            this.RPwdBox.ReadOnly = true;
            this.RPwdBox.Size = new System.Drawing.Size(78, 22);
            this.RPwdBox.TabIndex = 12;
            this.RPwdBox.Text = "Password";
            this.RPwdBox.Visible = false;
            // 
            // WrittenRUsername
            // 
            this.WrittenRUsername.Location = new System.Drawing.Point(559, 68);
            this.WrittenRUsername.Name = "WrittenRUsername";
            this.WrittenRUsername.Size = new System.Drawing.Size(157, 22);
            this.WrittenRUsername.TabIndex = 11;
            this.WrittenRUsername.Visible = false;
            // 
            // RUsernameBox
            // 
            this.RUsernameBox.Location = new System.Drawing.Point(475, 68);
            this.RUsernameBox.Name = "RUsernameBox";
            this.RUsernameBox.ReadOnly = true;
            this.RUsernameBox.Size = new System.Drawing.Size(78, 22);
            this.RUsernameBox.TabIndex = 10;
            this.RUsernameBox.Text = "Username";
            this.RUsernameBox.Visible = false;
            // 
            // TransferBox
            // 
            this.TransferBox.Location = new System.Drawing.Point(33, 171);
            this.TransferBox.Name = "TransferBox";
            this.TransferBox.ReadOnly = true;
            this.TransferBox.Size = new System.Drawing.Size(174, 22);
            this.TransferBox.TabIndex = 14;
            this.TransferBox.Text = "Transfer amount of money";
            this.TransferBox.Visible = false;
            // 
            // WrittenTransfert
            // 
            this.WrittenTransfert.Location = new System.Drawing.Point(213, 171);
            this.WrittenTransfert.Name = "WrittenTransfert";
            this.WrittenTransfert.Size = new System.Drawing.Size(70, 22);
            this.WrittenTransfert.TabIndex = 15;
            this.WrittenTransfert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WrittenTransfert.Visible = false;
            // 
            // POButton
            // 
            this.POButton.Location = new System.Drawing.Point(289, 166);
            this.POButton.Name = "POButton";
            this.POButton.Size = new System.Drawing.Size(94, 32);
            this.POButton.TabIndex = 16;
            this.POButton.Text = "PayOnline";
            this.POButton.UseVisualStyleBackColor = true;
            this.POButton.Visible = false;
            this.POButton.Click += new System.EventHandler(this.POButton_Click);
            // 
            // FButton
            // 
            this.FButton.Location = new System.Drawing.Point(389, 166);
            this.FButton.Name = "FButton";
            this.FButton.Size = new System.Drawing.Size(94, 32);
            this.FButton.TabIndex = 17;
            this.FButton.Text = "Faculties";
            this.FButton.UseVisualStyleBackColor = true;
            this.FButton.Visible = false;
            this.FButton.Click += new System.EventHandler(this.FButton_Click);
            // 
            // RemainBox
            // 
            this.RemainBox.Location = new System.Drawing.Point(33, 247);
            this.RemainBox.Name = "RemainBox";
            this.RemainBox.ReadOnly = true;
            this.RemainBox.Size = new System.Drawing.Size(174, 22);
            this.RemainBox.TabIndex = 18;
            this.RemainBox.Text = "Remaining impressions";
            this.RemainBox.Visible = false;
            // 
            // ImpresBox
            // 
            this.ImpresBox.Location = new System.Drawing.Point(214, 247);
            this.ImpresBox.Name = "ImpresBox";
            this.ImpresBox.ReadOnly = true;
            this.ImpresBox.Size = new System.Drawing.Size(69, 22);
            this.ImpresBox.TabIndex = 19;
            this.ImpresBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ImpresBox.Visible = false;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(289, 242);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(93, 32);
            this.PrintButton.TabIndex = 20;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Visible = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // BalanceBox
            // 
            this.BalanceBox.Location = new System.Drawing.Point(214, 208);
            this.BalanceBox.Name = "BalanceBox";
            this.BalanceBox.ReadOnly = true;
            this.BalanceBox.Size = new System.Drawing.Size(69, 22);
            this.BalanceBox.TabIndex = 22;
            this.BalanceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BalanceBox.Visible = false;
            // 
            // AccountBox
            // 
            this.AccountBox.Location = new System.Drawing.Point(33, 208);
            this.AccountBox.Name = "AccountBox";
            this.AccountBox.ReadOnly = true;
            this.AccountBox.Size = new System.Drawing.Size(174, 22);
            this.AccountBox.TabIndex = 21;
            this.AccountBox.Text = "Account balance";
            this.AccountBox.Visible = false;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(607, 372);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(109, 48);
            this.LogoutButton.TabIndex = 23;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Visible = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ConnectorButton
            // 
            this.ConnectorButton.Location = new System.Drawing.Point(489, 166);
            this.ConnectorButton.Name = "ConnectorButton";
            this.ConnectorButton.Size = new System.Drawing.Size(94, 32);
            this.ConnectorButton.TabIndex = 24;
            this.ConnectorButton.Text = "Connector";
            this.ConnectorButton.UseVisualStyleBackColor = true;
            this.ConnectorButton.Visible = false;
            this.ConnectorButton.Click += new System.EventHandler(this.ConnectorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConnectorButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.BalanceBox);
            this.Controls.Add(this.AccountBox);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.ImpresBox);
            this.Controls.Add(this.RemainBox);
            this.Controls.Add(this.FButton);
            this.Controls.Add(this.POButton);
            this.Controls.Add(this.WrittenTransfert);
            this.Controls.Add(this.TransferBox);
            this.Controls.Add(this.WrittenRPwd);
            this.Controls.Add(this.RPwdBox);
            this.Controls.Add(this.WrittenRUsername);
            this.Controls.Add(this.RUsernameBox);
            this.Controls.Add(this.WrittenLN);
            this.Controls.Add(this.LastnameBox);
            this.Controls.Add(this.WrittenFN);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.WrittenPwd);
            this.Controls.Add(this.PwdBox);
            this.Controls.Add(this.WrittenUsername);
            this.Controls.Add(this.UsernameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox WrittenUsername;
        private System.Windows.Forms.TextBox WrittenPwd;
        private System.Windows.Forms.TextBox PwdBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox WrittenLN;
        private System.Windows.Forms.TextBox LastnameBox;
        private System.Windows.Forms.TextBox WrittenFN;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox WrittenRPwd;
        private System.Windows.Forms.TextBox RPwdBox;
        private System.Windows.Forms.TextBox WrittenRUsername;
        private System.Windows.Forms.TextBox RUsernameBox;
        private System.Windows.Forms.TextBox TransferBox;
        private System.Windows.Forms.TextBox WrittenTransfert;
        private System.Windows.Forms.Button POButton;
        private System.Windows.Forms.Button FButton;
        private System.Windows.Forms.TextBox RemainBox;
        private System.Windows.Forms.TextBox ImpresBox;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.TextBox BalanceBox;
        private System.Windows.Forms.TextBox AccountBox;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button ConnectorButton;
    }
}

