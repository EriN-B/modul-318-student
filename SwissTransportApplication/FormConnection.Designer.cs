
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
            this.inputDeparture = new System.Windows.Forms.TextBox();
            this.inputArrival = new System.Windows.Forms.TextBox();
            this.buttonSearchConnection = new System.Windows.Forms.Button();
            this.dataConnections = new System.Windows.Forms.DataGridView();
            this.Gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abOrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anOrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abZeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anZeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputdate = new System.Windows.Forms.DateTimePicker();
            this.inputTime = new System.Windows.Forms.TextBox();
            this.labelDeparture = new System.Windows.Forms.Label();
            this.labelArrival = new System.Windows.Forms.Label();
            this.listStations = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataConnections)).BeginInit();
            this.SuspendLayout();
            // 
            // inputDeparture
            // 
            this.inputDeparture.Location = new System.Drawing.Point(28, 36);
            this.inputDeparture.Name = "inputDeparture";
            this.inputDeparture.Size = new System.Drawing.Size(122, 20);
            this.inputDeparture.TabIndex = 0;
            this.inputDeparture.Click += new System.EventHandler(this.currentInput_FocusChanged);
            this.inputDeparture.TextChanged += new System.EventHandler(this.inputDeparture_TextChanged);
            // 
            // inputArrival
            // 
            this.inputArrival.Location = new System.Drawing.Point(191, 36);
            this.inputArrival.Name = "inputArrival";
            this.inputArrival.Size = new System.Drawing.Size(140, 20);
            this.inputArrival.TabIndex = 1;
            this.inputArrival.Click += new System.EventHandler(this.currentInput_FocusChanged);
            this.inputArrival.TextChanged += new System.EventHandler(this.inputArrival_TextChanged);
            // 
            // buttonSearchConnection
            // 
            this.buttonSearchConnection.Location = new System.Drawing.Point(362, 36);
            this.buttonSearchConnection.Name = "buttonSearchConnection";
            this.buttonSearchConnection.Size = new System.Drawing.Size(117, 23);
            this.buttonSearchConnection.TabIndex = 2;
            this.buttonSearchConnection.Text = "Verbindung Suchen";
            this.buttonSearchConnection.UseVisualStyleBackColor = true;
            this.buttonSearchConnection.Click += new System.EventHandler(this.buttonSearchConnection_Click);
            // 
            // dataConnections
            // 
            this.dataConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gleis,
            this.abOrt,
            this.anOrt,
            this.abZeit,
            this.anZeit});
            this.dataConnections.Location = new System.Drawing.Point(28, 101);
            this.dataConnections.Name = "dataConnections";
            this.dataConnections.Size = new System.Drawing.Size(550, 322);
            this.dataConnections.TabIndex = 3;
            // 
            // Gleis
            // 
            this.Gleis.HeaderText = "Gleis";
            this.Gleis.Name = "Gleis";
            // 
            // abOrt
            // 
            this.abOrt.HeaderText = "Abfahrtsort";
            this.abOrt.Name = "abOrt";
            // 
            // anOrt
            // 
            this.anOrt.HeaderText = "Ankunftsort";
            this.anOrt.Name = "anOrt";
            // 
            // abZeit
            // 
            this.abZeit.HeaderText = "Zeit (ab)";
            this.abZeit.Name = "abZeit";
            // 
            // anZeit
            // 
            this.anZeit.HeaderText = "Zeit (an)";
            this.anZeit.Name = "anZeit";
            // 
            // inputdate
            // 
            this.inputdate.Location = new System.Drawing.Point(28, 75);
            this.inputdate.Name = "inputdate";
            this.inputdate.Size = new System.Drawing.Size(200, 20);
            this.inputdate.TabIndex = 4;
            // 
            // inputTime
            // 
            this.inputTime.Location = new System.Drawing.Point(257, 75);
            this.inputTime.Name = "inputTime";
            this.inputTime.Size = new System.Drawing.Size(74, 20);
            this.inputTime.TabIndex = 5;
            this.inputTime.Text = "Zeit";
            this.inputTime.Click += new System.EventHandler(this.currentInput_FocusChanged);
            // 
            // labelDeparture
            // 
            this.labelDeparture.AutoSize = true;
            this.labelDeparture.Location = new System.Drawing.Point(28, 17);
            this.labelDeparture.Name = "labelDeparture";
            this.labelDeparture.Size = new System.Drawing.Size(61, 13);
            this.labelDeparture.TabIndex = 6;
            this.labelDeparture.Text = "Abfahrtsort:";
            // 
            // labelArrival
            // 
            this.labelArrival.AutoSize = true;
            this.labelArrival.Location = new System.Drawing.Point(191, 13);
            this.labelArrival.Name = "labelArrival";
            this.labelArrival.Size = new System.Drawing.Size(64, 13);
            this.labelArrival.TabIndex = 7;
            this.labelArrival.Text = "Ankunftsort:";
            // 
            // listStations
            // 
            this.listStations.FormattingEnabled = true;
            this.listStations.Location = new System.Drawing.Point(604, 101);
            this.listStations.Name = "listStations";
            this.listStations.Size = new System.Drawing.Size(157, 316);
            this.listStations.TabIndex = 8;
            this.listStations.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listStation_doubleClick);
            // 
            // FormConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listStations);
            this.Controls.Add(this.labelArrival);
            this.Controls.Add(this.labelDeparture);
            this.Controls.Add(this.inputTime);
            this.Controls.Add(this.inputdate);
            this.Controls.Add(this.dataConnections);
            this.Controls.Add(this.buttonSearchConnection);
            this.Controls.Add(this.inputArrival);
            this.Controls.Add(this.inputDeparture);
            this.Name = "FormConnection";
            this.Text = "FormConnection";
            ((System.ComponentModel.ISupportInitialize)(this.dataConnections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputDeparture;
        private System.Windows.Forms.TextBox inputArrival;
        private System.Windows.Forms.Button buttonSearchConnection;
        private System.Windows.Forms.DataGridView dataConnections;
        private System.Windows.Forms.DateTimePicker inputdate;
        private System.Windows.Forms.TextBox inputTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gleis;
        private System.Windows.Forms.DataGridViewTextBoxColumn abOrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn anOrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn abZeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn anZeit;
        private System.Windows.Forms.Label labelDeparture;
        private System.Windows.Forms.Label labelArrival;
        private System.Windows.Forms.ListBox listStations;
    }
}