
namespace SwissTransportApplication
{
    partial class FormConnection
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
            this.buttonSearchConnection = new System.Windows.Forms.Button();
            this.dataConnections = new System.Windows.Forms.DataGridView();
            this.Gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abOrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anOrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abZeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anZeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDeparture = new System.Windows.Forms.Label();
            this.labelArrival = new System.Windows.Forms.Label();
            this.inputDeparture = new System.Windows.Forms.ComboBox();
            this.inputArrival = new System.Windows.Forms.ComboBox();
            this.labelErrorDeparture = new System.Windows.Forms.Label();
            this.labelErrorArrival = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataConnections)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearchConnection
            // 
            this.buttonSearchConnection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearchConnection.Location = new System.Drawing.Point(28, 94);
            this.buttonSearchConnection.Name = "buttonSearchConnection";
            this.buttonSearchConnection.Size = new System.Drawing.Size(514, 23);
            this.buttonSearchConnection.TabIndex = 5;
            this.buttonSearchConnection.Text = "Verbindung Suchen";
            this.buttonSearchConnection.UseVisualStyleBackColor = true;
            this.buttonSearchConnection.Click += new System.EventHandler(this.buttonSearchConnection_Click);
            // 
            // dataConnections
            // 
            this.dataConnections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataConnections.BackgroundColor = System.Drawing.Color.White;
            this.dataConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gleis,
            this.abOrt,
            this.anOrt,
            this.abZeit,
            this.anZeit});
            this.dataConnections.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataConnections.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataConnections.Location = new System.Drawing.Point(0, 236);
            this.dataConnections.Name = "dataConnections";
            this.dataConnections.ReadOnly = true;
            this.dataConnections.Size = new System.Drawing.Size(833, 311);
            this.dataConnections.TabIndex = 200;
            this.dataConnections.Visible = false;
            // 
            // Gleis
            // 
            this.Gleis.HeaderText = "Gleis";
            this.Gleis.Name = "Gleis";
            this.Gleis.ReadOnly = true;
            // 
            // abOrt
            // 
            this.abOrt.HeaderText = "nach";
            this.abOrt.Name = "abOrt";
            this.abOrt.ReadOnly = true;
            // 
            // anOrt
            // 
            this.anOrt.HeaderText = "Nach";
            this.anOrt.Name = "anOrt";
            this.anOrt.ReadOnly = true;
            // 
            // abZeit
            // 
            this.abZeit.HeaderText = "Zeit (ab)";
            this.abZeit.Name = "abZeit";
            this.abZeit.ReadOnly = true;
            // 
            // anZeit
            // 
            this.anZeit.HeaderText = "Zeit (an)";
            this.anZeit.Name = "anZeit";
            this.anZeit.ReadOnly = true;
            // 
            // labelDeparture
            // 
            this.labelDeparture.AutoSize = true;
            this.labelDeparture.Location = new System.Drawing.Point(28, 33);
            this.labelDeparture.Name = "labelDeparture";
            this.labelDeparture.Size = new System.Drawing.Size(61, 13);
            this.labelDeparture.TabIndex = 6;
            this.labelDeparture.Text = "Abfahrtsort:";
            // 
            // labelArrival
            // 
            this.labelArrival.AutoSize = true;
            this.labelArrival.Location = new System.Drawing.Point(298, 33);
            this.labelArrival.Name = "labelArrival";
            this.labelArrival.Size = new System.Drawing.Size(64, 13);
            this.labelArrival.TabIndex = 7;
            this.labelArrival.Text = "Ankunftsort:";
            // 
            // inputDeparture
            // 
            this.inputDeparture.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.inputDeparture.FormattingEnabled = true;
            this.inputDeparture.Location = new System.Drawing.Point(28, 50);
            this.inputDeparture.Name = "inputDeparture";
            this.inputDeparture.Size = new System.Drawing.Size(231, 21);
            this.inputDeparture.TabIndex = 1;
            this.inputDeparture.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputDeparture_KeyPressed);
            // 
            // inputArrival
            // 
            this.inputArrival.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.inputArrival.FormattingEnabled = true;
            this.inputArrival.Location = new System.Drawing.Point(301, 50);
            this.inputArrival.Name = "inputArrival";
            this.inputArrival.Size = new System.Drawing.Size(241, 21);
            this.inputArrival.TabIndex = 2;
            this.inputArrival.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputArrival_KeyPressed);
            // 
            // labelErrorDeparture
            // 
            this.labelErrorDeparture.AutoSize = true;
            this.labelErrorDeparture.ForeColor = System.Drawing.Color.Red;
            this.labelErrorDeparture.Location = new System.Drawing.Point(28, 78);
            this.labelErrorDeparture.Name = "labelErrorDeparture";
            this.labelErrorDeparture.Size = new System.Drawing.Size(0, 13);
            this.labelErrorDeparture.TabIndex = 12;
            this.labelErrorDeparture.Visible = false;
            // 
            // labelErrorArrival
            // 
            this.labelErrorArrival.AutoSize = true;
            this.labelErrorArrival.ForeColor = System.Drawing.Color.Red;
            this.labelErrorArrival.Location = new System.Drawing.Point(301, 78);
            this.labelErrorArrival.Name = "labelErrorArrival";
            this.labelErrorArrival.Size = new System.Drawing.Size(0, 13);
            this.labelErrorArrival.TabIndex = 13;
            this.labelErrorArrival.Visible = false;
            // 
            // FormConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 547);
            this.Controls.Add(this.labelErrorArrival);
            this.Controls.Add(this.labelErrorDeparture);
            this.Controls.Add(this.inputArrival);
            this.Controls.Add(this.inputDeparture);
            this.Controls.Add(this.labelArrival);
            this.Controls.Add(this.labelDeparture);
            this.Controls.Add(this.dataConnections);
            this.Controls.Add(this.buttonSearchConnection);
            this.Name = "FormConnection";
            this.Text = "FormConnection";
            ((System.ComponentModel.ISupportInitialize)(this.dataConnections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSearchConnection;
        private System.Windows.Forms.DataGridView dataConnections;
        private System.Windows.Forms.Label labelDeparture;
        private System.Windows.Forms.Label labelArrival;
        private System.Windows.Forms.ComboBox inputDeparture;
        private System.Windows.Forms.ComboBox inputArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gleis;
        private System.Windows.Forms.DataGridViewTextBoxColumn abOrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn anOrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn abZeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn anZeit;
        private System.Windows.Forms.Label labelErrorDeparture;
        private System.Windows.Forms.Label labelErrorArrival;
    }
}