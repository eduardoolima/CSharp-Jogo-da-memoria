namespace ProjetoFinal1B
{
    partial class frmRanking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRanking));
            this.lblNome1 = new System.Windows.Forms.Label();
            this.lblPontos1 = new System.Windows.Forms.Label();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.lblNome3 = new System.Windows.Forms.Label();
            this.lblPontos2 = new System.Windows.Forms.Label();
            this.lblPontos3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome1.Location = new System.Drawing.Point(330, 110);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(198, 31);
            this.lblNome1.TabIndex = 0;
            this.lblNome1.Text = " ********          ";
            this.lblNome1.Click += new System.EventHandler(this.lblNome1_Click);
            // 
            // lblPontos1
            // 
            this.lblPontos1.AutoSize = true;
            this.lblPontos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos1.Location = new System.Drawing.Point(330, 141);
            this.lblPontos1.Name = "lblPontos1";
            this.lblPontos1.Size = new System.Drawing.Size(134, 31);
            this.lblPontos1.TabIndex = 1;
            this.lblPontos1.Text = "------------";
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome2.Location = new System.Drawing.Point(127, 192);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(110, 31);
            this.lblNome2.TabIndex = 2;
            this.lblNome2.Text = "********";
            // 
            // lblNome3
            // 
            this.lblNome3.AutoSize = true;
            this.lblNome3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome3.Location = new System.Drawing.Point(538, 192);
            this.lblNome3.Name = "lblNome3";
            this.lblNome3.Size = new System.Drawing.Size(98, 31);
            this.lblNome3.TabIndex = 3;
            this.lblNome3.Text = "*******";
            // 
            // lblPontos2
            // 
            this.lblPontos2.AutoSize = true;
            this.lblPontos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos2.Location = new System.Drawing.Point(127, 223);
            this.lblPontos2.Name = "lblPontos2";
            this.lblPontos2.Size = new System.Drawing.Size(104, 31);
            this.lblPontos2.TabIndex = 4;
            this.lblPontos2.Text = "---------";
            // 
            // lblPontos3
            // 
            this.lblPontos3.AutoSize = true;
            this.lblPontos3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos3.Location = new System.Drawing.Point(538, 223);
            this.lblPontos3.Name = "lblPontos3";
            this.lblPontos3.Size = new System.Drawing.Size(104, 31);
            this.lblPontos3.TabIndex = 5;
            this.lblPontos3.Text = "---------";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(345, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPontos3);
            this.Controls.Add(this.lblPontos2);
            this.Controls.Add(this.lblNome3);
            this.Controls.Add(this.lblNome2);
            this.Controls.Add(this.lblPontos1);
            this.Controls.Add(this.lblNome1);
            this.Name = "frmRanking";
            this.Text = "Ranking";
            this.Load += new System.EventHandler(this.frmRanking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.Label lblPontos1;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.Label lblNome3;
        private System.Windows.Forms.Label lblPontos2;
        private System.Windows.Forms.Label lblPontos3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}