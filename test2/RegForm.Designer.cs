namespace test2
{
    partial class RegForm
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
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            men = new RadioButton();
            woman = new RadioButton();
            label5 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(21, 30);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 1;
            label1.Text = "Полное имя";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(21, 102);
            label2.Name = "label2";
            label2.Size = new Size(190, 25);
            label2.TabIndex = 2;
            label2.Text = "Паспортные данные";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 130);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(21, 171);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 4;
            label3.Text = "Гедер";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(21, 237);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 6;
            label4.Text = "Возраст";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(21, 265);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(205, 23);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // men
            // 
            men.AutoSize = true;
            men.Location = new Point(21, 199);
            men.Name = "men";
            men.Size = new Size(51, 19);
            men.TabIndex = 8;
            men.TabStop = true;
            men.Text = "Муж";
            men.UseVisualStyleBackColor = true;
            men.CheckedChanged += men_CheckedChanged;
            // 
            // woman
            // 
            woman.AutoSize = true;
            woman.Location = new Point(88, 199);
            woman.Name = "woman";
            woman.Size = new Size(49, 19);
            woman.TabIndex = 9;
            woman.TabStop = true;
            woman.Text = "Жен";
            woman.UseVisualStyleBackColor = true;
            woman.CheckedChanged += woman_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(21, 305);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 10;
            label5.Text = "Дети";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(21, 333);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(205, 23);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 373);
            button1.Name = "button1";
            button1.Size = new Size(158, 53);
            button1.TabIndex = 12;
            button1.Text = "Закончить регистрацию";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 450);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(woman);
            Controls.Add(men);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "RegForm";
            Text = "RegForm";
            Load += RegForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private RadioButton men;
        private RadioButton woman;
        private Label label5;
        private TextBox textBox3;
        private Button button1;
    }
}