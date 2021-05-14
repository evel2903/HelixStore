
namespace HelixStore.WinForm.Forms
{
    partial class InvoiceForm
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
            this.Invoice_Layout = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Invoice_Layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // Invoice_Layout
            // 
            this.Invoice_Layout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.Invoice_Layout.Controls.Add(this.label1);
            this.Invoice_Layout.Location = new System.Drawing.Point(0, 0);
            this.Invoice_Layout.Margin = new System.Windows.Forms.Padding(0);
            this.Invoice_Layout.Name = "Invoice_Layout";
            this.Invoice_Layout.Size = new System.Drawing.Size(952, 593);
            this.Invoice_Layout.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice_Layout";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 753);
            this.Controls.Add(this.Invoice_Layout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InvoiceForm";
            this.Invoice_Layout.ResumeLayout(false);
            this.Invoice_Layout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Invoice_Layout;
        private System.Windows.Forms.Label label1;
    }
}