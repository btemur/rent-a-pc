namespace Rent_A_PC
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox = new System.Windows.Forms.ListBox();
            this.rbPc = new System.Windows.Forms.RadioButton();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.lableInfo = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rbFilterAll = new System.Windows.Forms.RadioButton();
            this.rbFilterLeased = new System.Windows.Forms.RadioButton();
            this.rbFilterAvailable = new System.Windows.Forms.RadioButton();
            this.buttonAddNewItem = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxPCName = new System.Windows.Forms.TextBox();
            this.lablePcName = new System.Windows.Forms.Label();
            this.cb_LeaseState = new System.Windows.Forms.CheckBox();
            this.gb_Output = new System.Windows.Forms.GroupBox();
            this.label_Filter = new System.Windows.Forms.Label();
            this.gb_Items = new System.Windows.Forms.GroupBox();
            this.gb_Output.SuspendLayout();
            this.gb_Items.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(5, 42);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(115, 329);
            this.listBox.TabIndex = 0;
            // 
            // rbPc
            // 
            this.rbPc.AutoSize = true;
            this.rbPc.Location = new System.Drawing.Point(6, 19);
            this.rbPc.Name = "rbPc";
            this.rbPc.Size = new System.Drawing.Size(39, 17);
            this.rbPc.TabIndex = 1;
            this.rbPc.TabStop = true;
            this.rbPc.Text = "PC";
            this.rbPc.UseVisualStyleBackColor = true;
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.Location = new System.Drawing.Point(51, 19);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(69, 17);
            this.rbCustomer.TabIndex = 2;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "Customer";
            this.rbCustomer.UseVisualStyleBackColor = true;
            // 
            // lableInfo
            // 
            this.lableInfo.AutoSize = true;
            this.lableInfo.Location = new System.Drawing.Point(6, 42);
            this.lableInfo.Name = "lableInfo";
            this.lableInfo.Size = new System.Drawing.Size(28, 13);
            this.lableInfo.TabIndex = 3;
            this.lableInfo.Text = "Info:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(436, 261);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // rbFilterAll
            // 
            this.rbFilterAll.AutoSize = true;
            this.rbFilterAll.Location = new System.Drawing.Point(44, 19);
            this.rbFilterAll.Name = "rbFilterAll";
            this.rbFilterAll.Size = new System.Drawing.Size(35, 17);
            this.rbFilterAll.TabIndex = 6;
            this.rbFilterAll.TabStop = true;
            this.rbFilterAll.Text = "all";
            this.rbFilterAll.UseVisualStyleBackColor = true;
            // 
            // rbFilterLeased
            // 
            this.rbFilterLeased.AutoSize = true;
            this.rbFilterLeased.Location = new System.Drawing.Point(85, 19);
            this.rbFilterLeased.Name = "rbFilterLeased";
            this.rbFilterLeased.Size = new System.Drawing.Size(56, 17);
            this.rbFilterLeased.TabIndex = 7;
            this.rbFilterLeased.TabStop = true;
            this.rbFilterLeased.Text = "leased";
            this.rbFilterLeased.UseVisualStyleBackColor = true;
            // 
            // rbFilterAvailable
            // 
            this.rbFilterAvailable.AutoSize = true;
            this.rbFilterAvailable.Location = new System.Drawing.Point(147, 19);
            this.rbFilterAvailable.Name = "rbFilterAvailable";
            this.rbFilterAvailable.Size = new System.Drawing.Size(67, 17);
            this.rbFilterAvailable.TabIndex = 8;
            this.rbFilterAvailable.TabStop = true;
            this.rbFilterAvailable.Text = "available";
            this.rbFilterAvailable.UseVisualStyleBackColor = true;
            // 
            // buttonAddNewItem
            // 
            this.buttonAddNewItem.Enabled = false;
            this.buttonAddNewItem.Location = new System.Drawing.Point(6, 383);
            this.buttonAddNewItem.Name = "buttonAddNewItem";
            this.buttonAddNewItem.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNewItem.TabIndex = 9;
            this.buttonAddNewItem.Text = "Add new";
            this.buttonAddNewItem.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Location = new System.Drawing.Point(307, 327);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(388, 327);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(388, 373);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxPCName
            // 
            this.textBoxPCName.Location = new System.Drawing.Point(83, 327);
            this.textBoxPCName.Name = "textBoxPCName";
            this.textBoxPCName.Size = new System.Drawing.Size(145, 20);
            this.textBoxPCName.TabIndex = 13;
            this.textBoxPCName.TextChanged += new System.EventHandler(this.TextBoxPCName_TextChanged);
            // 
            // lablePcName
            // 
            this.lablePcName.AutoSize = true;
            this.lablePcName.Location = new System.Drawing.Point(24, 332);
            this.lablePcName.Name = "lablePcName";
            this.lablePcName.Size = new System.Drawing.Size(53, 13);
            this.lablePcName.TabIndex = 14;
            this.lablePcName.Text = "PC name:";
            // 
            // cb_LeaseState
            // 
            this.cb_LeaseState.AutoSize = true;
            this.cb_LeaseState.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_LeaseState.Enabled = false;
            this.cb_LeaseState.Location = new System.Drawing.Point(234, 330);
            this.cb_LeaseState.Name = "cb_LeaseState";
            this.cb_LeaseState.Size = new System.Drawing.Size(60, 17);
            this.cb_LeaseState.TabIndex = 16;
            this.cb_LeaseState.Text = "leased:";
            this.cb_LeaseState.UseVisualStyleBackColor = true;
            // 
            // gb_Output
            // 
            this.gb_Output.Controls.Add(this.label_Filter);
            this.gb_Output.Controls.Add(this.rbFilterAvailable);
            this.gb_Output.Controls.Add(this.buttonExit);
            this.gb_Output.Controls.Add(this.cb_LeaseState);
            this.gb_Output.Controls.Add(this.rbFilterAll);
            this.gb_Output.Controls.Add(this.lablePcName);
            this.gb_Output.Controls.Add(this.textBoxPCName);
            this.gb_Output.Controls.Add(this.rbFilterLeased);
            this.gb_Output.Controls.Add(this.lableInfo);
            this.gb_Output.Controls.Add(this.buttonDelete);
            this.gb_Output.Controls.Add(this.richTextBox1);
            this.gb_Output.Controls.Add(this.buttonUpdate);
            this.gb_Output.Location = new System.Drawing.Point(149, 12);
            this.gb_Output.Name = "gb_Output";
            this.gb_Output.Size = new System.Drawing.Size(481, 412);
            this.gb_Output.TabIndex = 17;
            this.gb_Output.TabStop = false;
            this.gb_Output.Text = "Output";
            // 
            // label_Filter
            // 
            this.label_Filter.AutoSize = true;
            this.label_Filter.Location = new System.Drawing.Point(6, 21);
            this.label_Filter.Name = "label_Filter";
            this.label_Filter.Size = new System.Drawing.Size(32, 13);
            this.label_Filter.TabIndex = 17;
            this.label_Filter.Text = "Filter:";
            // 
            // gb_Items
            // 
            this.gb_Items.Controls.Add(this.rbPc);
            this.gb_Items.Controls.Add(this.listBox);
            this.gb_Items.Controls.Add(this.buttonAddNewItem);
            this.gb_Items.Controls.Add(this.rbCustomer);
            this.gb_Items.Location = new System.Drawing.Point(12, 12);
            this.gb_Items.Name = "gb_Items";
            this.gb_Items.Size = new System.Drawing.Size(131, 412);
            this.gb_Items.TabIndex = 18;
            this.gb_Items.TabStop = false;
            this.gb_Items.Text = "Items";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 430);
            this.Controls.Add(this.gb_Items);
            this.Controls.Add(this.gb_Output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_Output.ResumeLayout(false);
            this.gb_Output.PerformLayout();
            this.gb_Items.ResumeLayout(false);
            this.gb_Items.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.RadioButton rbPc;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.Label lableInfo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton rbFilterAll;
        private System.Windows.Forms.RadioButton rbFilterLeased;
        private System.Windows.Forms.RadioButton rbFilterAvailable;
        private System.Windows.Forms.Button buttonAddNewItem;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxPCName;
        private System.Windows.Forms.Label lablePcName;
        private System.Windows.Forms.CheckBox cb_LeaseState;
        private System.Windows.Forms.GroupBox gb_Output;
        private System.Windows.Forms.GroupBox gb_Items;
        private System.Windows.Forms.Label label_Filter;
    }
}

