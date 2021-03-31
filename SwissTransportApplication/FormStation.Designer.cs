
namespace SwissTransportApplication
{
    partial class FormStation
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
            this.inputStation = new System.Windows.Forms.TextBox();
            this.listStations = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputStation
            // 
            this.inputStation.Location = new System.Drawing.Point(64, 10);
            this.inputStation.Name = "inputStation";
            this.inputStation.Size = new System.Drawing.Size(156, 20);
            this.inputStation.TabIndex = 1;
            this.inputStation.TextChanged += new System.EventHandler(this.inputStation_TextChanged);
            // 
            // listStations
            // 
            this.listStations.FormattingEnabled = true;
            this.listStations.Location = new System.Drawing.Point(12, 57);
            this.listStations.Name = "listStations";
            this.listStations.Size = new System.Drawing.Size(208, 225);
            this.listStations.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Station :";
            // 
            // FormStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listStations);
            this.Controls.Add(this.inputStation);
            this.Name = "FormStation";
            this.Text = "FormStation";
            this.Load += new System.EventHandler(this.FormStation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputStation;
        private System.Windows.Forms.ListBox listStations;
        private System.Windows.Forms.Label label1;
    }
}