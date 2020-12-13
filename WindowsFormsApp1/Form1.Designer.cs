
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tx = new System.Windows.Forms.TextBox();
            this.ty = new System.Windows.Forms.TextBox();
            this.rs = new System.Windows.Forms.TextBox();
            this.bplus = new System.Windows.Forms.Button();
            this.bsous = new System.Windows.Forms.Button();
            this.bmult = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tx
            // 
            this.tx.Location = new System.Drawing.Point(122, 61);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(243, 20);
            this.tx.TabIndex = 0;
            // 
            // ty
            // 
            this.ty.Location = new System.Drawing.Point(122, 108);
            this.ty.Name = "ty";
            this.ty.Size = new System.Drawing.Size(243, 20);
            this.ty.TabIndex = 1;
            // 
            // rs
            // 
            this.rs.Location = new System.Drawing.Point(122, 156);
            this.rs.Name = "rs";
            this.rs.Size = new System.Drawing.Size(243, 20);
            this.rs.TabIndex = 2;
            // 
            // bplus
            // 
            this.bplus.Location = new System.Drawing.Point(61, 207);
            this.bplus.Name = "bplus";
            this.bplus.Size = new System.Drawing.Size(75, 23);
            this.bplus.TabIndex = 3;
            this.bplus.Text = "+";
            this.bplus.UseVisualStyleBackColor = true;
            this.bplus.Click += new System.EventHandler(this.bplus_Click);
            // 
            // bsous
            // 
            this.bsous.Location = new System.Drawing.Point(142, 207);
            this.bsous.Name = "bsous";
            this.bsous.Size = new System.Drawing.Size(75, 23);
            this.bsous.TabIndex = 4;
            this.bsous.Text = "-";
            this.bsous.UseVisualStyleBackColor = true;
            this.bsous.Click += new System.EventHandler(this.bsous_Click);
            // 
            // bmult
            // 
            this.bmult.Location = new System.Drawing.Point(223, 207);
            this.bmult.Name = "bmult";
            this.bmult.Size = new System.Drawing.Size(75, 23);
            this.bmult.TabIndex = 5;
            this.bmult.Text = "*";
            this.bmult.UseVisualStyleBackColor = true;
            this.bmult.Click += new System.EventHandler(this.bmult_Click);
            // 
            // bdiv
            // 
            this.bdiv.Location = new System.Drawing.Point(304, 207);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(75, 23);
            this.bdiv.TabIndex = 6;
            this.bdiv.Text = "/";
            this.bdiv.UseVisualStyleBackColor = true;
            this.bdiv.Click += new System.EventHandler(this.bdiv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Resultat";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(440, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.bmult);
            this.Controls.Add(this.bsous);
            this.Controls.Add(this.bplus);
            this.Controls.Add(this.rs);
            this.Controls.Add(this.ty);
            this.Controls.Add(this.tx);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Btplus;
        private System.Windows.Forms.Button Btsous;
        private System.Windows.Forms.Button Btdiv;
        private System.Windows.Forms.Button Btmult;
        private System.Windows.Forms.Label Txtx;
        private System.Windows.Forms.Label Txty;
        private System.Windows.Forms.Label Txtz;
        private System.Windows.Forms.TextBox tx;
        private System.Windows.Forms.TextBox ty;
        private System.Windows.Forms.TextBox rs;
        private System.Windows.Forms.Button bplus;
        private System.Windows.Forms.Button bsous;
        private System.Windows.Forms.Button bmult;
        private System.Windows.Forms.Button bdiv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

