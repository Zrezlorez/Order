namespace Order.Forms.StorageForms
{
    partial class CreateUser
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(96, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(160, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(25, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(231, 21);
            label1.TabIndex = 1;
            label1.Text = "Добавление нового работника";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(25, 56);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 19);
            label2.TabIndex = 2;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(25, 91);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(47, 19);
            label3.TabIndex = 3;
            label3.Text = "Логин";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(96, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(160, 23);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(25, 125);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(56, 19);
            label4.TabIndex = 5;
            label4.Text = "Пароль";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(96, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(160, 23);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(25, 156);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(47, 19);
            label5.TabIndex = 7;
            label5.Text = "Склад";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(96, 156);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(160, 23);
            comboBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(151, 203);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(57, 203);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label4);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(279, 238);
            panel1.TabIndex = 11;
            // 
            // CreateUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(298, 270);
            Controls.Add(panel1);
            Name = "CreateUser";
            Text = "CreateUser";
            FormClosing += CreateUser_FormClosing;
            Load += CreateUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Panel panel1;
    }
}