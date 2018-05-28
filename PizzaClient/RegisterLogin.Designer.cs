namespace PizzaClient
{
    partial class RegisterLogin
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PasswordLogin = new System.Windows.Forms.TextBox();
            this.UsernameLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.UsernameRegister = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.RegisterPasswordMelding = new System.Windows.Forms.Label();
            this.FoutmeldingLogin = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(441, 223);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.BurlyWood;
            this.tabPage1.Controls.Add(this.FoutmeldingLogin);
            this.tabPage1.Controls.Add(this.PasswordLogin);
            this.tabPage1.Controls.Add(this.UsernameLogin);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(433, 194);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // PasswordLogin
            // 
            this.PasswordLogin.Location = new System.Drawing.Point(149, 60);
            this.PasswordLogin.Name = "PasswordLogin";
            this.PasswordLogin.Size = new System.Drawing.Size(231, 22);
            this.PasswordLogin.TabIndex = 4;
            // 
            // UsernameLogin
            // 
            this.UsernameLogin.Location = new System.Drawing.Point(149, 22);
            this.UsernameLogin.Name = "UsernameLogin";
            this.UsernameLogin.Size = new System.Drawing.Size(231, 22);
            this.UsernameLogin.TabIndex = 3;
            this.UsernameLogin.TextChanged += new System.EventHandler(this.UsernameLogin_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.BurlyWood;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.RegisterPasswordMelding);
            this.tabPage2.Controls.Add(this.UsernameRegister);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(433, 194);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Register";
            // 
            // UsernameRegister
            // 
            this.UsernameRegister.Location = new System.Drawing.Point(149, 22);
            this.UsernameRegister.Name = "UsernameRegister";
            this.UsernameRegister.Size = new System.Drawing.Size(231, 22);
            this.UsernameRegister.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 32);
            this.button2.TabIndex = 0;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegisterPasswordMelding
            // 
            this.RegisterPasswordMelding.AutoSize = true;
            this.RegisterPasswordMelding.Location = new System.Drawing.Point(20, 71);
            this.RegisterPasswordMelding.Name = "RegisterPasswordMelding";
            this.RegisterPasswordMelding.Size = new System.Drawing.Size(16, 17);
            this.RegisterPasswordMelding.TabIndex = 3;
            this.RegisterPasswordMelding.Text = "..";
            // 
            // FoutmeldingLogin
            // 
            this.FoutmeldingLogin.AutoSize = true;
            this.FoutmeldingLogin.ForeColor = System.Drawing.Color.Red;
            this.FoutmeldingLogin.Location = new System.Drawing.Point(146, 95);
            this.FoutmeldingLogin.Name = "FoutmeldingLogin";
            this.FoutmeldingLogin.Size = new System.Drawing.Size(163, 17);
            this.FoutmeldingLogin.TabIndex = 5;
            this.FoutmeldingLogin.Text = "Customer not registered!";
            this.FoutmeldingLogin.Visible = false;
            // 
            // RegisterLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(440, 224);
            this.Controls.Add(this.tabControl1);
            this.Name = "RegisterLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.RegisterLogin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordLogin;
        private System.Windows.Forms.TextBox UsernameLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FoutmeldingLogin;
        private System.Windows.Forms.Label RegisterPasswordMelding;
    }
}

