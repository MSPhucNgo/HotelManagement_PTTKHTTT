namespace GUI_HotelManagement
{
    partial class RulesForm
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
            Rule_ComboBox = new ComboBox();
            Rules_DataGrid = new DataGridView();
            Add_Button = new Button();
            rulesId_ComboBox = new ComboBox();
            Delete_Button = new Button();
            Update_Button = new Button();
            panel1 = new Panel();
            label1 = new Label();
            Refresh_Button = new Button();
            panel2 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Rules_DataGrid).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Rule_ComboBox
            // 
            Rule_ComboBox.Cursor = Cursors.Hand;
            Rule_ComboBox.FormattingEnabled = true;
            Rule_ComboBox.Items.AddRange(new object[] { "All", "Quy định chìa khóa", "Quy định khách sạn" });
            Rule_ComboBox.Location = new Point(36, 69);
            Rule_ComboBox.Name = "Rule_ComboBox";
            Rule_ComboBox.Size = new Size(425, 23);
            Rule_ComboBox.TabIndex = 0;
            Rule_ComboBox.SelectedIndexChanged += Rule_ComboBox_SelectedIndexChanged_1;
            // 
            // Rules_DataGrid
            // 
            Rules_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Rules_DataGrid.Location = new Point(38, 307);
            Rules_DataGrid.Name = "Rules_DataGrid";
            Rules_DataGrid.RowHeadersWidth = 51;
            Rules_DataGrid.RowTemplate.Height = 24;
            Rules_DataGrid.Size = new Size(1032, 278);
            Rules_DataGrid.TabIndex = 2;
            // 
            // Add_Button
            // 
            Add_Button.BackColor = Color.White;
            Add_Button.Cursor = Cursors.Hand;
            Add_Button.FlatAppearance.BorderSize = 2;
            Add_Button.FlatStyle = FlatStyle.Flat;
            Add_Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Add_Button.ForeColor = Color.FromArgb(0, 193, 138);
            Add_Button.Location = new Point(36, 110);
            Add_Button.Name = "Add_Button";
            Add_Button.Size = new Size(193, 43);
            Add_Button.TabIndex = 3;
            Add_Button.Text = "Add";
            Add_Button.UseVisualStyleBackColor = false;
            Add_Button.Click += Add_Button_Click;
            // 
            // rulesId_ComboBox
            // 
            rulesId_ComboBox.Cursor = Cursors.Hand;
            rulesId_ComboBox.FormattingEnabled = true;
            rulesId_ComboBox.Location = new Point(34, 90);
            rulesId_ComboBox.Name = "rulesId_ComboBox";
            rulesId_ComboBox.Size = new Size(247, 23);
            rulesId_ComboBox.TabIndex = 6;
            // 
            // Delete_Button
            // 
            Delete_Button.BackColor = Color.White;
            Delete_Button.Cursor = Cursors.Hand;
            Delete_Button.FlatAppearance.BorderSize = 2;
            Delete_Button.FlatStyle = FlatStyle.Flat;
            Delete_Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Delete_Button.ForeColor = Color.Red;
            Delete_Button.Location = new Point(318, 114);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(144, 51);
            Delete_Button.TabIndex = 4;
            Delete_Button.Text = "Delete";
            Delete_Button.UseVisualStyleBackColor = false;
            Delete_Button.Click += Delete_Button_Click;
            // 
            // Update_Button
            // 
            Update_Button.BackColor = Color.White;
            Update_Button.Cursor = Cursors.Hand;
            Update_Button.FlatAppearance.BorderSize = 2;
            Update_Button.FlatStyle = FlatStyle.Flat;
            Update_Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Update_Button.ForeColor = Color.FromArgb(0, 193, 138);
            Update_Button.Location = new Point(318, 45);
            Update_Button.Name = "Update_Button";
            Update_Button.Size = new Size(144, 51);
            Update_Button.TabIndex = 5;
            Update_Button.Text = "Update";
            Update_Button.UseVisualStyleBackColor = false;
            Update_Button.Click += Update_Button_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(235, 246, 252);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(rulesId_ComboBox);
            panel1.Controls.Add(Update_Button);
            panel1.Controls.Add(Delete_Button);
            panel1.Location = new Point(578, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 204);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 61);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 17;
            label1.Text = "Selected Rule:";
            // 
            // Refresh_Button
            // 
            Refresh_Button.BackColor = Color.White;
            Refresh_Button.Cursor = Cursors.Hand;
            Refresh_Button.FlatAppearance.BorderSize = 2;
            Refresh_Button.FlatStyle = FlatStyle.Flat;
            Refresh_Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Refresh_Button.ForeColor = Color.FromArgb(8, 48, 107);
            Refresh_Button.Location = new Point(266, 110);
            Refresh_Button.Name = "Refresh_Button";
            Refresh_Button.Size = new Size(195, 43);
            Refresh_Button.TabIndex = 9;
            Refresh_Button.Text = "Refresh";
            Refresh_Button.UseVisualStyleBackColor = false;
            Refresh_Button.Click += Refresh_Button_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(235, 246, 252);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(Refresh_Button);
            panel2.Controls.Add(Add_Button);
            panel2.Controls.Add(Rule_ComboBox);
            panel2.Location = new Point(38, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(497, 204);
            panel2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 39);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 16;
            label4.Text = "Types of Rule:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(8, 48, 107);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 621);
            panel3.Name = "panel3";
            panel3.Size = new Size(1119, 10);
            panel3.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(8, 48, 107);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1109, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 621);
            panel4.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(8, 48, 107);
            label2.Location = new Point(480, 263);
            label2.Name = "label2";
            label2.Size = new Size(153, 32);
            label2.TabIndex = 17;
            label2.Text = "List of Rules";
            // 
            // RulesForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1119, 631);
            Controls.Add(label2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Rules_DataGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RulesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quy định khách sạn";
            ((System.ComponentModel.ISupportInitialize)Rules_DataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Rule_ComboBox;
        private DataGridView Rules_DataGrid;
        private Button Add_Button;
        private ComboBox rulesId_ComboBox;
        private Button Delete_Button;
        private Button Update_Button;
        private Panel panel1;
        private Button Refresh_Button;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label4;
        private Label label1;
        private Label label2;
    }
}

