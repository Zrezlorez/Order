using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

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
            passwordShow = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            password = new TextBox();
            login = new TextBox();
            authButton = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(passwordShow);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(password);
            panel1.Controls.Add(login);
            panel1.Controls.Add(authButton);
            panel1.Location = new Point(245, 143);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 213);
            panel1.TabIndex = 0;
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
            // password
            // 
            password.Location = new Point(49, 116);
            password.Name = "password";
            password.Size = new Size(208, 23);
            password.TabIndex = 2;
            password.UseSystemPasswordChar = true;
            // 
            // login
            // 
            login.Location = new Point(49, 57);
            login.Name = "login";
            login.Size = new Size(208, 23);
            login.TabIndex = 1;
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
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(138, 38);
            label1.Name = "label1";
            label1.Size = new Size(528, 87);
            label1.TabIndex = 1;
            label1.Text = "Автоматизированная обработка учета складских операций и реализации продукции";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Auth";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auth";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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