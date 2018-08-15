namespace WindowsFormsApp1
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
            this.Read = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.TextList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(60, 11);
            this.Read.Margin = new System.Windows.Forms.Padding(2);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(56, 28);
            this.Read.TabIndex = 0;
            this.Read.Text = "Read";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.UseWaitCursor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(26, 43);
            this.Sort.Margin = new System.Windows.Forms.Padding(2);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(123, 27);
            this.Sort.TabIndex = 1;
            this.Sort.Text = "Sort Alphabetically";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // TextList
            // 
            this.TextList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.TextList.CheckBoxes = true;
            this.TextList.Location = new System.Drawing.Point(26, 73);
            this.TextList.Margin = new System.Windows.Forms.Padding(1);
            this.TextList.Name = "TextList";
            this.TextList.Size = new System.Drawing.Size(123, 129);
            this.TextList.TabIndex = 2;
            this.TextList.UseCompatibleStateImageBehavior = false;
            this.TextList.View = System.Windows.Forms.View.List;
            this.TextList.SelectedIndexChanged += new System.EventHandler(this.TextList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 217);
            this.Controls.Add(this.TextList);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.Read);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Text Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.ListView TextList;
    }
}

