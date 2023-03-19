namespace T4_POO_2Z_2doParcial_Romeo_Marcos
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
            this.dgvSocios = new System.Windows.Forms.DataGridView();
            this.dgvCuotaPendiente = new System.Windows.Forms.DataGridView();
            this.dgvCuotaPagada = new System.Windows.Forms.DataGridView();
            this.dgvCuotaOrdenada = new System.Windows.Forms.DataGridView();
            this.dgvSocioTotal = new System.Windows.Forms.DataGridView();
            this.grpSocios = new System.Windows.Forms.GroupBox();
            this.rdbSocioEspecial = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rdbSocioNormal = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCuota = new System.Windows.Forms.GroupBox();
            this.btnCrearCuota = new System.Windows.Forms.Button();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.rdbGeneral = new System.Windows.Forms.RadioButton();
            this.rdbIndividual = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbMenorMayor = new System.Windows.Forms.RadioButton();
            this.rdbMayorMenor = new System.Windows.Forms.RadioButton();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblModificar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotaPendiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotaPagada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotaOrdenada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocioTotal)).BeginInit();
            this.grpSocios.SuspendLayout();
            this.grpCuota.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSocios
            // 
            this.dgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocios.Location = new System.Drawing.Point(15, 58);
            this.dgvSocios.Name = "dgvSocios";
            this.dgvSocios.Size = new System.Drawing.Size(351, 150);
            this.dgvSocios.TabIndex = 0;
            this.dgvSocios.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSocios_RowEnter);
            // 
            // dgvCuotaPendiente
            // 
            this.dgvCuotaPendiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuotaPendiente.Location = new System.Drawing.Point(397, 58);
            this.dgvCuotaPendiente.Name = "dgvCuotaPendiente";
            this.dgvCuotaPendiente.Size = new System.Drawing.Size(544, 96);
            this.dgvCuotaPendiente.TabIndex = 1;
            // 
            // dgvCuotaPagada
            // 
            this.dgvCuotaPagada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuotaPagada.Location = new System.Drawing.Point(397, 200);
            this.dgvCuotaPagada.Name = "dgvCuotaPagada";
            this.dgvCuotaPagada.Size = new System.Drawing.Size(544, 150);
            this.dgvCuotaPagada.TabIndex = 2;
            // 
            // dgvCuotaOrdenada
            // 
            this.dgvCuotaOrdenada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuotaOrdenada.Location = new System.Drawing.Point(1079, 58);
            this.dgvCuotaOrdenada.Name = "dgvCuotaOrdenada";
            this.dgvCuotaOrdenada.Size = new System.Drawing.Size(240, 150);
            this.dgvCuotaOrdenada.TabIndex = 3;
            // 
            // dgvSocioTotal
            // 
            this.dgvSocioTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocioTotal.Location = new System.Drawing.Point(1079, 381);
            this.dgvSocioTotal.Name = "dgvSocioTotal";
            this.dgvSocioTotal.Size = new System.Drawing.Size(240, 150);
            this.dgvSocioTotal.TabIndex = 4;
            // 
            // grpSocios
            // 
            this.grpSocios.Controls.Add(this.rdbSocioEspecial);
            this.grpSocios.Controls.Add(this.btnAgregar);
            this.grpSocios.Controls.Add(this.rdbSocioNormal);
            this.grpSocios.Controls.Add(this.txtNombre);
            this.grpSocios.Controls.Add(this.txtApellido);
            this.grpSocios.Controls.Add(this.txtLegajo);
            this.grpSocios.Controls.Add(this.label3);
            this.grpSocios.Controls.Add(this.label2);
            this.grpSocios.Controls.Add(this.label1);
            this.grpSocios.Location = new System.Drawing.Point(54, 345);
            this.grpSocios.Name = "grpSocios";
            this.grpSocios.Size = new System.Drawing.Size(201, 216);
            this.grpSocios.TabIndex = 5;
            this.grpSocios.TabStop = false;
            this.grpSocios.Text = "Socio";
            // 
            // rdbSocioEspecial
            // 
            this.rdbSocioEspecial.AutoSize = true;
            this.rdbSocioEspecial.Location = new System.Drawing.Point(119, 36);
            this.rdbSocioEspecial.Name = "rdbSocioEspecial";
            this.rdbSocioEspecial.Size = new System.Drawing.Size(65, 17);
            this.rdbSocioEspecial.TabIndex = 11;
            this.rdbSocioEspecial.Text = "Especial";
            this.rdbSocioEspecial.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(112, 174);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rdbSocioNormal
            // 
            this.rdbSocioNormal.AutoSize = true;
            this.rdbSocioNormal.Checked = true;
            this.rdbSocioNormal.Location = new System.Drawing.Point(14, 36);
            this.rdbSocioNormal.Name = "rdbSocioNormal";
            this.rdbSocioNormal.Size = new System.Drawing.Size(58, 17);
            this.rdbSocioNormal.TabIndex = 10;
            this.rdbSocioNormal.TabStop = true;
            this.rdbSocioNormal.Text = "Normal";
            this.rdbSocioNormal.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(87, 130);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(87, 102);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(87, 70);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtLegajo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Legajo";
            // 
            // grpCuota
            // 
            this.grpCuota.Controls.Add(this.btnCrearCuota);
            this.grpCuota.Controls.Add(this.txtImporte);
            this.grpCuota.Controls.Add(this.txtCodigo);
            this.grpCuota.Controls.Add(this.rdbGeneral);
            this.grpCuota.Controls.Add(this.rdbIndividual);
            this.grpCuota.Controls.Add(this.label5);
            this.grpCuota.Controls.Add(this.label6);
            this.grpCuota.Location = new System.Drawing.Point(397, 375);
            this.grpCuota.Name = "grpCuota";
            this.grpCuota.Size = new System.Drawing.Size(200, 186);
            this.grpCuota.TabIndex = 6;
            this.grpCuota.TabStop = false;
            this.grpCuota.Text = "Cuota";
            // 
            // btnCrearCuota
            // 
            this.btnCrearCuota.Location = new System.Drawing.Point(111, 146);
            this.btnCrearCuota.Name = "btnCrearCuota";
            this.btnCrearCuota.Size = new System.Drawing.Size(75, 23);
            this.btnCrearCuota.TabIndex = 9;
            this.btnCrearCuota.Text = "Crear cuota";
            this.btnCrearCuota.UseVisualStyleBackColor = true;
            this.btnCrearCuota.Click += new System.EventHandler(this.btnCrearCuota_Click);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(86, 102);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 7;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(86, 70);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // rdbGeneral
            // 
            this.rdbGeneral.AutoSize = true;
            this.rdbGeneral.Location = new System.Drawing.Point(117, 25);
            this.rdbGeneral.Name = "rdbGeneral";
            this.rdbGeneral.Size = new System.Drawing.Size(62, 17);
            this.rdbGeneral.TabIndex = 5;
            this.rdbGeneral.Text = "General";
            this.rdbGeneral.UseVisualStyleBackColor = true;
            // 
            // rdbIndividual
            // 
            this.rdbIndividual.AutoSize = true;
            this.rdbIndividual.Checked = true;
            this.rdbIndividual.Location = new System.Drawing.Point(12, 25);
            this.rdbIndividual.Name = "rdbIndividual";
            this.rdbIndividual.Size = new System.Drawing.Size(70, 17);
            this.rdbIndividual.TabIndex = 5;
            this.rdbIndividual.TabStop = true;
            this.rdbIndividual.Text = "Individual";
            this.rdbIndividual.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Importe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Código";
            // 
            // rdbMenorMayor
            // 
            this.rdbMenorMayor.AutoSize = true;
            this.rdbMenorMayor.Location = new System.Drawing.Point(1079, 223);
            this.rdbMenorMayor.Name = "rdbMenorMayor";
            this.rdbMenorMayor.Size = new System.Drawing.Size(96, 17);
            this.rdbMenorMayor.TabIndex = 8;
            this.rdbMenorMayor.TabStop = true;
            this.rdbMenorMayor.Text = "Menor a Mayor";
            this.rdbMenorMayor.UseVisualStyleBackColor = true;
            // 
            // rdbMayorMenor
            // 
            this.rdbMayorMenor.AutoSize = true;
            this.rdbMayorMenor.Location = new System.Drawing.Point(1079, 264);
            this.rdbMayorMenor.Name = "rdbMayorMenor";
            this.rdbMayorMenor.Size = new System.Drawing.Size(96, 17);
            this.rdbMayorMenor.TabIndex = 7;
            this.rdbMayorMenor.TabStop = true;
            this.rdbMayorMenor.Text = "Mayor a Menor";
            this.rdbMayorMenor.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(54, 223);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(243, 223);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(1244, 239);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 42);
            this.btnOrdenar.TabIndex = 10;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1244, 588);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(927, 160);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 12;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(174, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Socios";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(640, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cuotas pendientes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(651, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cuotas pagas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1132, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Ordenamiento pago";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1160, 352);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Total Socio";
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Location = new System.Drawing.Point(643, 431);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpVencimiento.TabIndex = 19;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(640, 381);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(260, 17);
            this.label.TabIndex = 20;
            this.label.Text = "Fecha de vencimiento para prueba";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(640, 406);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "( por defecto es a un mes )";
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.Location = new System.Drawing.Point(26, 313);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(321, 17);
            this.lblModificar.TabIndex = 22;
            this.lblModificar.Text = "Modifique los campos deseados y oprima Aceptar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 654);
            this.Controls.Add(this.lblModificar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dtpVencimiento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.rdbMenorMayor);
            this.Controls.Add(this.rdbMayorMenor);
            this.Controls.Add(this.grpCuota);
            this.Controls.Add(this.grpSocios);
            this.Controls.Add(this.dgvSocioTotal);
            this.Controls.Add(this.dgvCuotaOrdenada);
            this.Controls.Add(this.dgvCuotaPagada);
            this.Controls.Add(this.dgvCuotaPendiente);
            this.Controls.Add(this.dgvSocios);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cobro Club";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotaPendiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotaPagada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotaOrdenada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocioTotal)).EndInit();
            this.grpSocios.ResumeLayout(false);
            this.grpSocios.PerformLayout();
            this.grpCuota.ResumeLayout(false);
            this.grpCuota.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSocios;
        private System.Windows.Forms.DataGridView dgvCuotaPendiente;
        private System.Windows.Forms.DataGridView dgvCuotaPagada;
        private System.Windows.Forms.DataGridView dgvCuotaOrdenada;
        private System.Windows.Forms.DataGridView dgvSocioTotal;
        private System.Windows.Forms.GroupBox grpSocios;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCuota;
        private System.Windows.Forms.Button btnCrearCuota;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.RadioButton rdbGeneral;
        private System.Windows.Forms.RadioButton rdbIndividual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbMenorMayor;
        private System.Windows.Forms.RadioButton rdbMayorMenor;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.RadioButton rdbSocioEspecial;
        private System.Windows.Forms.RadioButton rdbSocioNormal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblModificar;
    }
}

