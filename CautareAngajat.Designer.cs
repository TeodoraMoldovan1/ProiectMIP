namespace ProiectMIP
{
    partial class numarareAngajat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgSelectWhere = new System.Windows.Forms.DataGridView();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCautaNume = new System.Windows.Forms.Button();
            this.btnDepartament = new System.Windows.Forms.Button();
            this.lblPersoana = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.btnIesire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSelectWhere)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSelectWhere
            // 
            this.dgSelectWhere.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgSelectWhere.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgSelectWhere.BackgroundColor = System.Drawing.Color.White;
            this.dgSelectWhere.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSelectWhere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSelectWhere.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgSelectWhere.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgSelectWhere.Location = new System.Drawing.Point(12, 178);
            this.dgSelectWhere.Name = "dgSelectWhere";
            this.dgSelectWhere.ReadOnly = true;
            this.dgSelectWhere.RowHeadersWidth = 51;
            this.dgSelectWhere.RowTemplate.Height = 29;
            this.dgSelectWhere.Size = new System.Drawing.Size(564, 247);
            this.dgSelectWhere.TabIndex = 0;
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNume.Location = new System.Drawing.Point(293, 62);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(164, 34);
            this.txtNume.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Căutare după departament:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Număr angajați din fiecare departament";
            // 
            // btnCautaNume
            // 
            this.btnCautaNume.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCautaNume.Location = new System.Drawing.Point(463, 62);
            this.btnCautaNume.Name = "btnCautaNume";
            this.btnCautaNume.Size = new System.Drawing.Size(101, 34);
            this.btnCautaNume.TabIndex = 5;
            this.btnCautaNume.Text = "Caută";
            this.btnCautaNume.UseVisualStyleBackColor = true;
            this.btnCautaNume.Click += new System.EventHandler(this.btnCautaNume_Click);
            // 
            // btnDepartament
            // 
            this.btnDepartament.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDepartament.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDepartament.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDepartament.Location = new System.Drawing.Point(409, 112);
            this.btnDepartament.Name = "btnDepartament";
            this.btnDepartament.Size = new System.Drawing.Size(90, 38);
            this.btnDepartament.TabIndex = 6;
            this.btnDepartament.UseVisualStyleBackColor = false;
            this.btnDepartament.Click += new System.EventHandler(this.btnDepartament_Click);
            // 
            // lblPersoana
            // 
            this.lblPersoana.AutoSize = true;
            this.lblPersoana.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPersoana.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPersoana.Location = new System.Drawing.Point(149, 9);
            this.lblPersoana.Name = "lblPersoana";
            this.lblPersoana.Size = new System.Drawing.Size(51, 19);
            this.lblPersoana.TabIndex = 22;
            this.lblPersoana.Text = "label3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Angajat conectat";
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.Color.Silver;
            this.btnInapoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInapoi.Location = new System.Drawing.Point(12, 457);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(87, 45);
            this.btnInapoi.TabIndex = 23;
            this.btnInapoi.Text = "Înapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // btnIesire
            // 
            this.btnIesire.BackColor = System.Drawing.Color.Red;
            this.btnIesire.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIesire.ForeColor = System.Drawing.Color.Transparent;
            this.btnIesire.Location = new System.Drawing.Point(477, 457);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(99, 45);
            this.btnIesire.TabIndex = 24;
            this.btnIesire.Text = "Ieșire";
            this.btnIesire.UseVisualStyleBackColor = false;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // numarareAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(598, 514);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.lblPersoana);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDepartament);
            this.Controls.Add(this.btnCautaNume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.dgSelectWhere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "numarareAngajat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CautareAngajat";
            ((System.ComponentModel.ISupportInitialize)(this.dgSelectWhere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgSelectWhere;
        private TextBox txtNume;
        private Label label1;
        private Label label2;
        private Button btnCautaNume;
        private Button btnDepartament;
        private Label lblPersoana;
        private Label label6;
        private Button btnInapoi;
        private Button btnIesire;
    }
}