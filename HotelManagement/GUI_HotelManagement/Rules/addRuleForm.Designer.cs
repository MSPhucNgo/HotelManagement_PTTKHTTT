﻿namespace GUI_HotelManagement
{
    partial class addRuleForm
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
            this.Add_Button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Type_ComboBox = new System.Windows.Forms.ComboBox();
            this.Description_Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ruleName_Text = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_Button
            // 
            this.Add_Button.FlatAppearance.BorderSize = 2;
            this.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.Add_Button.Location = new System.Drawing.Point(208, 440);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(139, 59);
            this.Add_Button.TabIndex = 1;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Button.FlatAppearance.BorderSize = 0;
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Close_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.Close_Button.Location = new System.Drawing.Point(726, 8);
            this.Close_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(46, 48);
            this.Close_Button.TabIndex = 2;
            this.Close_Button.Text = "x";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.FlatAppearance.BorderSize = 2;
            this.Refresh_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Refresh_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.Refresh_Button.Location = new System.Drawing.Point(446, 440);
            this.Refresh_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(139, 59);
            this.Refresh_Button.TabIndex = 3;
            this.Refresh_Button.Text = "Refresh";
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Refresh_Button);
            this.panel2.Controls.Add(this.Type_ComboBox);
            this.panel2.Controls.Add(this.Close_Button);
            this.panel2.Controls.Add(this.Description_Text);
            this.panel2.Controls.Add(this.Add_Button);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ruleName_Text);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(11, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 537);
            this.panel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label4.Location = new System.Drawing.Point(326, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "CREATE RULE";
            // 
            // Type_ComboBox
            // 
            this.Type_ComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Type_ComboBox.FormattingEnabled = true;
            this.Type_ComboBox.Items.AddRange(new object[] {
            "Quy định chìa khóa",
            "Quy định khách sạn"});
            this.Type_ComboBox.Location = new System.Drawing.Point(152, 368);
            this.Type_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Type_ComboBox.Name = "Type_ComboBox";
            this.Type_ComboBox.Size = new System.Drawing.Size(570, 28);
            this.Type_ComboBox.TabIndex = 5;
            // 
            // Description_Text
            // 
            this.Description_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Description_Text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Description_Text.Location = new System.Drawing.Point(153, 168);
            this.Description_Text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Description_Text.Multiline = true;
            this.Description_Text.Name = "Description_Text";
            this.Description_Text.Size = new System.Drawing.Size(569, 165);
            this.Description_Text.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rule\'s type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rule\'s name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description:";
            // 
            // ruleName_Text
            // 
            this.ruleName_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ruleName_Text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ruleName_Text.Location = new System.Drawing.Point(152, 96);
            this.ruleName_Text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ruleName_Text.Name = "ruleName_Text";
            this.ruleName_Text.Size = new System.Drawing.Size(570, 27);
            this.ruleName_Text.TabIndex = 1;
            // 
            // addRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "addRuleForm";
            this.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.Text = "Form5";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button Add_Button;
        private Button Close_Button;
        private Button Refresh_Button;
        private Panel panel2;
        private ComboBox Type_ComboBox;
        private TextBox Description_Text;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox ruleName_Text;
        private Label label4;
    }
}