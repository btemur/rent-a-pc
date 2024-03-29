﻿using System;
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
        private static Form1 form1;
        public ITechConcept tc;
        private Form1(ITechConcept tc)
        {
            InitializeComponent();
            this.tc = tc;
        }

        public static Form1 GetInstance(ITechConcept tc)
        {
            if (form1 == null)
            {
                form1 = new Form1(tc);
            }
            return form1;
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
            //return checkBox.Enabled = String.IsNullOrWhiteSpace(textBox.Text) ? false : true;
            return false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbPc_CheckedChanged(object sender, EventArgs e)
        {
            lablePcName.Text = "PC Name:";
            rbFilterAll.Checked = true;
            listBox.Items.Clear();
            foreach(var item in tc.SortPc())
            {
                listBox.Items.Add(item.Name);
            }
        }
        private void rbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            lablePcName.Text = "Customer Name:";
            rbFilterAll.Checked = true;
            listBox.Items.Clear();
            foreach (var item in tc.SortCustomer())
            {
                listBox.Items.Add(item.Name);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = listBox.SelectedIndex >= 0 ? true : false;
            buttonDelete.Enabled = listBox.SelectedIndex >= 0 ? true : false;
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
            string itemText = textBoxPCName.Text.ToString();
            if (rbCustomer.Checked == true)
            {
                tc.InsertUserIntoDb(itemText);
            }
            else
            {
                tc.InsertPcIntoDb(itemText);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string itemText = listBox.SelectedItem.ToString();
            if (rbCustomer.Checked == true)
            {
                tc.DeleteUserFromDb(itemText);
            }
            else
            {
                tc.DeletePcFromDb(itemText);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxPCName.Text))
            {
                string itemText = listBox.SelectedItem.ToString();
                string newName = textBoxPCName.Text.ToString();
                if (rbCustomer.Checked == true)
                {
                    tc.UpdateUserFromDb(itemText, newName);
                }
                else
                {
                    tc.UpdatePcFromDb(itemText, newName);
                }
            }
            else
            {
                MessageBox.Show("No new Pc name entered.");
                //TODO handling
            }
        }
    }
}
