namespace Scheduler
{
    partial class Login
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterFormButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(44, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(428, 37);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Dobrodošli v aplikaciji Moj Urnik.";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(127, 129);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(137, 20);
            this.UsernameTextBox.TabIndex = 1;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(32, 132);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(89, 13);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Uporabniško ime:";
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(127, 177);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(137, 20);
            this.PassTextBox.TabIndex = 3;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(84, 180);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(37, 13);
            this.PassLabel.TabIndex = 4;
            this.PassLabel.Text = "Geslo:";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(127, 217);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(99, 28);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Vpis";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterFormButton
            // 
            this.RegisterFormButton.Location = new System.Drawing.Point(331, 217);
            this.RegisterFormButton.Name = "RegisterFormButton";
            this.RegisterFormButton.Size = new System.Drawing.Size(124, 28);
            this.RegisterFormButton.TabIndex = 6;
            this.RegisterFormButton.Text = "Registracija";
            this.RegisterFormButton.UseVisualStyleBackColor = true;
            this.RegisterFormButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Začnite z uporabo.";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegisterFormButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegisterFormButton;
        private System.Windows.Forms.Label label1;
    }
}

