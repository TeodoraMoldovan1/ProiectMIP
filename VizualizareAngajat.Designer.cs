namespace ProiectMIP
{
    partial class VizualizareAngajat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vizualizareDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vizualizareDateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgSelectAll = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Iesire = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.lbPersoana = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vizualizareDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizualizareDateBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSelectAll)).BeginInit();
            this.SuspendLayout();
            // 
            // vizualizareDateBindingSource
            // 
            this.vizualizareDateBindingSource.DataSource = typeof(ProiectMIP.VizualizareDate);
            // 
            // vizualizareDateBindingSource1
            // 
            this.vizualizareDateBindingSource1.DataSource = typeof(ProiectMIP.VizualizareDate);
            // 
            // dgSelectAll
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.NullValue = null;
            this.dgSelectAll.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSelectAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgSelectAll.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgSelectAll.BackgroundColor = System.Drawing.Color.White;
            this.dgSelectAll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSelectAll.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgSelectAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSelectAll.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgSelectAll.Location = new System.Drawing.Point(36, 97);
            this.dgSelectAll.Name = "dgSelectAll";
            this.dgSelectAll.ReadOnly = true;
            this.dgSelectAll.RowHeadersWidth = 51;
            this.dgSelectAll.RowTemplate.Height = 29;
            this.dgSelectAll.Size = new System.Drawing.Size(747, 409);
            this.dgSelectAll.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(36, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Angajații din această firmă:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Iesire
            // 
            this.Iesire.BackColor = System.Drawing.Color.Red;
            this.Iesire.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Iesire.ForeColor = System.Drawing.Color.Transparent;
            this.Iesire.Location = new System.Drawing.Point(633, 530);
            this.Iesire.Name = "Iesire";
            this.Iesire.Size = new System.Drawing.Size(150, 47);
            this.Iesire.TabIndex = 12;
            this.Iesire.Text = "Ieșire";
            this.Iesire.UseVisualStyleBackColor = false;
            this.Iesire.Click += new System.EventHandler(this.Iesire_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInapoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInapoi.Location = new System.Drawing.Point(36, 530);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(150, 47);
            this.btnInapoi.TabIndex = 11;
            this.btnInapoi.Text = "Înapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // lbPersoana
            // 
            this.lbPersoana.AutoSize = true;
            this.lbPersoana.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPersoana.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbPersoana.Location = new System.Drawing.Point(149, 9);
            this.lbPersoana.Name = "lbPersoana";
            this.lbPersoana.Size = new System.Drawing.Size(51, 19);
            this.lbPersoana.TabIndex = 20;
            this.lbPersoana.Text = "label3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Angajat conectat";
            // 
            // VizualizareAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(822, 589);
            this.Controls.Add(this.lbPersoana);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Iesire);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgSelectAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VizualizareAngajat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vizualizare angajati";
            ((System.ComponentModel.ISupportInitialize)(this.vizualizareDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizualizareDateBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSelectAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource vizualizareDateBindingSource;
        private BindingSource vizualizareDateBindingSource1;
        public DataGridView dgSelectAll;
        private Label label1;
        private Button Iesire;
        private Button btnInapoi;
        private Label lbPersoana;
        private Label label6;
    }
}