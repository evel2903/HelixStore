
namespace HelixStore.WinForm.Forms
{
    partial class HomeForm
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
            this.Home_Layout = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Home_Layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // Home_Layout
            // 
            this.Home_Layout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.Home_Layout.Controls.Add(this.label1);
            this.Home_Layout.Location = new System.Drawing.Point(0, 0);
            this.Home_Layout.Margin = new System.Windows.Forms.Padding(0);
            this.Home_Layout.Name = "Home_Layout";
            this.Home_Layout.Size = new System.Drawing.Size(952, 593);
            this.Home_Layout.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(55, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 753);
            this.Controls.Add(this.Home_Layout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HomeForm";
            this.Home_Layout.ResumeLayout(false);
            this.Home_Layout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Home_Layout;
        private System.Windows.Forms.Label label1;
    }
}