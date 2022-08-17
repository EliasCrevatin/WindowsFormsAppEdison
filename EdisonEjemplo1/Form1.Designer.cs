namespace EdisonEjemplo1
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
            this.DgvImpulsores = new System.Windows.Forms.DataGridView();
            this.PboxImpulsores = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvImpulsores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PboxImpulsores)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvImpulsores
            // 
            this.DgvImpulsores.AccessibleName = "DgvImpulsores";
            this.DgvImpulsores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvImpulsores.Location = new System.Drawing.Point(12, 40);
            this.DgvImpulsores.Name = "DgvImpulsores";
            this.DgvImpulsores.Size = new System.Drawing.Size(867, 238);
            this.DgvImpulsores.TabIndex = 0;
            this.DgvImpulsores.SelectionChanged += new System.EventHandler(this.DgvImpulsores_SelectionChanged);
            // 
            // PboxImpulsores
            // 
            this.PboxImpulsores.AccessibleName = "PboxImpulsores";
            this.PboxImpulsores.Location = new System.Drawing.Point(904, 40);
            this.PboxImpulsores.Name = "PboxImpulsores";
            this.PboxImpulsores.Size = new System.Drawing.Size(268, 238);
            this.PboxImpulsores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PboxImpulsores.TabIndex = 1;
            this.PboxImpulsores.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 294);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 340);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.PboxImpulsores);
            this.Controls.Add(this.DgvImpulsores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvImpulsores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PboxImpulsores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvImpulsores;
        private System.Windows.Forms.PictureBox PboxImpulsores;
        private System.Windows.Forms.Button btnAgregar;
    }
}

