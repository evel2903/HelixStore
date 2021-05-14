
namespace HelixStore.WinForm.Forms
{
    partial class CustomersForm
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
            this.Customer_Layout = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Customer_Layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // Customer_Layout
            // 
            this.Customer_Layout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.Customer_Layout.Controls.Add(this.label1);
            this.Customer_Layout.Location = new System.Drawing.Point(0, 0);
            this.Customer_Layout.Margin = new System.Windows.Forms.Padding(0);
            this.Customer_Layout.Name = "Customer_Layout";
            this.Customer_Layout.Size = new System.Drawing.Size(952, 593);
            this.Customer_Layout.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer_Layout";
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 753);
            this.Controls.Add(this.Customer_Layout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomersForm";
            this.Customer_Layout.ResumeLayout(false);
            this.Customer_Layout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Customer_Layout;
        private System.Windows.Forms.Label label1;
    }
}