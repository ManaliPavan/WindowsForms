
namespace WinFormDemo
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.listNames = new System.Windows.Forms.ListBox();
            this.addname = new System.Windows.Forms.Button();
            this.deletename = new System.Windows.Forms.Button();
            this.clearlist = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(274, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(197, 22);
            this.txtName.TabIndex = 1;
            // 
            // listNames
            // 
            this.listNames.FormattingEnabled = true;
            this.listNames.ItemHeight = 16;
            this.listNames.Location = new System.Drawing.Point(274, 161);
            this.listNames.Name = "listNames";
            this.listNames.Size = new System.Drawing.Size(197, 148);
            this.listNames.TabIndex = 2;
            // 
            // addname
            // 
            this.addname.Location = new System.Drawing.Point(543, 93);
            this.addname.Name = "addname";
            this.addname.Size = new System.Drawing.Size(152, 35);
            this.addname.TabIndex = 3;
            this.addname.Text = "Add";
            this.addname.UseVisualStyleBackColor = true;
            this.addname.Click += new System.EventHandler(this.addname_Click);
            // 
            // deletename
            // 
            this.deletename.Location = new System.Drawing.Point(543, 161);
            this.deletename.Name = "deletename";
            this.deletename.Size = new System.Drawing.Size(152, 31);
            this.deletename.TabIndex = 4;
            this.deletename.Text = "Delete Name";
            this.deletename.UseVisualStyleBackColor = true;
            this.deletename.Click += new System.EventHandler(this.deletename_Click);
            // 
            // clearlist
            // 
            this.clearlist.Location = new System.Drawing.Point(543, 225);
            this.clearlist.Name = "clearlist";
            this.clearlist.Size = new System.Drawing.Size(152, 33);
            this.clearlist.TabIndex = 5;
            this.clearlist.Text = "Clear List";
            this.clearlist.UseVisualStyleBackColor = true;
            this.clearlist.Click += new System.EventHandler(this.clearlist_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Names";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearlist);
            this.Controls.Add(this.deletename);
            this.Controls.Add(this.addname);
            this.Controls.Add(this.listNames);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "List Names";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox listNames;
        private System.Windows.Forms.Button addname;
        private System.Windows.Forms.Button deletename;
        private System.Windows.Forms.Button clearlist;
        private System.Windows.Forms.Label label2;
    }
}