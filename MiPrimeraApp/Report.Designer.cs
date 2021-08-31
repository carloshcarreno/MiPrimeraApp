
namespace MiPrimeraApp
{
    partial class Report
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
            this.rtbox_report = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbox_report
            // 
            this.rtbox_report.Location = new System.Drawing.Point(135, 65);
            this.rtbox_report.Name = "rtbox_report";
            this.rtbox_report.Size = new System.Drawing.Size(425, 237);
            this.rtbox_report.TabIndex = 0;
            this.rtbox_report.Text = "";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 424);
            this.Controls.Add(this.rtbox_report);
            this.Name = "Report";
            this.Text = "Report";
            this.ResumeLayout(false);

        }

        #endregion

        public void ShowReportInformation(string txt)
        {
            rtbox_report.Text = txt;
        }


        private System.Windows.Forms.RichTextBox rtbox_report;
    }
}