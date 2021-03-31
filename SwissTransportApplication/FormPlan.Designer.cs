
namespace SwissTransportApplication
{
    partial class FormPlan
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
            this.buttonSearchStation = new System.Windows.Forms.Button();
            this.inputStation = new System.Windows.Forms.ComboBox();
            this.dataStainBoard = new System.Windows.Forms.DataGridView();
            this.labelInfoText = new System.Windows.Forms.Label();
            this.anOrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abOrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.art = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abZeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataStainBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearchStation
            // 
            this.buttonSearchStation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearchStation.Location = new System.Drawing.Point(331, 24);
            this.buttonSearchStation.Name = "buttonSearchStation";
            this.buttonSearchStation.Size = new System.Drawing.Size(92, 23);
            this.buttonSearchStation.TabIndex = 0;
            this.buttonSearchStation.Text = "Suche";
            this.buttonSearchStation.UseVisualStyleBackColor = true;
            this.buttonSearchStation.Click += new System.EventHandler(this.buttonSearchStation_Click);
            // 
            // inputStation
            // 
            this.inputStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.inputStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.inputStation.FormattingEnabled = true;
            this.inputStation.Location = new System.Drawing.Point(13, 26);
            this.inputStation.Name = "inputStation";
            this.inputStation.Size = new System.Drawing.Size(299, 21);
            this.inputStation.TabIndex = 1;
            this.inputStation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputStation_KeyPressed);
            // 
            // dataStainBoard
            // 
            this.dataStainBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataStainBoard.BackgroundColor = System.Drawing.Color.White;
            this.dataStainBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStainBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anOrt,
            this.abOrt,
            this.art,
            this.abZeit});
            this.dataStainBoard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataStainBoard.Location = new System.Drawing.Point(0, 111);
            this.dataStainBoard.Name = "dataStainBoard";
            this.dataStainBoard.ReadOnly = true;
            this.dataStainBoard.Size = new System.Drawing.Size(472, 418);
            this.dataStainBoard.TabIndex = 2;
            // 
            // labelInfoText
            // 
            this.labelInfoText.AutoSize = true;
            this.labelInfoText.Location = new System.Drawing.Point(13, 7);
            this.labelInfoText.Name = "labelInfoText";
            this.labelInfoText.Size = new System.Drawing.Size(127, 13);
            this.labelInfoText.TabIndex = 3;
            this.labelInfoText.Text = "Suche nach einer Station";
            // 
            // anOrt
            // 
            this.anOrt.HeaderText = "Nach";
            this.anOrt.Name = "anOrt";
            this.anOrt.ReadOnly = true;
            // 
            // abOrt
            // 
            this.abOrt.HeaderText = "Von";
            this.abOrt.Name = "abOrt";
            this.abOrt.ReadOnly = true;
            // 
            // art
            // 
            this.art.HeaderText = "Art";
            this.art.Name = "art";
            this.art.ReadOnly = true;
            // 
            // abZeit
            // 
            this.abZeit.HeaderText = "Zeit (ab) ";
            this.abZeit.Name = "abZeit";
            this.abZeit.ReadOnly = true;
            // 
            // FormPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 529);
            this.Controls.Add(this.labelInfoText);
            this.Controls.Add(this.dataStainBoard);
            this.Controls.Add(this.inputStation);
            this.Controls.Add(this.buttonSearchStation);
            this.Name = "FormPlan";
            this.Text = "FormPlan";
            ((System.ComponentModel.ISupportInitialize)(this.dataStainBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearchStation;
        private System.Windows.Forms.ComboBox inputStation;
        private System.Windows.Forms.DataGridView dataStainBoard;
        private System.Windows.Forms.Label labelInfoText;
        private System.Windows.Forms.DataGridViewTextBoxColumn anOrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn abOrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn art;
        private System.Windows.Forms.DataGridViewTextBoxColumn abZeit;
    }
}