namespace WinFormsApp2
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            idTextBox = new TextBox();
            townTextBox = new TextBox();
            addTown = new Button();
            deleteTown = new Button();
            UpdateTown = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            AddCountry = new Button();
            Delete = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 36);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Town";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(117, 10);
            idTextBox.Margin = new Padding(2);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(106, 23);
            idTextBox.TabIndex = 2;
            // 
            // townTextBox
            // 
            townTextBox.Location = new Point(117, 32);
            townTextBox.Margin = new Padding(2);
            townTextBox.Name = "townTextBox";
            townTextBox.Size = new Size(106, 23);
            townTextBox.TabIndex = 3;
            // 
            // addTown
            // 
            addTown.Location = new Point(130, 67);
            addTown.Margin = new Padding(2);
            addTown.Name = "addTown";
            addTown.Size = new Size(92, 20);
            addTown.TabIndex = 4;
            addTown.Text = "Add Town";
            addTown.UseVisualStyleBackColor = true;
            addTown.Click += addTown_Click;
            // 
            // deleteTown
            // 
            deleteTown.Location = new Point(130, 103);
            deleteTown.Margin = new Padding(2);
            deleteTown.Name = "deleteTown";
            deleteTown.Size = new Size(92, 20);
            deleteTown.TabIndex = 5;
            deleteTown.Text = "Delete Town";
            deleteTown.UseVisualStyleBackColor = true;
            deleteTown.Click += deleteTown_Click;
            // 
            // UpdateTown
            // 
            UpdateTown.Location = new Point(130, 136);
            UpdateTown.Margin = new Padding(2);
            UpdateTown.Name = "UpdateTown";
            UpdateTown.Size = new Size(92, 20);
            UpdateTown.TabIndex = 6;
            UpdateTown.Text = "Update Town";
            UpdateTown.UseVisualStyleBackColor = true;
            UpdateTown.Click += UpdateTown_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 12);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 7;
            label3.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(325, 10);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(325, 34);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(106, 23);
            textBox2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 38);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 10;
            label4.Text = "Country";
            // 
            // AddCountry
            // 
            AddCountry.Location = new Point(325, 67);
            AddCountry.Margin = new Padding(2);
            AddCountry.Name = "AddCountry";
            AddCountry.Size = new Size(105, 20);
            AddCountry.TabIndex = 11;
            AddCountry.Text = "Add Country";
            AddCountry.UseVisualStyleBackColor = true;
            AddCountry.Click += AddCountry_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(325, 103);
            Delete.Margin = new Padding(2);
            Delete.Name = "Delete";
            Delete.Size = new Size(105, 20);
            Delete.TabIndex = 12;
            Delete.Text = "Delete Country";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // button3
            // 
            button3.Location = new Point(325, 136);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(105, 20);
            button3.TabIndex = 13;
            button3.Text = "Update Country";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(button3);
            Controls.Add(Delete);
            Controls.Add(AddCountry);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(UpdateTown);
            Controls.Add(deleteTown);
            Controls.Add(addTown);
            Controls.Add(townTextBox);
            Controls.Add(idTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox idTextBox;
        private TextBox townTextBox;
        private Button addTown;
        private Button button1;
        private Button deleteTown;
        private Button UpdateTown;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Button AddCountry;
        private Button button2;
        private Button Delete;
        private Button button3;
    }
}