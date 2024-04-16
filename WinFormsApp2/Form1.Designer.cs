namespace WinFormsApp2
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
            label1 = new Label();
            label2 = new Label();
            usernameBox1 = new TextBox();
            passwordBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            passwordBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 88);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 0;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 138);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 1;
            label2.Text = "password";
            // 
            // usernameBox1
            // 
            usernameBox1.Location = new Point(326, 87);
            usernameBox1.Name = "usernameBox1";
            usernameBox1.Size = new Size(120, 31);
            usernameBox1.TabIndex = 2;
            usernameBox1.TextChanged += usernameBox1_TextChanged;
            // 
            // passwordBox2
            // 
            passwordBox2.Location = new Point(326, 135);
            passwordBox2.Name = "passwordBox2";
            passwordBox2.Size = new Size(120, 31);
            passwordBox2.TabIndex = 3;
            passwordBox2.TextChanged += passwordBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(206, 275);
            button1.Name = "button1";
            button1.Size = new Size(134, 45);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(393, 277);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(129, 43);
            button2.TabIndex = 5;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 181);
            label3.Name = "label3";
            label3.Size = new Size(144, 25);
            label3.TabIndex = 6;
            label3.Text = "repeat password";
            // 
            // passwordBox3
            // 
            passwordBox3.Location = new Point(326, 178);
            passwordBox3.Name = "passwordBox3";
            passwordBox3.Size = new Size(120, 31);
            passwordBox3.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(passwordBox3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(passwordBox2);
            Controls.Add(usernameBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox usernameBox1;
        private Label label1;
        private Label label2;
        private TextBox passwordBox2;
        private Button button1;
        private Button button2;
        private Label label3;
        private TextBox passwordBox3;
    }
}