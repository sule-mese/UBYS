﻿namespace WindowsFormsApplication1
{
    partial class frm_Ogr_Ders_Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ogr_Ders_Index));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Ara = new System.Windows.Forms.Button();
            this.btn_Ogr_Ders_Ekle = new System.Windows.Forms.Button();
            this.btn_Ogr_Ders_Güncelle = new System.Windows.Forms.Button();
            this.btn_Ogr_Ders_Sil = new System.Windows.Forms.Button();
            this.btn_raporla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1254, 577);
            this.dataGridView1.TabIndex = 73;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "Öğrenci No - Ad Soyad - Ders No - Ders Adı";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(15, 19);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 25);
            this.textBox1.TabIndex = 1;
            // 
            // btn_Ara
            // 
            this.btn_Ara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Ara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ara.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ara.Location = new System.Drawing.Point(345, 11);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(152, 33);
            this.btn_Ara.TabIndex = 2;
            this.btn_Ara.Text = "Ara";
            this.btn_Ara.UseVisualStyleBackColor = false;
            this.btn_Ara.Click += new System.EventHandler(this.btn_Ara_Click_1);
            // 
            // btn_Ogr_Ders_Ekle
            // 
            this.btn_Ogr_Ders_Ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Ogr_Ders_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ogr_Ders_Ekle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ogr_Ders_Ekle.Location = new System.Drawing.Point(3, 637);
            this.btn_Ogr_Ders_Ekle.Name = "btn_Ogr_Ders_Ekle";
            this.btn_Ogr_Ders_Ekle.Size = new System.Drawing.Size(133, 37);
            this.btn_Ogr_Ders_Ekle.TabIndex = 3;
            this.btn_Ogr_Ders_Ekle.Text = "Ders Ekle";
            this.btn_Ogr_Ders_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ogr_Ders_Ekle.Click += new System.EventHandler(this.btn_Ogr_Ders_Ekle_Click);
            // 
            // btn_Ogr_Ders_Güncelle
            // 
            this.btn_Ogr_Ders_Güncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Ogr_Ders_Güncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ogr_Ders_Güncelle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ogr_Ders_Güncelle.Location = new System.Drawing.Point(142, 637);
            this.btn_Ogr_Ders_Güncelle.Name = "btn_Ogr_Ders_Güncelle";
            this.btn_Ogr_Ders_Güncelle.Size = new System.Drawing.Size(133, 37);
            this.btn_Ogr_Ders_Güncelle.TabIndex = 4;
            this.btn_Ogr_Ders_Güncelle.Text = "Güncelle";
            this.btn_Ogr_Ders_Güncelle.UseVisualStyleBackColor = false;
            this.btn_Ogr_Ders_Güncelle.Click += new System.EventHandler(this.btn_Ogr_Ders_Güncelle_Click);
            // 
            // btn_Ogr_Ders_Sil
            // 
            this.btn_Ogr_Ders_Sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Ogr_Ders_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ogr_Ders_Sil.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ogr_Ders_Sil.Location = new System.Drawing.Point(281, 637);
            this.btn_Ogr_Ders_Sil.Name = "btn_Ogr_Ders_Sil";
            this.btn_Ogr_Ders_Sil.Size = new System.Drawing.Size(133, 37);
            this.btn_Ogr_Ders_Sil.TabIndex = 5;
            this.btn_Ogr_Ders_Sil.Text = "Sil";
            this.btn_Ogr_Ders_Sil.UseVisualStyleBackColor = false;
            this.btn_Ogr_Ders_Sil.Click += new System.EventHandler(this.btn_Ogr_Ders_Sil_Click);
            // 
            // btn_raporla
            // 
            this.btn_raporla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_raporla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_raporla.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_raporla.Location = new System.Drawing.Point(1124, 637);
            this.btn_raporla.Name = "btn_raporla";
            this.btn_raporla.Size = new System.Drawing.Size(133, 37);
            this.btn_raporla.TabIndex = 74;
            this.btn_raporla.Text = "Raporla";
            this.btn_raporla.UseVisualStyleBackColor = false;
            this.btn_raporla.Click += new System.EventHandler(this.btn_raporla_Click);
            // 
            // frm_Ogr_Ders_Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1260, 677);
            this.Controls.Add(this.btn_raporla);
            this.Controls.Add(this.btn_Ogr_Ders_Sil);
            this.Controls.Add(this.btn_Ogr_Ders_Güncelle);
            this.Controls.Add(this.btn_Ogr_Ders_Ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Ara);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Ogr_Ders_Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Ders İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Ogr_Ders_Index_FormClosed);
            this.Load += new System.EventHandler(this.frm_Ogr_Ders_Index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Ara;
        private System.Windows.Forms.Button btn_Ogr_Ders_Ekle;
        private System.Windows.Forms.Button btn_Ogr_Ders_Güncelle;
        private System.Windows.Forms.Button btn_Ogr_Ders_Sil;
        private System.Windows.Forms.Button btn_raporla;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}