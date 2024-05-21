namespace test2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            vhod = new Button();
            button2 = new Button();
            password = new TextBox();
            label1 = new Label();
            login = new TextBox();
            SuspendLayout();
            // 
            // vhod
            // 
            vhod.Location = new Point(344, 253);
            vhod.Name = "vhod";
            vhod.Size = new Size(100, 29);
            vhod.TabIndex = 0;
            vhod.Text = "Вход";
            vhod.UseVisualStyleBackColor = true;
            vhod.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(344, 288);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 1;
            button2.Text = "Регистрация";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // password
            // 
            password.Location = new Point(344, 206);
            password.Name = "password";
            password.Size = new Size(100, 23);
            password.TabIndex = 2;
            password.Text = "Пароль";
            password.TextAlign = HorizontalAlignment.Center;
            password.TextChanged += password_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(332, 113);
            label1.Name = "label1";
            label1.Size = new Size(133, 28);
            label1.TabIndex = 4;
            label1.Text = "Авторизация";
            label1.Click += label1_Click;
            // 
            // login
            // 
            login.Location = new Point(344, 165);
            login.Name = "login";
            login.Size = new Size(100, 23);
            login.TabIndex = 5;
            login.Text = "Логин";
            login.TextAlign = HorizontalAlignment.Center;
            login.TextChanged += login_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(login);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(button2);
            Controls.Add(vhod);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button vhod;
        private Button button2;
        private TextBox password;
        private Label label1;
        private TextBox login;
    }
}
