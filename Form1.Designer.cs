namespace _24._05
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
            nameTextBox = new TextBox();
            ageNumericUpDown = new NumericUpDown();
            employeesDataGridView = new DataGridView();
            AddButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(25, 47);
            nameTextBox.Multiline = true;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(184, 128);
            nameTextBox.TabIndex = 0;
            // 
            // ageNumericUpDown
            // 
            ageNumericUpDown.Location = new Point(237, 48);
            ageNumericUpDown.Name = "ageNumericUpDown";
            ageNumericUpDown.Size = new Size(120, 23);
            ageNumericUpDown.TabIndex = 1;
            // 
            // employeesDataGridView
            // 
            employeesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeesDataGridView.Location = new Point(237, 90);
            employeesDataGridView.Name = "employeesDataGridView";
            employeesDataGridView.Size = new Size(375, 150);
            employeesDataGridView.TabIndex = 2;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(25, 217);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 3;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += addButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 276);
            Controls.Add(AddButton);
            Controls.Add(employeesDataGridView);
            Controls.Add(ageNumericUpDown);
            Controls.Add(nameTextBox);
            Name = "Form1";
            Text = "My program ^_^";
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private NumericUpDown ageNumericUpDown;
        private DataGridView employeesDataGridView;
        private Button AddButton;
    }
}
