namespace GUI_HotelManagement
{
    partial class Discount_PromotionForm
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
            Discount_DataGrid = new DataGridView();
            End_DataTime = new DateTimePicker();
            Start_DataTime = new DateTimePicker();
            ServiceID_ComboBox = new ComboBox();
            idDiscount_ComboBox = new ComboBox();
            panel4 = new Panel();
            UD_Panel = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            Update_Button = new Button();
            Disable_Button = new Button();
            panel1 = new Panel();
            panel6 = new Panel();
            Refresh_Button = new Button();
            Add_Button = new Button();
            panel7 = new Panel();
            panel8 = new Panel();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            Search_Button = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)Discount_DataGrid).BeginInit();
            panel4.SuspendLayout();
            UD_Panel.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // Discount_DataGrid
            // 
            Discount_DataGrid.BackgroundColor = Color.FromArgb(212, 230, 242);
            Discount_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Discount_DataGrid.Location = new Point(51, 92);
            Discount_DataGrid.Margin = new Padding(3, 4, 3, 4);
            Discount_DataGrid.Name = "Discount_DataGrid";
            Discount_DataGrid.RowHeadersWidth = 51;
            Discount_DataGrid.RowTemplate.Height = 24;
            Discount_DataGrid.Size = new Size(542, 521);
            Discount_DataGrid.TabIndex = 1;
            // 
            // End_DataTime
            // 
            End_DataTime.Cursor = Cursors.Hand;
            End_DataTime.Location = new Point(131, 145);
            End_DataTime.Margin = new Padding(3, 4, 3, 4);
            End_DataTime.Name = "End_DataTime";
            End_DataTime.Size = new Size(278, 23);
            End_DataTime.TabIndex = 8;
            // 
            // Start_DataTime
            // 
            Start_DataTime.CalendarFont = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Start_DataTime.Cursor = Cursors.Hand;
            Start_DataTime.Location = new Point(131, 94);
            Start_DataTime.Margin = new Padding(3, 4, 3, 4);
            Start_DataTime.Name = "Start_DataTime";
            Start_DataTime.Size = new Size(278, 23);
            Start_DataTime.TabIndex = 7;
            // 
            // ServiceID_ComboBox
            // 
            ServiceID_ComboBox.BackColor = Color.White;
            ServiceID_ComboBox.Cursor = Cursors.Hand;
            ServiceID_ComboBox.FormattingEnabled = true;
            ServiceID_ComboBox.Location = new Point(131, 44);
            ServiceID_ComboBox.Margin = new Padding(3, 4, 3, 4);
            ServiceID_ComboBox.Name = "ServiceID_ComboBox";
            ServiceID_ComboBox.Size = new Size(278, 23);
            ServiceID_ComboBox.TabIndex = 0;
            // 
            // idDiscount_ComboBox
            // 
            idDiscount_ComboBox.BackColor = Color.White;
            idDiscount_ComboBox.Cursor = Cursors.Hand;
            idDiscount_ComboBox.FormattingEnabled = true;
            idDiscount_ComboBox.Location = new Point(47, 91);
            idDiscount_ComboBox.Margin = new Padding(3, 4, 3, 4);
            idDiscount_ComboBox.Name = "idDiscount_ComboBox";
            idDiscount_ComboBox.Size = new Size(371, 23);
            idDiscount_ComboBox.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(UD_Panel);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Fill;
            panel4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1123, 657);
            panel4.TabIndex = 6;
            // 
            // UD_Panel
            // 
            UD_Panel.BackColor = Color.FromArgb(8, 48, 107);
            UD_Panel.Controls.Add(panel5);
            UD_Panel.Location = new Point(644, 409);
            UD_Panel.Name = "UD_Panel";
            UD_Panel.Padding = new Padding(10);
            UD_Panel.Size = new Size(490, 263);
            UD_Panel.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label1);
            panel5.Controls.Add(idDiscount_ComboBox);
            panel5.Controls.Add(Update_Button);
            panel5.Controls.Add(Disable_Button);
            panel5.Dock = DockStyle.Fill;
            panel5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel5.Location = new Point(10, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(470, 243);
            panel5.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 54);
            label1.Name = "label1";
            label1.Size = new Size(195, 20);
            label1.TabIndex = 6;
            label1.Text = "Discount promotion's name:";
            // 
            // Update_Button
            // 
            Update_Button.Cursor = Cursors.Hand;
            Update_Button.FlatAppearance.BorderSize = 2;
            Update_Button.FlatStyle = FlatStyle.Flat;
            Update_Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Update_Button.ForeColor = Color.FromArgb(0, 193, 138);
            Update_Button.Location = new Point(47, 146);
            Update_Button.Name = "Update_Button";
            Update_Button.Size = new Size(159, 38);
            Update_Button.TabIndex = 3;
            Update_Button.Text = "Update";
            Update_Button.UseVisualStyleBackColor = true;
            Update_Button.Click += Update_Button_Click;
            // 
            // Disable_Button
            // 
            Disable_Button.Cursor = Cursors.Hand;
            Disable_Button.FlatAppearance.BorderSize = 2;
            Disable_Button.FlatStyle = FlatStyle.Flat;
            Disable_Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Disable_Button.ForeColor = Color.FromArgb(239, 59, 44);
            Disable_Button.Location = new Point(246, 146);
            Disable_Button.Name = "Disable_Button";
            Disable_Button.Size = new Size(172, 38);
            Disable_Button.TabIndex = 4;
            Disable_Button.Text = "Delete";
            Disable_Button.UseVisualStyleBackColor = true;
            Disable_Button.Click += Disable_Button_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(8, 48, 107);
            panel1.Controls.Add(panel6);
            panel1.Location = new Point(644, 289);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 10, 0);
            panel1.Size = new Size(490, 175);
            panel1.TabIndex = 21;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(Refresh_Button);
            panel6.Controls.Add(Add_Button);
            panel6.Dock = DockStyle.Fill;
            panel6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel6.Location = new Point(10, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(470, 175);
            panel6.TabIndex = 0;
            // 
            // Refresh_Button
            // 
            Refresh_Button.Cursor = Cursors.Hand;
            Refresh_Button.FlatAppearance.BorderSize = 2;
            Refresh_Button.FlatStyle = FlatStyle.Flat;
            Refresh_Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Refresh_Button.ForeColor = Color.FromArgb(8, 48, 107);
            Refresh_Button.Location = new Point(246, 43);
            Refresh_Button.Name = "Refresh_Button";
            Refresh_Button.Size = new Size(172, 39);
            Refresh_Button.TabIndex = 3;
            Refresh_Button.Text = "Refresh";
            Refresh_Button.UseVisualStyleBackColor = true;
            Refresh_Button.Click += Refresh_Button_Click;
            // 
            // Add_Button
            // 
            Add_Button.Cursor = Cursors.Hand;
            Add_Button.FlatAppearance.BorderSize = 2;
            Add_Button.FlatStyle = FlatStyle.Flat;
            Add_Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Add_Button.ForeColor = Color.FromArgb(0, 193, 138);
            Add_Button.Location = new Point(47, 43);
            Add_Button.Name = "Add_Button";
            Add_Button.Size = new Size(166, 39);
            Add_Button.TabIndex = 2;
            Add_Button.Text = "Add";
            Add_Button.UseVisualStyleBackColor = true;
            Add_Button.Click += Add_Button_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(8, 48, 107);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(644, 0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(10, 0, 10, 10);
            panel7.Size = new Size(490, 290);
            panel7.TabIndex = 20;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(label3);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(label6);
            panel8.Controls.Add(Search_Button);
            panel8.Controls.Add(ServiceID_ComboBox);
            panel8.Controls.Add(End_DataTime);
            panel8.Controls.Add(Start_DataTime);
            panel8.Dock = DockStyle.Fill;
            panel8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel8.Location = new Point(10, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(470, 280);
            panel8.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 150);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 15;
            label3.Text = "Finish date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Window;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(31, 53);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 14;
            label5.Text = "Floor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Window;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(31, 101);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 1;
            label6.Text = "Start date:";
            // 
            // Search_Button
            // 
            Search_Button.BackColor = Color.White;
            Search_Button.Cursor = Cursors.Hand;
            Search_Button.FlatAppearance.BorderColor = Color.FromArgb(8, 48, 107);
            Search_Button.FlatAppearance.BorderSize = 2;
            Search_Button.FlatStyle = FlatStyle.Flat;
            Search_Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Search_Button.ForeColor = Color.FromArgb(8, 48, 107);
            Search_Button.Location = new Point(197, 202);
            Search_Button.Name = "Search_Button";
            Search_Button.Size = new Size(94, 51);
            Search_Button.TabIndex = 4;
            Search_Button.Text = "Search";
            Search_Button.UseVisualStyleBackColor = false;
            Search_Button.Click += Search_Button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(8, 48, 107);
            label4.Location = new Point(152, 33);
            label4.Name = "label4";
            label4.Size = new Size(323, 32);
            label4.TabIndex = 19;
            label4.Text = "List of Discount Promotion";
            // 
            // Discount_PromotionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 48, 107);
            ClientSize = new Size(1135, 670);
            Controls.Add(Discount_DataGrid);
            Controls.Add(panel4);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Discount_PromotionForm";
            Padding = new Padding(0, 0, 12, 13);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chương trình khuyến mãi";
            ((System.ComponentModel.ISupportInitialize)Discount_DataGrid).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            UD_Panel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView Discount_DataGrid;
        private ComboBox ServiceID_ComboBox;
        private ComboBox idDiscount_ComboBox;
        private DateTimePicker End_DataTime;
        private DateTimePicker Start_DataTime;
        private Panel panel4;
        private Label label4;
        private Panel UD_Panel;
        private Panel panel5;
        private Label label1;
        private Button Update_Button;
        private Button Disable_Button;
        private Panel panel1;
        private Panel panel6;
        private Button Refresh_Button;
        private Button Add_Button;
        private Panel panel7;
        private Panel panel8;
        private Label label5;
        private Label label6;
        private Button Search_Button;
        private Label label3;
    }
}