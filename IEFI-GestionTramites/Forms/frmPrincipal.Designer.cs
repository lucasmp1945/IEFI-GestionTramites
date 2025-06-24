namespace IEFI_GestionTramites
{
    partial class frmPrincipal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAbrirJornada = new System.Windows.Forms.Button();
            this.btnCerrarJornada = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(603, 423);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(595, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trámites generales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(595, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Urgencias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(595, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Historial";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAbrirJornada
            // 
            this.btnAbrirJornada.Location = new System.Drawing.Point(16, 450);
            this.btnAbrirJornada.Name = "btnAbrirJornada";
            this.btnAbrirJornada.Size = new System.Drawing.Size(122, 23);
            this.btnAbrirJornada.TabIndex = 1;
            this.btnAbrirJornada.Text = "Abrir Jornada";
            this.btnAbrirJornada.UseVisualStyleBackColor = true;
            this.btnAbrirJornada.Click += new System.EventHandler(this.btnAbrirJornada_Click);
            // 
            // btnCerrarJornada
            // 
            this.btnCerrarJornada.Location = new System.Drawing.Point(489, 450);
            this.btnCerrarJornada.Name = "btnCerrarJornada";
            this.btnCerrarJornada.Size = new System.Drawing.Size(122, 23);
            this.btnCerrarJornada.TabIndex = 2;
            this.btnCerrarJornada.Text = "Cerrar Jornada";
            this.btnCerrarJornada.UseVisualStyleBackColor = true;
            this.btnCerrarJornada.Click += new System.EventHandler(this.btnCerrarJornada_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 489);
            this.Controls.Add(this.btnCerrarJornada);
            this.Controls.Add(this.btnAbrirJornada);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Gestión de Trámites";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAbrirJornada;
        private System.Windows.Forms.Button btnCerrarJornada;
    }
}

