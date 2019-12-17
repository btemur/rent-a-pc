using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


using Rent_A_PC.DataManagement;

namespace Rent_A_PC
{
    public partial class Form1 : Form
    {
        public ITechConcept tc;
        public Form1(ITechConcept tc)
        {
            InitializeComponent();
            this.tc = tc;
        }
        
        private void TextBoxPCName_TextChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = cb_LeaseState;
            Button button = buttonAddNewItem;
            TextBox textBox = textBoxPCName;
            ChangeCheckBoxState(checkBox, textBox);
            ChangeButtonsState(button, textBox);
        }
        bool ChangeButtonsState(Button button, TextBox textBox)
        {
            return button.Enabled = String.IsNullOrWhiteSpace(textBox.Text) ? false : true;
        }
        bool ChangeCheckBoxState(CheckBox checkBox, TextBox textBox)
        {
            return checkBox.Enabled = String.IsNullOrWhiteSpace(textBox.Text) ? false : true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbPc_CheckedChanged(object sender, EventArgs e)
        {
            rbFilterAll.Checked = true;
            listBox.Items.Clear();
            foreach(var item in tc.SortPc())
            {
                listBox.Items.Add(item.Name);
            }
        }
        private void rbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            rbFilterAll.Checked = true;
            listBox.Items.Clear();
            foreach (var item in tc.SortCustomer())
            {
                listBox.Items.Add(item.Name);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: Activate Update Button
            //infoBox.Text
            infoBox.Clear();
            string itemText = listBox.SelectedItem.ToString();
            if(rbPc.Checked == true)
            {
                var pc = tc.GetSelectedPc(itemText);
                infoBox.Text = "ID = " + pc.Id +
                               "\nName = " + pc.Name +
                               "\nLeased to = " + pc.leasedTo;
            }
            else
            {
                var user = tc.GetSelectedUser(itemText);
                infoBox.Text = "ID = " + user.Id +
                               "\nName = " + user.Name;
            }
        }

        private void rbFilterLeased_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCustomer.Checked == true)
            {
                listBox.Items.Clear();
                foreach (var item in tc.LeasedUser())
                {
                    listBox.Items.Add(item.Name);
                }
            }
            else if(rbPc.Checked == true)
            {
                listBox.Items.Clear();
                foreach(var item in tc.LeasedPc())
                {
                    listBox.Items.Add(item.Name);
                }
            }
            else
            {
                MessageBox.Show("Select 'Pc' or 'Customer'");
                //TODO: handling
            }
        }

        private void rbFilterAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustomer.Checked == true)
            {
                listBox.Items.Clear();
                foreach (var item in tc.SortCustomer())
                {
                    listBox.Items.Add(item.Name);
                }
            }
            else
            {
                listBox.Items.Clear();
                foreach (var item in tc.SortPc())
                {
                    listBox.Items.Add(item.Name);
                }
            }
        }

        private void rbFilterAvailable_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustomer.Checked == true)
            {
                listBox.Items.Clear();
                foreach (var item in tc.NonLeasedUser())
                {
                    listBox.Items.Add(item.Name);
                }
            }
            else if (rbPc.Checked == true)
            {
                listBox.Items.Clear();
                foreach (var item in tc.NonLeasedPc())
                {
                    listBox.Items.Add(item.Name);
                }
            }
            else
            {
                MessageBox.Show("Select 'Pc' or 'Customer'");
                //TODO: handling
            }
        }

        private void buttonAddNewItem_Click(object sender, EventArgs e)
        {
            string pcname = textBoxPCName.Text.ToString();
            tc.InsertPcIntoDb(pcname);
        }
    }
}
