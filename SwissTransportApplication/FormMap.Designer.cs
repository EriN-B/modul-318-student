
namespace SwissTransportApplication
{
    partial class FormMap
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
            this.labelStation = new System.Windows.Forms.Label();
            this.inputLocation = new System.Windows.Forms.ComboBox();
            this.buttonLocation = new System.Windows.Forms.Button();
            this.webBrowserMaps = new System.Windows.Forms.WebBrowser();
            this.radioWeb = new System.Windows.Forms.RadioButton();
            this.radioApp = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelStation
            // 
            this.labelStation.AutoSize = true;
            this.labelStation.Location = new System.Drawing.Point(13, 22);
            this.labelStation.Name = "labelStation";
            this.labelStation.Size = new System.Drawing.Size(47, 13);
            this.labelStation.TabIndex = 0;
            this.labelStation.Text = "Standort";
            // 
            // inputLocation
            // 
            this.inputLocation.FormattingEnabled = true;
            this.inputLocation.Location = new System.Drawing.Point(16, 38);
            this.inputLocation.Name = "inputLocation";
            this.inputLocation.Size = new System.Drawing.Size(202, 21);
            this.inputLocation.TabIndex = 1;
            this.inputLocation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputLocation_KeyPress);
            // 
            // buttonLocation
            // 
            this.buttonLocation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonLocation.Location = new System.Drawing.Point(233, 38);
            this.buttonLocation.Name = "buttonLocation";
            this.buttonLocation.Size = new System.Drawing.Size(155, 23);
            this.buttonLocation.TabIndex = 2;
            this.buttonLocation.Text = "Standort Suchen";
            this.buttonLocation.UseVisualStyleBackColor = true;
            this.buttonLocation.Click += new System.EventHandler(this.buttonLocation_Click);
            // 
            // webBrowserMaps
            // 
            this.webBrowserMaps.Location = new System.Drawing.Point(16, 65);
            this.webBrowserMaps.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMaps.Name = "webBrowserMaps";
            this.webBrowserMaps.ScriptErrorsSuppressed = true;
            this.webBrowserMaps.Size = new System.Drawing.Size(779, 371);
            this.webBrowserMaps.TabIndex = 3;
            // 
            // radioWeb
            // 
            this.radioWeb.AutoSize = true;
            this.radioWeb.Location = new System.Drawing.Point(413, 41);
            this.radioWeb.Name = "radioWeb";
            this.radioWeb.Size = new System.Drawing.Size(110, 17);
            this.radioWeb.TabIndex = 4;
            this.radioWeb.TabStop = true;
            this.radioWeb.Text = "Im Browser öffnen";
            this.radioWeb.UseVisualStyleBackColor = true;
            // 
            // radioApp
            // 
            this.radioApp.AutoSize = true;
            this.radioApp.Location = new System.Drawing.Point(529, 41);
            this.radioApp.Name = "radioApp";
            this.radioApp.Size = new System.Drawing.Size(107, 17);
            this.radioApp.TabIndex = 5;
            this.radioApp.TabStop = true;
            this.radioApp.Text = "In der App öffnen";
            this.radioApp.UseVisualStyleBackColor = true;
            // 
            // FormMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioApp);
            this.Controls.Add(this.radioWeb);
            this.Controls.Add(this.webBrowserMaps);
            this.Controls.Add(this.buttonLocation);
            this.Controls.Add(this.inputLocation);
            this.Controls.Add(this.labelStation);
            this.Name = "FormMap";
            this.Text = "FormMap";
            this.Load += new System.EventHandler(this.FormMap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStation;
        private System.Windows.Forms.ComboBox inputLocation;
        private System.Windows.Forms.Button buttonLocation;
        private System.Windows.Forms.WebBrowser webBrowserMaps;
        private System.Windows.Forms.RadioButton radioWeb;
        private System.Windows.Forms.RadioButton radioApp;
    }
}