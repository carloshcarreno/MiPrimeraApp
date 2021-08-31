
namespace MiPrimeraApp
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbtn_test = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnl_radios = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rtbox_description = new System.Windows.Forms.RichTextBox();
            this.rtbox_result = new System.Windows.Forms.RichTextBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.pnl_radios.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblName.Location = new System.Drawing.Point(85, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(88, 102);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 22);
            this.txtName.TabIndex = 1;
            this.txtName.Click += new System.EventHandler(this.CustomEvent);
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(210, 381);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(91, 37);
            this.btnAction.TabIndex = 2;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(88, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(25, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 21);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(25, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 21);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbtn_test
            // 
            this.rbtn_test.AutoSize = true;
            this.rbtn_test.Location = new System.Drawing.Point(301, 311);
            this.rbtn_test.Name = "rbtn_test";
            this.rbtn_test.Size = new System.Drawing.Size(110, 21);
            this.rbtn_test.TabIndex = 6;
            this.rbtn_test.TabStop = true;
            this.rbtn_test.Text = "radioButton3";
            this.rbtn_test.UseVisualStyleBackColor = true;
            this.rbtn_test.Click += new System.EventHandler(this.CustomEvent);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(301, 223);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // pnl_radios
            // 
            this.pnl_radios.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnl_radios.Controls.Add(this.radioButton2);
            this.pnl_radios.Controls.Add(this.radioButton1);
            this.pnl_radios.Location = new System.Drawing.Point(310, 95);
            this.pnl_radios.Name = "pnl_radios";
            this.pnl_radios.Size = new System.Drawing.Size(200, 100);
            this.pnl_radios.TabIndex = 10;
            this.pnl_radios.Click += new System.EventHandler(this.CustomEvent);
            // 
            // rtbox_description
            // 
            this.rtbox_description.Location = new System.Drawing.Point(90, 196);
            this.rtbox_description.Name = "rtbox_description";
            this.rtbox_description.Size = new System.Drawing.Size(179, 96);
            this.rtbox_description.TabIndex = 11;
            this.rtbox_description.Text = "";
            // 
            // rtbox_result
            // 
            this.rtbox_result.Location = new System.Drawing.Point(607, 58);
            this.rtbox_result.Name = "rtbox_result";
            this.rtbox_result.Size = new System.Drawing.Size(312, 231);
            this.rtbox_result.TabIndex = 12;
            this.rtbox_result.Text = "";
            this.rtbox_result.TextChanged += new System.EventHandler(this.rtbox_result_TextChanged);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(360, 381);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(85, 37);
            this.btnReport.TabIndex = 13;
            this.btnReport.Text = "Reporte";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.CustomEvent);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.rtbox_result);
            this.Controls.Add(this.rtbox_description);
            this.Controls.Add(this.pnl_radios);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.rbtn_test);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "MainForm";
            this.Text = "Welcome Mano!";
            this.pnl_radios.ResumeLayout(false);
            this.pnl_radios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbtn_test;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel pnl_radios;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox rtbox_description;
        private System.Windows.Forms.RichTextBox rtbox_result;
        private System.Windows.Forms.Button btnReport;
    }
}