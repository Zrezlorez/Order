namespace Order.Forms
{
    partial class Auth
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
            panel1 = new Panel();
            label1 = new Label();
            authButton = new Button();
            login = new TextBox();
            password = new TextBox();
            label2 = new Label();
            label3 = new Label();
            passwordShow = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(passwordShow);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(password);
            panel1.Controls.Add(login);
            panel1.Controls.Add(authButton);
            panel1.Location = new Point(242, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 213);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(338, 69);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 1;
            label1.Text = "Название";
            // 
            // authButton
            // 
            authButton.Location = new Point(117, 177);
            authButton.Name = "authButton";
            authButton.Size = new Size(69, 23);
            authButton.TabIndex = 0;
            authButton.Text = "Войти";
            authButton.UseVisualStyleBackColor = true;
            authButton.Click += button1_Click;
            // 
            // login
            // 
            login.Location = new Point(49, 57);
            login.Name = "login";
            login.Size = new Size(208, 23);
            login.TabIndex = 1;
            // 
            // password
            // 
            password.Location = new Point(49, 116);
            password.Name = "password";
            password.Size = new Size(208, 23);
            password.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(117, 96);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(117, 37);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 4;
            label3.Text = "Логин";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordShow
            // 
            passwordShow.AutoSize = true;
            passwordShow.Location = new Point(49, 145);
            passwordShow.Name = "passwordShow";
            passwordShow.Size = new Size(121, 19);
            passwordShow.TabIndex = 5;
            passwordShow.Text = "Показаль пароль";
            passwordShow.UseVisualStyleBackColor = true;
            passwordShow.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Auth";
            Text = "Auth";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private TextBox password;
        private TextBox login;
        private Button authButton;
        private Label label1;
        private CheckBox passwordShow;
    }
}