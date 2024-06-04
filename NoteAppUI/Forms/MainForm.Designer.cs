namespace NoteAppUI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ControlPanelBox = new System.Windows.Forms.GroupBox();
            this.DeleteContactPicture = new System.Windows.Forms.PictureBox();
            this.EditContactPicture = new System.Windows.Forms.PictureBox();
            this.AddContactPicture = new System.Windows.Forms.PictureBox();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.FindContactTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonalInformationBox = new System.Windows.Forms.GroupBox();
            this.BirthdayDateTime = new System.Windows.Forms.DateTimePicker();
            this.VkTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ControlPanelBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteContactPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditContactPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddContactPicture)).BeginInit();
            this.PersonalInformationBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactToolStripMenuItem,
            this.editContactToolStripMenuItem,
            this.deleteContactToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ControlPanelBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PersonalInformationBox);
            this.splitContainer1.Size = new System.Drawing.Size(746, 427);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 1;
            // 
            // ControlPanelBox
            // 
            this.ControlPanelBox.Controls.Add(this.DeleteContactPicture);
            this.ControlPanelBox.Controls.Add(this.EditContactPicture);
            this.ControlPanelBox.Controls.Add(this.AddContactPicture);
            this.ControlPanelBox.Controls.Add(this.ContactsListBox);
            this.ControlPanelBox.Controls.Add(this.FindContactTextBox);
            this.ControlPanelBox.Controls.Add(this.label1);
            this.ControlPanelBox.Location = new System.Drawing.Point(3, 3);
            this.ControlPanelBox.Name = "ControlPanelBox";
            this.ControlPanelBox.Size = new System.Drawing.Size(264, 420);
            this.ControlPanelBox.TabIndex = 3;
            this.ControlPanelBox.TabStop = false;
            this.ControlPanelBox.Text = "Control Panel";
            // 
            // DeleteContactPicture
            // 
            this.DeleteContactPicture.Image = global::NoteAppUI.Properties.Resources.DeleteContactIcon_512x512;
            this.DeleteContactPicture.Location = new System.Drawing.Point(81, 381);
            this.DeleteContactPicture.Name = "DeleteContactPicture";
            this.DeleteContactPicture.Size = new System.Drawing.Size(30, 30);
            this.DeleteContactPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeleteContactPicture.TabIndex = 5;
            this.DeleteContactPicture.TabStop = false;
            this.DeleteContactPicture.Click += new System.EventHandler(this.DeleteContactPicture_Click);
            // 
            // EditContactPicture
            // 
            this.EditContactPicture.Image = global::NoteAppUI.Properties.Resources.EditContactIcon_512x512;
            this.EditContactPicture.Location = new System.Drawing.Point(45, 381);
            this.EditContactPicture.Name = "EditContactPicture";
            this.EditContactPicture.Size = new System.Drawing.Size(30, 30);
            this.EditContactPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditContactPicture.TabIndex = 4;
            this.EditContactPicture.TabStop = false;
            this.EditContactPicture.Click += new System.EventHandler(this.EditContactPicture_Click);
            // 
            // AddContactPicture
            // 
            this.AddContactPicture.Image = global::NoteAppUI.Properties.Resources.AddContactIcon_512x512;
            this.AddContactPicture.Location = new System.Drawing.Point(9, 381);
            this.AddContactPicture.Name = "AddContactPicture";
            this.AddContactPicture.Size = new System.Drawing.Size(30, 30);
            this.AddContactPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddContactPicture.TabIndex = 3;
            this.AddContactPicture.TabStop = false;
            this.AddContactPicture.Click += new System.EventHandler(this.AddContact_Click);
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.Location = new System.Drawing.Point(9, 61);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(251, 316);
            this.ContactsListBox.TabIndex = 2;
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox_SelectedIndexChanged);
            // 
            // FindContactTextBox
            // 
            this.FindContactTextBox.Location = new System.Drawing.Point(44, 29);
            this.FindContactTextBox.Name = "FindContactTextBox";
            this.FindContactTextBox.Size = new System.Drawing.Size(216, 20);
            this.FindContactTextBox.TabIndex = 1;
            this.FindContactTextBox.TextChanged += new System.EventHandler(this.FindContactTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find";
            // 
            // PersonalInformationBox
            // 
            this.PersonalInformationBox.Controls.Add(this.BirthdayDateTime);
            this.PersonalInformationBox.Controls.Add(this.VkTextBox);
            this.PersonalInformationBox.Controls.Add(this.label7);
            this.PersonalInformationBox.Controls.Add(this.label2);
            this.PersonalInformationBox.Controls.Add(this.SurnameTextBox);
            this.PersonalInformationBox.Controls.Add(this.label6);
            this.PersonalInformationBox.Controls.Add(this.label3);
            this.PersonalInformationBox.Controls.Add(this.EmailTextBox);
            this.PersonalInformationBox.Controls.Add(this.NameTextBox);
            this.PersonalInformationBox.Controls.Add(this.label5);
            this.PersonalInformationBox.Controls.Add(this.label4);
            this.PersonalInformationBox.Controls.Add(this.PhoneTextBox);
            this.PersonalInformationBox.Location = new System.Drawing.Point(3, 3);
            this.PersonalInformationBox.Name = "PersonalInformationBox";
            this.PersonalInformationBox.Size = new System.Drawing.Size(469, 220);
            this.PersonalInformationBox.TabIndex = 13;
            this.PersonalInformationBox.TabStop = false;
            this.PersonalInformationBox.Text = "Personal information";
            // 
            // BirthdayDateTime
            // 
            this.BirthdayDateTime.Location = new System.Drawing.Point(61, 93);
            this.BirthdayDateTime.Name = "BirthdayDateTime";
            this.BirthdayDateTime.Size = new System.Drawing.Size(399, 20);
            this.BirthdayDateTime.TabIndex = 13;
            this.BirthdayDateTime.ValueChanged += new System.EventHandler(this.BirthdayDateTime_ValueChanged);
            // 
            // VkTextBox
            // 
            this.VkTextBox.Location = new System.Drawing.Point(61, 189);
            this.VkTextBox.Name = "VkTextBox";
            this.VkTextBox.ReadOnly = true;
            this.VkTextBox.Size = new System.Drawing.Size(399, 20);
            this.VkTextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Birthday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(61, 29);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.ReadOnly = true;
            this.SurnameTextBox.Size = new System.Drawing.Size(399, 20);
            this.SurnameTextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(61, 157);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.ReadOnly = true;
            this.EmailTextBox.Size = new System.Drawing.Size(399, 20);
            this.EmailTextBox.TabIndex = 9;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(61, 61);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(399, 20);
            this.NameTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(61, 125);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.ReadOnly = true;
            this.PhoneTextBox.Size = new System.Drawing.Size(399, 20);
            this.PhoneTextBox.TabIndex = 7;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // addContactToolStripMenuItem
            // 
            this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            this.addContactToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addContactToolStripMenuItem.Text = "Add contact";
            this.addContactToolStripMenuItem.Click += new System.EventHandler(this.AddContact_Click);
            // 
            // editContactToolStripMenuItem
            // 
            this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            this.editContactToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editContactToolStripMenuItem.Text = "Edit contact";
            this.editContactToolStripMenuItem.Click += new System.EventHandler(this.EditContactPicture_Click);
            // 
            // deleteContactToolStripMenuItem
            // 
            this.deleteContactToolStripMenuItem.Name = "deleteContactToolStripMenuItem";
            this.deleteContactToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteContactToolStripMenuItem.Text = "Delete contact";
            this.deleteContactToolStripMenuItem.Click += new System.EventHandler(this.DeleteContactPicture_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 451);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Contact App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ControlPanelBox.ResumeLayout(false);
            this.ControlPanelBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteContactPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditContactPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddContactPicture)).EndInit();
            this.PersonalInformationBox.ResumeLayout(false);
            this.PersonalInformationBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.TextBox FindContactTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VkTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox PersonalInformationBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker BirthdayDateTime;
        private System.Windows.Forms.GroupBox ControlPanelBox;
        private System.Windows.Forms.PictureBox AddContactPicture;
        private System.Windows.Forms.PictureBox DeleteContactPicture;
        private System.Windows.Forms.PictureBox EditContactPicture;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}