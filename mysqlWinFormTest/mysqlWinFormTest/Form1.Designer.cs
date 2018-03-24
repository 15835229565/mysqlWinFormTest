namespace mysqlWinFormTest
{
    partial class Form1
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
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox_users = new System.Windows.Forms.ListBox();
            this.getButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(467, 25);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(117, 30);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "SAVE TO DB";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_firstName);
            this.groupBox1.Controls.Add(this.txt_lastName);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEND";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(326, 25);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(135, 26);
            this.txt_lastName.TabIndex = 1;
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(97, 25);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(133, 26);
            this.txt_firstName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Firstname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lastname:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.getButton);
            this.groupBox2.Controls.Add(this.listBox_users);
            this.groupBox2.Location = new System.Drawing.Point(13, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 335);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RECEIVE";
            // 
            // listBox_users
            // 
            this.listBox_users.FormattingEnabled = true;
            this.listBox_users.ItemHeight = 20;
            this.listBox_users.Location = new System.Drawing.Point(11, 66);
            this.listBox_users.Name = "listBox_users";
            this.listBox_users.Size = new System.Drawing.Size(579, 264);
            this.listBox_users.TabIndex = 0;
            // 
            // getButton
            // 
            this.getButton.Location = new System.Drawing.Point(467, 25);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(123, 35);
            this.getButton.TabIndex = 1;
            this.getButton.Text = "GET DATA";
            this.getButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(11, 25);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(191, 35);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "DELETE SELECTED";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 443);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "MariaDB Test Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.ListBox listBox_users;
    }
}

