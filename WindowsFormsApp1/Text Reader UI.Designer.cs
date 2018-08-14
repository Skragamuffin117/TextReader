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
            this.SuspendLayout();
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(190, 10);
            this.Read.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.Sort.Location = new System.Drawing.Point(156, 43);
            this.Sort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(123, 27);
            this.Sort.TabIndex = 1;
            this.Sort.Text = "Sort Alphabetically";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 496);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.Read);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Text Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button Sort;
    }
}

