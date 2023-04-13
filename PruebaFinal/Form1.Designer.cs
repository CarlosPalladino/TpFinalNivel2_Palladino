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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMuestra = new System.Windows.Forms.DataGridView();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Filltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.Filtrar = new System.Windows.Forms.Button();
            this.Campo = new System.Windows.Forms.Label();
            this.Filtro = new System.Windows.Forms.Label();
            this.Criterio = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMuestra
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMuestra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMuestra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMuestra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestra.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMuestra.Location = new System.Drawing.Point(114, 42);
            this.dgvMuestra.MultiSelect = false;
            this.dgvMuestra.Name = "dgvMuestra";
            this.dgvMuestra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMuestra.Size = new System.Drawing.Size(647, 264);
            this.dgvMuestra.TabIndex = 0;
            this.dgvMuestra.SelectionChanged += new System.EventHandler(this.dgvMuestra_SelectionChanged);
            // 
            // picbox
            // 
            this.picbox.Location = new System.Drawing.Point(346, 330);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(234, 198);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox.TabIndex = 1;
            this.picbox.TabStop = false;
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar.Location = new System.Drawing.Point(771, 414);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(103, 31);
            this.Agregar.TabIndex = 2;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Modificar
            // 
            this.Modificar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar.Location = new System.Drawing.Point(771, 498);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(103, 30);
            this.Modificar.TabIndex = 3;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = false;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Location = new System.Drawing.Point(771, 330);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(103, 32);
            this.Eliminar.TabIndex = 4;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Filltro
            // 
            this.Filltro.AutoSize = true;
            this.Filltro.Location = new System.Drawing.Point(281, 19);
            this.Filltro.Name = "Filltro";
            this.Filltro.Size = new System.Drawing.Size(31, 13);
            this.Filltro.TabIndex = 5;
            this.Filltro.Text = "Filltro";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(356, 16);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(194, 20);
            this.txtFiltro.TabIndex = 6;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // Filtrar
            // 
            this.Filtrar.Location = new System.Drawing.Point(91, 496);
            this.Filtrar.Name = "Filtrar";
            this.Filtrar.Size = new System.Drawing.Size(64, 32);
            this.Filtrar.TabIndex = 7;
            this.Filtrar.Text = "Buscar";
            this.Filtrar.UseVisualStyleBackColor = true;
            this.Filtrar.Click += new System.EventHandler(this.Filtrar_Click);
            // 
            // Campo
            // 
            this.Campo.AutoSize = true;
            this.Campo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campo.Location = new System.Drawing.Point(156, 340);
            this.Campo.Name = "Campo";
            this.Campo.Size = new System.Drawing.Size(45, 13);
            this.Campo.TabIndex = 8;
            this.Campo.Text = "Campo";
            // 
            // Filtro
            // 
            this.Filtro.AutoSize = true;
            this.Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtro.Location = new System.Drawing.Point(156, 452);
            this.Filtro.Name = "Filtro";
            this.Filtro.Size = new System.Drawing.Size(35, 13);
            this.Filtro.TabIndex = 9;
            this.Filtro.Text = "Filtro";
            // 
            // Criterio
            // 
            this.Criterio.AutoSize = true;
            this.Criterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Criterio.Location = new System.Drawing.Point(156, 396);
            this.Criterio.Name = "Criterio";
            this.Criterio.Size = new System.Drawing.Size(47, 13);
            this.Criterio.TabIndex = 10;
            this.Criterio.Text = "Criterio";
            // 
            // cboCampo
            // 
            this.cboCampo.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.cboCampo.BackColor = System.Drawing.SystemColors.Window;
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(12, 330);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 11;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(12, 388);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio.TabIndex = 12;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Location = new System.Drawing.Point(12, 445);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 13;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(12, 496);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(64, 32);
            this.Reset.TabIndex = 15;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 547);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.Criterio);
            this.Controls.Add(this.Filtro);
            this.Controls.Add(this.Campo);
            this.Controls.Add(this.Filtrar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.Filltro);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.dgvMuestra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMuestra;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Label Filltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button Filtrar;
        private System.Windows.Forms.Label Campo;
        private System.Windows.Forms.Label Filtro;
        private System.Windows.Forms.Label Criterio;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button Reset;
    }
}

