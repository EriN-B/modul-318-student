
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
            this.components = new System.ComponentModel.Container();
            this.buttonSearchConnection = new System.Windows.Forms.Button();
            this.dataConnections = new System.Windows.Forms.DataGridView();
            this.platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDeparture = new System.Windows.Forms.Label();
            this.labelArrival = new System.Windows.Forms.Label();
            this.inputDeparture = new System.Windows.Forms.ComboBox();
            this.inputArrival = new System.Windows.Forms.ComboBox();
            this.labelErrorDeparture = new System.Windows.Forms.Label();
            this.labelErrorArrival = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.formConnectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataConnections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formConnectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearchConnection
            // 
            this.buttonSearchConnection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearchConnection.Location = new System.Drawing.Point(334, 91);
            this.buttonSearchConnection.Name = "buttonSearchConnection";
            this.buttonSearchConnection.Size = new System.Drawing.Size(241, 23);
            this.buttonSearchConnection.TabIndex = 4;
            this.buttonSearchConnection.Text = "Verbindung Suchen";
            this.buttonSearchConnection.UseVisualStyleBackColor = true;
            this.buttonSearchConnection.Click += new System.EventHandler(this.buttonSearchConnection_Click);
            // 
            // dataConnections
            // 
            this.dataConnections.AllowUserToAddRows = false;
            this.dataConnections.AllowUserToDeleteRows = false;
            this.dataConnections.AllowUserToResizeRows = false;
            this.dataConnections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataConnections.BackgroundColor = System.Drawing.Color.White;
            this.dataConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.platform,
            this.fromPlace,
            this.toPlace,
            this.fromTime,
            this.ToTime});
            this.dataConnections.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataConnections.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataConnections.Location = new System.Drawing.Point(0, 237);
            this.dataConnections.Name = "dataConnections";
            this.dataConnections.ReadOnly = true;
            this.dataConnections.Size = new System.Drawing.Size(924, 310);
            this.dataConnections.TabIndex = 200;
            this.dataConnections.Visible = false;
            this.dataConnections.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataConnections_CellContentClick);
            // 
            // platform
            // 
            this.platform.DataPropertyName = "platform";
            this.platform.HeaderText = "Gleis";
            this.platform.Name = "platform";
            this.platform.ReadOnly = true;
            // 
            // fromPlace
            // 
            this.fromPlace.DataPropertyName = "fromPlace";
            this.fromPlace.HeaderText = "Von";
            this.fromPlace.Name = "fromPlace";
            this.fromPlace.ReadOnly = true;
            // 
            // toPlace
            // 
            this.toPlace.DataPropertyName = "toPlace";
            this.toPlace.HeaderText = "Nach";
            this.toPlace.Name = "toPlace";
            this.toPlace.ReadOnly = true;
            // 
            // fromTime
            // 
            this.fromTime.DataPropertyName = "fromTime";
            this.fromTime.HeaderText = "Zeit (ab)";
            this.fromTime.Name = "fromTime";
            this.fromTime.ReadOnly = true;
            // 
            // ToTime
            // 
            this.ToTime.DataPropertyName = "ToTime";
            this.ToTime.HeaderText = "Zeit (an)";
            this.ToTime.Name = "ToTime";
            this.ToTime.ReadOnly = true;
            // 
            // labelDeparture
            // 
            this.labelDeparture.AutoSize = true;
            this.labelDeparture.Location = new System.Drawing.Point(41, 33);
            this.labelDeparture.Name = "labelDeparture";
            this.labelDeparture.Size = new System.Drawing.Size(61, 13);
            this.labelDeparture.TabIndex = 6;
            this.labelDeparture.Text = "Abfahrtsort:";
            // 
            // labelArrival
            // 
            this.labelArrival.AutoSize = true;
            this.labelArrival.Location = new System.Drawing.Point(331, 33);
            this.labelArrival.Name = "labelArrival";
            this.labelArrival.Size = new System.Drawing.Size(64, 13);
            this.labelArrival.TabIndex = 7;
            this.labelArrival.Text = "Ankunftsort:";
            // 
            // inputDeparture
            // 
            this.inputDeparture.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.inputDeparture.FormattingEnabled = true;
            this.inputDeparture.Location = new System.Drawing.Point(44, 50);
            this.inputDeparture.Name = "inputDeparture";
            this.inputDeparture.Size = new System.Drawing.Size(231, 21);
            this.inputDeparture.TabIndex = 1;
            this.inputDeparture.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputDeparture_KeyPressed);
            // 
            // inputArrival
            // 
            this.inputArrival.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.inputArrival.FormattingEnabled = true;
            this.inputArrival.Location = new System.Drawing.Point(334, 50);
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
            // inputEmail
            // 
            this.inputEmail.Location = new System.Drawing.Point(44, 94);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(231, 20);
            this.inputEmail.TabIndex = 3;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(41, 78);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(71, 13);
            this.labelEmail.TabIndex = 202;
            this.labelEmail.Text = "E-Mail Adress";
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.Location = new System.Drawing.Point(281, 50);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(47, 21);
            this.buttonSwitch.TabIndex = 203;
            this.buttonSwitch.Text = "<-->";
            this.buttonSwitch.UseVisualStyleBackColor = true;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
            // 
            // formConnectionBindingSource
            // 
            this.formConnectionBindingSource.DataSource = typeof(SwissTransportApplication.FormConnection);
            // 
            // FormConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 547);
            this.Controls.Add(this.buttonSwitch);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.inputEmail);
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
            ((System.ComponentModel.ISupportInitialize)(this.formConnectionBindingSource)).EndInit();
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
        private System.Windows.Forms.Label labelErrorDeparture;
        private System.Windows.Forms.Label labelErrorArrival;
        private System.Windows.Forms.BindingSource formConnectionBindingSource;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn platform;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn toPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToTime;
        private System.Windows.Forms.Button buttonSwitch;
    }
}