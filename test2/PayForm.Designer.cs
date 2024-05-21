namespace test2
{
    partial class PayForm
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "number";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(45, 150);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(73, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "date";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(236, 150);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(45, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "CVV";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(135, 30);
            label1.Name = "label1";
            label1.Size = new Size(78, 28);
            label1.TabIndex = 3;
            label1.Text = "Оплата";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(135, 206);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Оплатить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 254);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "PayForm";
            Text = "PayForm";
            Load += PayForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Button button1;
    }
}