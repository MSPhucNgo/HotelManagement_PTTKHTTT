namespace GUI_HotelManagement
{
    partial class damagedItems
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
            damageList_DataGrid = new DataGridView();
            items_ComboBox = new ComboBox();
            ListRoom_Layout = new FlowLayoutPanel();
            amount_Text = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Confirm_Button = new Button();
            add_Button = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)damageList_DataGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // damageList_DataGrid
            // 
            damageList_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            damageList_DataGrid.Location = new Point(467, 171);
            damageList_DataGrid.Margin = new Padding(3, 2, 3, 2);
            damageList_DataGrid.Name = "damageList_DataGrid";
            damageList_DataGrid.RowHeadersWidth = 51;
            damageList_DataGrid.RowTemplate.Height = 29;
            damageList_DataGrid.Size = new Size(256, 247);
            damageList_DataGrid.TabIndex = 0;
            // 
            // items_ComboBox
            // 
            items_ComboBox.Enabled = false;
            items_ComboBox.FormattingEnabled = true;
            items_ComboBox.Location = new Point(535, 55);
            items_ComboBox.Margin = new Padding(3, 2, 3, 2);
            items_ComboBox.Name = "items_ComboBox";
            items_ComboBox.Size = new Size(188, 23);
            items_ComboBox.TabIndex = 2;
            // 
            // ListRoom_Layout
            // 
            ListRoom_Layout.AllowDrop = true;
            ListRoom_Layout.AutoScroll = true;
            ListRoom_Layout.Location = new Point(30, 79);
            ListRoom_Layout.Margin = new Padding(3, 2, 3, 2);
            ListRoom_Layout.Name = "ListRoom_Layout";
            ListRoom_Layout.Size = new Size(408, 389);
            ListRoom_Layout.TabIndex = 3;
            // 
            // amount_Text
            // 
            amount_Text.BorderStyle = BorderStyle.FixedSingle;
            amount_Text.Cursor = Cursors.IBeam;
            amount_Text.Enabled = false;
            amount_Text.Location = new Point(535, 87);
            amount_Text.Margin = new Padding(3, 2, 3, 2);
            amount_Text.Name = "amount_Text";
            amount_Text.Size = new Size(72, 23);
            amount_Text.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(467, 59);
            label1.Name = "label1";
            label1.Size = new Size(40, 19);
            label1.TabIndex = 7;
            label1.Text = "Item:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(467, 87);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 8;
            label2.Text = "Amount:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(8, 48, 107);
            label3.Location = new Point(467, 141);
            label3.Name = "label3";
            label3.Size = new Size(156, 21);
            label3.TabIndex = 9;
            label3.Text = "List damaged items:";
            // 
            // Confirm_Button
            // 
            Confirm_Button.BackColor = Color.FromArgb(8, 48, 107);
            Confirm_Button.Cursor = Cursors.Hand;
            Confirm_Button.FlatAppearance.BorderSize = 0;
            Confirm_Button.FlatStyle = FlatStyle.Flat;
            Confirm_Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Confirm_Button.ForeColor = Color.White;
            Confirm_Button.Location = new Point(537, 435);
            Confirm_Button.Name = "Confirm_Button";
            Confirm_Button.Size = new Size(118, 33);
            Confirm_Button.TabIndex = 27;
            Confirm_Button.Text = "Confirm";
            Confirm_Button.UseVisualStyleBackColor = false;
            Confirm_Button.Click += Confirm_Button_Click;
            // 
            // add_Button
            // 
            add_Button.BackColor = Color.FromArgb(0, 193, 138);
            add_Button.Cursor = Cursors.Hand;
            add_Button.FlatAppearance.BorderSize = 0;
            add_Button.FlatStyle = FlatStyle.Flat;
            add_Button.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            add_Button.ForeColor = Color.White;
            add_Button.Location = new Point(652, 85);
            add_Button.Name = "add_Button";
            add_Button.Size = new Size(71, 25);
            add_Button.TabIndex = 26;
            add_Button.Text = "+  Add";
            add_Button.UseVisualStyleBackColor = false;
            add_Button.Click += add_Button_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(Confirm_Button);
            panel1.Controls.Add(ListRoom_Layout);
            panel1.Controls.Add(add_Button);
            panel1.Controls.Add(amount_Text);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(items_ComboBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(damageList_DataGrid);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 486);
            panel1.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(8, 48, 107);
            label4.Location = new Point(29, 53);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 93;
            label4.Text = "List rooms:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ControlLightLight;
            label11.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(8, 48, 107);
            label11.Location = new Point(281, 10);
            label11.Name = "label11";
            label11.Size = new Size(216, 30);
            label11.TabIndex = 92;
            label11.Text = "Add Damaged Item";
            // 
            // damagedItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 48, 107);
            ClientSize = new Size(772, 506);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "damagedItems";
            Padding = new Padding(10, 10, 10, 10);
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)damageList_DataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView damageList_DataGrid;
        private ComboBox items_ComboBox;
        private FlowLayoutPanel ListRoom_Layout;
        private TextBox amount_Text;
        private Button add_Button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Confirm_Button;
        private Button button5;
        private Panel panel1;
        private Label label11;
        private Label label4;
    }
}