
namespace SwissTransportApplication
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonStation = new System.Windows.Forms.Button();
            this.buttonMap = new System.Windows.Forms.Button();
            this.buttonPlan = new System.Windows.Forms.Button();
            this.buttonConnections = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.panelMenu.Controls.Add(this.buttonStation);
            this.panelMenu.Controls.Add(this.buttonMap);
            this.panelMenu.Controls.Add(this.buttonPlan);
            this.panelMenu.Controls.Add(this.buttonConnections);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(270, 692);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonStation
            // 
            this.buttonStation.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStation.FlatAppearance.BorderSize = 0;
            this.buttonStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStation.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonStation.Location = new System.Drawing.Point(0, 260);
            this.buttonStation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStation.Name = "buttonStation";
            this.buttonStation.Size = new System.Drawing.Size(270, 60);
            this.buttonStation.TabIndex = 5;
            this.buttonStation.Text = "Station suchen";
            this.buttonStation.UseVisualStyleBackColor = true;
            this.buttonStation.Click += new System.EventHandler(this.buttonStation_Click);
            // 
            // buttonMap
            // 
            this.buttonMap.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMap.FlatAppearance.BorderSize = 0;
            this.buttonMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMap.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMap.Location = new System.Drawing.Point(0, 200);
            this.buttonMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMap.Name = "buttonMap";
            this.buttonMap.Size = new System.Drawing.Size(270, 60);
            this.buttonMap.TabIndex = 4;
            this.buttonMap.Text = "Karte";
            this.buttonMap.UseVisualStyleBackColor = true;
            this.buttonMap.Click += new System.EventHandler(this.buttonMap_Click);
            // 
            // buttonPlan
            // 
            this.buttonPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPlan.FlatAppearance.BorderSize = 0;
            this.buttonPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlan.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPlan.Location = new System.Drawing.Point(0, 140);
            this.buttonPlan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPlan.Name = "buttonPlan";
            this.buttonPlan.Size = new System.Drawing.Size(270, 60);
            this.buttonPlan.TabIndex = 2;
            this.buttonPlan.Text = "Plan";
            this.buttonPlan.UseVisualStyleBackColor = true;
            this.buttonPlan.Click += new System.EventHandler(this.buttonTable_Click);
            // 
            // buttonConnections
            // 
            this.buttonConnections.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonConnections.FlatAppearance.BorderSize = 0;
            this.buttonConnections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnections.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonConnections.Location = new System.Drawing.Point(0, 80);
            this.buttonConnections.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonConnections.Name = "buttonConnections";
            this.buttonConnections.Size = new System.Drawing.Size(270, 60);
            this.buttonConnections.TabIndex = 1;
            this.buttonConnections.Text = "Verbindungen";
            this.buttonConnections.UseVisualStyleBackColor = true;
            this.buttonConnections.Click += new System.EventHandler(this.buttonConnections_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(270, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(270, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(989, 80);
            this.panelHeader.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(270, 80);
            this.panelMain.MaximumSize = new System.Drawing.Size(989, 612);
            this.panelMain.MinimumSize = new System.Drawing.Size(989, 612);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(989, 612);
            this.panelMain.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(447, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(0, 40);
            this.labelTitle.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1259, 692);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonMap;
        private System.Windows.Forms.Button buttonPlan;
        private System.Windows.Forms.Button buttonConnections;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonStation;
        private System.Windows.Forms.Label labelTitle;
    }
}

