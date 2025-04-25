namespace pryRepasoLaboratorio1y2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblPosicion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.chkComida1 = new System.Windows.Forms.CheckBox();
            this.chkComida2 = new System.Windows.Forms.CheckBox();
            this.chkComida3 = new System.Windows.Forms.CheckBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.cboPagos = new System.Windows.Forms.ComboBox();
            this.lblLista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.Location = new System.Drawing.Point(12, 9);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(23, 31);
            this.lblPosicion.TabIndex = 0;
            this.lblPosicion.Text = "-";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(204, 481);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(292, 65);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(496, 481);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(292, 65);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(65, 153);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(675, 65);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(59, 119);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(231, 31);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Ingrese el nombre";
            // 
            // chkComida1
            // 
            this.chkComida1.AutoSize = true;
            this.chkComida1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkComida1.Location = new System.Drawing.Point(66, 224);
            this.chkComida1.Name = "chkComida1";
            this.chkComida1.Size = new System.Drawing.Size(206, 35);
            this.chkComida1.TabIndex = 5;
            this.chkComida1.Text = "Hamburguesa";
            this.chkComida1.UseVisualStyleBackColor = true;
            // 
            // chkComida2
            // 
            this.chkComida2.AutoSize = true;
            this.chkComida2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkComida2.Location = new System.Drawing.Point(318, 224);
            this.chkComida2.Name = "chkComida2";
            this.chkComida2.Size = new System.Drawing.Size(103, 35);
            this.chkComida2.TabIndex = 6;
            this.chkComida2.Text = "Pizza";
            this.chkComida2.UseVisualStyleBackColor = true;
            // 
            // chkComida3
            // 
            this.chkComida3.AutoSize = true;
            this.chkComida3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkComida3.Location = new System.Drawing.Point(473, 224);
            this.chkComida3.Name = "chkComida3";
            this.chkComida3.Size = new System.Drawing.Size(163, 35);
            this.chkComida3.TabIndex = 7;
            this.chkComida3.Text = "Ensaladita";
            this.chkComida3.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(62, 429);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(680, 43);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = " - - - - - - ";
            // 
            // cboPagos
            // 
            this.cboPagos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPagos.FormattingEnabled = true;
            this.cboPagos.Items.AddRange(new object[] {
            "Tarjeta",
            "PagoFacil",
            "Efectivo",
            "Transferencia"});
            this.cboPagos.Location = new System.Drawing.Point(66, 323);
            this.cboPagos.Name = "cboPagos";
            this.cboPagos.Size = new System.Drawing.Size(674, 39);
            this.cboPagos.TabIndex = 9;
            this.cboPagos.SelectedIndexChanged += new System.EventHandler(this.cboPagos_SelectedIndexChanged);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.Location = new System.Drawing.Point(60, 289);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(286, 31);
            this.lblLista.TabIndex = 10;
            this.lblLista.Text = "Elija un medio de pago";
            // 
            // frmPrincipal
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(812, 558);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.cboPagos);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.chkComida3);
            this.Controls.Add(this.chkComida2);
            this.Controls.Add(this.chkComida1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblPosicion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Título de la ventana";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.CheckBox chkComida1;
        private System.Windows.Forms.CheckBox chkComida2;
        private System.Windows.Forms.CheckBox chkComida3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ComboBox cboPagos;
        private System.Windows.Forms.Label lblLista;
    }
}

