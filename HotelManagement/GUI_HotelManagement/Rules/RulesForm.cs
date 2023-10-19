using BUS_HotelManagement;
using DAO_HotelManagement;
using DTO_HotelManagement;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_HotelManagement
{
    public partial class RulesForm : Form
    {
        public RulesForm()
        {
            InitializeComponent();
            display();
        }
        public void display()
        {
            Rule_ComboBox.Text = Rule_ComboBox.Items[0].ToString();
            Rules_DataGrid.DataSource = Rules_BUS.LoadData();
        }

        public void setComboBoxID(string selectedValue)
        {
            if (selectedValue == "Quy định chìa khóa")
            {
                Rule_ComboBox.Text = selectedValue;
                Rules_DataGrid.DataSource = Rules_BUS.LoadDataRK();
                rulesId_ComboBox.DataSource = Rules_BUS.getRulesID_RK();
            }
            else if (selectedValue == "Quy định khách sạn")
            {
                Rule_ComboBox.Text = selectedValue;
                Rules_DataGrid.DataSource = Rules_BUS.LoadDataOthers();
                rulesId_ComboBox.DataSource = Rules_BUS.getRulesID_Others();
            }
            else
            {
                Rule_ComboBox.Text = selectedValue;
                Rules_DataGrid.DataSource = Rules_BUS.LoadData();
                rulesId_ComboBox.DataSource = Rules_BUS.getRulesID();
            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            addRuleForm addRule = new addRuleForm();
            addRule.ShowDialog();
        }

        private void Rule_ComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedValue = Rule_ComboBox.SelectedItem.ToString();
            setComboBoxID(selectedValue);
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            Rule_ComboBox.Text = "All";
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            string ruleID = rulesId_ComboBox.Text;
            Rules_DTO idRule = new Rules_DTO(ruleID);
            addRuleForm updateRule = new addRuleForm(idRule);
            updateRule.ShowDialog();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            string RuleId = rulesId_ComboBox.Text;

            Rules_DTO idRules = new Rules_DTO(RuleId);
            bool flag = Rules_BUS.removeRulesID(idRules);

            if (flag)
            {
                MessageBox.Show("Xóa thành công!");
                foreach (DataGridViewRow row in Rules_DataGrid.Rows)
                {
                    if (row.Cells["ID_RULE"].Value.ToString() == RuleId)
                    {
                        Rules_DataGrid.Rows.Remove(row);
                        break;
                    }
                }
                setComboBoxID(Rule_ComboBox.Text);
                return;
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
                return;
            }
        }
    }
}
