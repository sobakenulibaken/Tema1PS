namespace Forms
{
    partial class UserForm
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
            this.AdaugaBiletButon = new System.Windows.Forms.Button();
            this.dataGridViewSpectacole = new System.Windows.Forms.DataGridView();
            this.IDbox = new System.Windows.Forms.TextBox();
            this.randBox = new System.Windows.Forms.TextBox();
            this.nrLocBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VizualizareSpecButon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpectacole)).BeginInit();
            this.SuspendLayout();
            // 
            // AdaugaBiletButon
            // 
            this.AdaugaBiletButon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AdaugaBiletButon.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdaugaBiletButon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AdaugaBiletButon.Location = new System.Drawing.Point(36, 356);
            this.AdaugaBiletButon.Name = "AdaugaBiletButon";
            this.AdaugaBiletButon.Size = new System.Drawing.Size(149, 37);
            this.AdaugaBiletButon.TabIndex = 0;
            this.AdaugaBiletButon.Text = "Adauga Bilet";
            this.AdaugaBiletButon.UseVisualStyleBackColor = false;
            this.AdaugaBiletButon.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewSpectacole
            // 
            this.dataGridViewSpectacole.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewSpectacole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpectacole.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridViewSpectacole.Location = new System.Drawing.Point(238, 12);
            this.dataGridViewSpectacole.Name = "dataGridViewSpectacole";
            this.dataGridViewSpectacole.Size = new System.Drawing.Size(541, 437);
            this.dataGridViewSpectacole.TabIndex = 1;
            // 
            // IDbox
            // 
            this.IDbox.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDbox.Location = new System.Drawing.Point(27, 69);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(169, 31);
            this.IDbox.TabIndex = 2;
            // 
            // randBox
            // 
            this.randBox.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randBox.Location = new System.Drawing.Point(27, 154);
            this.randBox.Name = "randBox";
            this.randBox.Size = new System.Drawing.Size(169, 31);
            this.randBox.TabIndex = 3;
            // 
            // nrLocBox
            // 
            this.nrLocBox.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrLocBox.Location = new System.Drawing.Point(27, 233);
            this.nrLocBox.Name = "nrLocBox";
            this.nrLocBox.Size = new System.Drawing.Size(169, 31);
            this.nrLocBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Spectacol:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rand:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loc:";
            // 
            // VizualizareSpecButon
            // 
            this.VizualizareSpecButon.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VizualizareSpecButon.Location = new System.Drawing.Point(518, 455);
            this.VizualizareSpecButon.Name = "VizualizareSpecButon";
            this.VizualizareSpecButon.Size = new System.Drawing.Size(240, 37);
            this.VizualizareSpecButon.TabIndex = 8;
            this.VizualizareSpecButon.Text = "Vizualizare Spectacole";
            this.VizualizareSpecButon.UseVisualStyleBackColor = true;
            this.VizualizareSpecButon.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(799, 504);
            this.Controls.Add(this.VizualizareSpecButon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nrLocBox);
            this.Controls.Add(this.randBox);
            this.Controls.Add(this.IDbox);
            this.Controls.Add(this.dataGridViewSpectacole);
            this.Controls.Add(this.AdaugaBiletButon);
            this.Name = "UserForm";
            this.Text = "User";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpectacole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdaugaBiletButon;
        private System.Windows.Forms.DataGridView dataGridViewSpectacole;
        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.TextBox randBox;
        private System.Windows.Forms.TextBox nrLocBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button VizualizareSpecButon;
    }
}