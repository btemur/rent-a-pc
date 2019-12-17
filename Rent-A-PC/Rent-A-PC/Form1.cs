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
        public Form1()
        {
            InitializeComponent();
            DataManagementSQL data = new DataManagementSQL();

            Console.WriteLine("pc");
            foreach (var item in data.AllPcs())
            {
                Console.WriteLine(item.Id + item.Name + item.leasedTo);
            }
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
    }
}
