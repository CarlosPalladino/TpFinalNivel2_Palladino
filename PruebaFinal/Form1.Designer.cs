namespace PruebaFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMuestra = new System.Windows.Forms.DataGridView();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.Agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMuestra
            // 
            this.dgvMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestra.Location = new System.Drawing.Point(12, 48);
            this.dgvMuestra.Name = "dgvMuestra";
            this.dgvMuestra.Size = new System.Drawing.Size(524, 264);
            this.dgvMuestra.TabIndex = 0;
            this.dgvMuestra.SelectionChanged += new System.EventHandler(this.dgvMuestra_SelectionChanged);
            // 
            // picbox
            // 
            this.picbox.Location = new System.Drawing.Point(558, 48);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(230, 264);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox.TabIndex = 1;
            this.picbox.TabStop = false;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(84, 335);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(103, 31);
            this.Agregar.TabIndex = 2;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.dgvMuestra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMuestra;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Button Agregar;
    }
}

