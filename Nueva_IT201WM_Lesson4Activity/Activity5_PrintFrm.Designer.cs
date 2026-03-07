namespace Nueva_IT201WM_Lesson4Activity
{
    partial class Activity5_PrintFrm
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
            this.priDisplay_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // priDisplay_listbox
            // 
            this.priDisplay_listbox.FormattingEnabled = true;
            this.priDisplay_listbox.ItemHeight = 20;
            this.priDisplay_listbox.Location = new System.Drawing.Point(12, 12);
            this.priDisplay_listbox.Name = "priDisplay_listbox";
            this.priDisplay_listbox.Size = new System.Drawing.Size(463, 424);
            this.priDisplay_listbox.TabIndex = 0;
            // 
            // Activity5_PrintFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.priDisplay_listbox);
            this.Name = "Activity5_PrintFrm";
            this.Text = "Activity5_PrintFrm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox priDisplay_listbox;
    }
}