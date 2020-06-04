namespace RiotCocAPITest
{
    partial class Form1
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
            this.btnGetData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSummonerName = new System.Windows.Forms.TextBox();
            this.dgvChampions = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChampions)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetData
            // 
            this.btnGetData.Enabled = false;
            this.btnGetData.Location = new System.Drawing.Point(334, 22);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(134, 23);
            this.btnGetData.TabIndex = 0;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Summoner\'s name";
            // 
            // txtSummonerName
            // 
            this.txtSummonerName.Location = new System.Drawing.Point(118, 23);
            this.txtSummonerName.Name = "txtSummonerName";
            this.txtSummonerName.Size = new System.Drawing.Size(204, 20);
            this.txtSummonerName.TabIndex = 2;
            this.txtSummonerName.TextChanged += new System.EventHandler(this.txtSummonerName_TextChanged);
            // 
            // dgvChampions
            // 
            this.dgvChampions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChampions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.name,
            this.points,
            this.level});
            this.dgvChampions.Location = new System.Drawing.Point(21, 52);
            this.dgvChampions.Name = "dgvChampions";
            this.dgvChampions.Size = new System.Drawing.Size(447, 323);
            this.dgvChampions.TabIndex = 3;
            // 
            // number
            // 
            this.number.HeaderText = "No.,";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // points
            // 
            this.points.HeaderText = "Points";
            this.points.Name = "points";
            this.points.ReadOnly = true;
            // 
            // level
            // 
            this.level.HeaderText = "Level";
            this.level.Name = "level";
            this.level.ReadOnly = true;
            this.level.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 396);
            this.Controls.Add(this.dgvChampions);
            this.Controls.Add(this.txtSummonerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetData);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Riot API";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChampions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSummonerName;
        private System.Windows.Forms.DataGridView dgvChampions;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn points;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
    }
}

