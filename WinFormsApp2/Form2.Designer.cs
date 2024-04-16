namespace WinFormsApp2
{
    partial class Form2
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
            townComboBox = new ComboBox();
            countryComboBox = new ComboBox();
            adminButton = new Button();
            SuspendLayout();
            // 
            // townComboBox
            // 
            townComboBox.FormattingEnabled = true;
            townComboBox.Location = new Point(461, 76);
            townComboBox.Name = "townComboBox";
            townComboBox.Size = new Size(182, 33);
            townComboBox.TabIndex = 0;
            townComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // countryComboBox
            // 
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(155, 76);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(182, 33);
            countryComboBox.TabIndex = 1;
            // 
            // adminButton
            // 
            adminButton.Location = new Point(305, 339);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(177, 58);
            adminButton.TabIndex = 3;
            adminButton.Text = "Admin";
            adminButton.UseVisualStyleBackColor = true;
            adminButton.Visible = false;
            adminButton.Click += adminButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(adminButton);
            Controls.Add(countryComboBox);
            Controls.Add(townComboBox);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox townComboBox;
        private ListBox townListBox;
        private ComboBox countryComboBox;
        private Button button1;
        private Button adminButton;
    }
}