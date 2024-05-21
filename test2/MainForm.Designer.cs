namespace test2
{
    partial class MainForm
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            country = new Label();
            city = new Label();
            transport = new Label();
            mealType = new Label();
            price = new Label();
            house = new Label();
            dateLeave = new Label();
            dateReturn = new Label();
            countTurists = new Label();
            button = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 214);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(12, 232);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 214);
            listBox2.TabIndex = 1;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // country
            // 
            country.AutoSize = true;
            country.Location = new Point(138, 12);
            country.Name = "country";
            country.Size = new Size(54, 15);
            country.TabIndex = 2;
            country.Text = "Страна -";
            country.Click += country_Click;
            // 
            // city
            // 
            city.AutoSize = true;
            city.Location = new Point(138, 39);
            city.Name = "city";
            city.Size = new Size(48, 15);
            city.TabIndex = 3;
            city.Text = "Город -";
            city.Click += city_Click;
            // 
            // transport
            // 
            transport.AutoSize = true;
            transport.Location = new Point(138, 66);
            transport.Name = "transport";
            transport.Size = new Size(76, 15);
            transport.TabIndex = 4;
            transport.Text = "Транспорт - ";
            transport.Click += transport_Click;
            // 
            // mealType
            // 
            mealType.AutoSize = true;
            mealType.Location = new Point(138, 93);
            mealType.Name = "mealType";
            mealType.Size = new Size(33, 15);
            mealType.TabIndex = 5;
            mealType.Text = "Еда -";
            mealType.Click += mealType_Click;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(138, 119);
            price.Name = "price";
            price.Size = new Size(35, 15);
            price.TabIndex = 6;
            price.Text = "Цена";
            price.Click += price_Click;
            // 
            // house
            // 
            house.AutoSize = true;
            house.Location = new Point(138, 145);
            house.Name = "house";
            house.Size = new Size(55, 15);
            house.TabIndex = 7;
            house.Text = "Жилье - ";
            house.Click += house_Click;
            // 
            // dateLeave
            // 
            dateLeave.AutoSize = true;
            dateLeave.Location = new Point(138, 232);
            dateLeave.Name = "dateLeave";
            dateLeave.Size = new Size(89, 15);
            dateLeave.TabIndex = 8;
            dateLeave.Text = "Дата отбытия -";
            dateLeave.Click += dateLeave_Click;
            // 
            // dateReturn
            // 
            dateReturn.AutoSize = true;
            dateReturn.Location = new Point(138, 260);
            dateReturn.Name = "dateReturn";
            dateReturn.Size = new Size(98, 15);
            dateReturn.TabIndex = 9;
            dateReturn.Text = "Дата прибытия -";
            dateReturn.Click += dateReturn_Click;
            // 
            // countTurists
            // 
            countTurists.AutoSize = true;
            countTurists.Location = new Point(138, 290);
            countTurists.Name = "countTurists";
            countTurists.Size = new Size(128, 15);
            countTurists.TabIndex = 10;
            countTurists.Text = "Количество человек -";
            countTurists.Click += countTurists_Click;
            // 
            // button
            // 
            button.Location = new Point(317, 367);
            button.Name = "button";
            button.Size = new Size(150, 47);
            button.TabIndex = 11;
            button.Text = "Выбрать";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button);
            Controls.Add(countTurists);
            Controls.Add(dateReturn);
            Controls.Add(dateLeave);
            Controls.Add(house);
            Controls.Add(price);
            Controls.Add(mealType);
            Controls.Add(transport);
            Controls.Add(city);
            Controls.Add(country);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Label country;
        private Label city;
        private Label transport;
        private Label mealType;
        private Label price;
        private Label house;
        private Label dateLeave;
        private Label dateReturn;
        private Label countTurists;
        private Button button;
    }
}