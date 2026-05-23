namespace FarmaciaPedidosApp
{
    partial class FormularioPedidos : System.Windows.Forms.Form
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
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbScurcursal = new System.Windows.Forms.GroupBox();
            this.chkSecundaria = new System.Windows.Forms.CheckBox();
            this.chkPrincipal = new System.Windows.Forms.CheckBox();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.gbDistribuidor = new System.Windows.Forms.GroupBox();
            this.rbCofarma = new System.Windows.Forms.RadioButton();
            this.rbEmpsephar = new System.Windows.Forms.RadioButton();
            this.rbCemefar = new System.Windows.Forms.RadioButton();
            this.gbScurcursal.SuspendLayout();
            this.gbDistribuidor.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Location = new System.Drawing.Point(145, 60);
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(230, 20);
            this.txtMedicamento.TabIndex = 0;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(504, 63);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del medicamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipos de medicamento ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(216, 94);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sucursales";
            // 
            // gbScurcursal
            // 
            this.gbScurcursal.Controls.Add(this.chkSecundaria);
            this.gbScurcursal.Controls.Add(this.chkPrincipal);
            this.gbScurcursal.Location = new System.Drawing.Point(116, 170);
            this.gbScurcursal.Name = "gbScurcursal";
            this.gbScurcursal.Size = new System.Drawing.Size(200, 100);
            this.gbScurcursal.TabIndex = 9;
            this.gbScurcursal.TabStop = false;
            this.gbScurcursal.Text = "Farmacias";
            // 
            // chkSecundaria
            // 
            this.chkSecundaria.AutoSize = true;
            this.chkSecundaria.Location = new System.Drawing.Point(16, 49);
            this.chkSecundaria.Name = "chkSecundaria";
            this.chkSecundaria.Size = new System.Drawing.Size(121, 17);
            this.chkSecundaria.TabIndex = 1;
            this.chkSecundaria.Text = "farmacia secundaria";
            this.chkSecundaria.UseVisualStyleBackColor = true;
            // 
            // chkPrincipal
            // 
            this.chkPrincipal.AutoSize = true;
            this.chkPrincipal.Location = new System.Drawing.Point(16, 20);
            this.chkPrincipal.Name = "chkPrincipal";
            this.chkPrincipal.Size = new System.Drawing.Size(108, 17);
            this.chkPrincipal.TabIndex = 0;
            this.chkPrincipal.Text = "farmacia principal";
            this.chkPrincipal.UseVisualStyleBackColor = true;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Location = new System.Drawing.Point(116, 309);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirmar.TabIndex = 10;
            this.BtnConfirmar.Text = "Confirmar ";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(374, 309);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(75, 23);
            this.BtnBorrar.TabIndex = 11;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // gbDistribuidor
            // 
            this.gbDistribuidor.Controls.Add(this.rbCemefar);
            this.gbDistribuidor.Controls.Add(this.rbEmpsephar);
            this.gbDistribuidor.Controls.Add(this.rbCofarma);
            this.gbDistribuidor.Location = new System.Drawing.Point(374, 170);
            this.gbDistribuidor.Name = "gbDistribuidor";
            this.gbDistribuidor.Size = new System.Drawing.Size(278, 100);
            this.gbDistribuidor.TabIndex = 12;
            this.gbDistribuidor.TabStop = false;
            this.gbDistribuidor.Text = "Seleccionar Distribuidor";
            // 
            // rbCofarma
            // 
            this.rbCofarma.AutoSize = true;
            this.rbCofarma.Location = new System.Drawing.Point(23, 20);
            this.rbCofarma.Name = "rbCofarma";
            this.rbCofarma.Size = new System.Drawing.Size(61, 17);
            this.rbCofarma.TabIndex = 0;
            this.rbCofarma.TabStop = true;
            this.rbCofarma.Text = "Cofama";
            this.rbCofarma.UseVisualStyleBackColor = true;
            // 
            // rbEmpsephar
            // 
            this.rbEmpsephar.AutoSize = true;
            this.rbEmpsephar.Location = new System.Drawing.Point(23, 43);
            this.rbEmpsephar.Name = "rbEmpsephar";
            this.rbEmpsephar.Size = new System.Drawing.Size(78, 17);
            this.rbEmpsephar.TabIndex = 1;
            this.rbEmpsephar.TabStop = true;
            this.rbEmpsephar.Text = "Empsephar";
            this.rbEmpsephar.UseVisualStyleBackColor = true;
            // 
            // rbCemefar
            // 
            this.rbCemefar.AutoSize = true;
            this.rbCemefar.Location = new System.Drawing.Point(23, 68);
            this.rbCemefar.Name = "rbCemefar";
            this.rbCemefar.Size = new System.Drawing.Size(64, 17);
            this.rbCemefar.TabIndex = 2;
            this.rbCemefar.TabStop = true;
            this.rbCemefar.Text = "Cemefar";
            this.rbCemefar.UseVisualStyleBackColor = true;
            // 
            // FormularioPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDistribuidor);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.gbScurcursal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtMedicamento);
            this.Name = "FormularioPedidos";
            this.Text = "Form1";
            this.gbScurcursal.ResumeLayout(false);
            this.gbScurcursal.PerformLayout();
            this.gbDistribuidor.ResumeLayout(false);
            this.gbDistribuidor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMedicamento;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbScurcursal;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.CheckBox chkPrincipal;
        private System.Windows.Forms.CheckBox chkSecundaria;
        private System.Windows.Forms.GroupBox gbDistribuidor;
        private System.Windows.Forms.RadioButton rbCemefar;
        private System.Windows.Forms.RadioButton rbEmpsephar;
        private System.Windows.Forms.RadioButton rbCofarma;
    }
}

