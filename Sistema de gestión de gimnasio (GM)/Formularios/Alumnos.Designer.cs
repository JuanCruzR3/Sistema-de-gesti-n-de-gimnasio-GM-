namespace Sistema_de_gestión_de_gimnasio__GM_.Formularios
{
    partial class Alumnos
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numAllegado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagoCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymManagementDataSet = new Sistema_de_gestión_de_gimnasio__GM_.GymManagementDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreAlumnosForm = new System.Windows.Forms.TextBox();
            this.txtApellidoAlumnosForm = new System.Windows.Forms.TextBox();
            this.txtNumTelAlumnosForm = new System.Windows.Forms.TextBox();
            this.txtContAlleAlumnosForm = new System.Windows.Forms.TextBox();
            this.txtDNIAlumnosForm = new System.Windows.Forms.TextBox();
            this.cbxPagoCuotaAlumnosForm = new System.Windows.Forms.ComboBox();
            this.ButtonGuardarAlumnosForm = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnModificarAlumnos = new System.Windows.Forms.Button();
            this.alumnosTableAdapter = new Sistema_de_gestión_de_gimnasio__GM_.GymManagementDataSetTableAdapters.AlumnosTableAdapter();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.apellido,
            this.NumeroTelefono,
            this.numAllegado,
            this.DNI,
            this.PagoCuota,
            this.id});
            this.dataGridView1.DataSource = this.alumnosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(970, 365);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "apellido";
            this.apellido.MinimumWidth = 8;
            this.apellido.Name = "apellido";
            this.apellido.Width = 150;
            // 
            // NumeroTelefono
            // 
            this.NumeroTelefono.DataPropertyName = "NumeroTelefono";
            this.NumeroTelefono.HeaderText = "NumeroTelefono";
            this.NumeroTelefono.MinimumWidth = 8;
            this.NumeroTelefono.Name = "NumeroTelefono";
            this.NumeroTelefono.Width = 150;
            // 
            // numAllegado
            // 
            this.numAllegado.DataPropertyName = "numAllegado";
            this.numAllegado.HeaderText = "numAllegado";
            this.numAllegado.MinimumWidth = 8;
            this.numAllegado.Name = "numAllegado";
            this.numAllegado.Width = 150;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI";
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 8;
            this.DNI.Name = "DNI";
            this.DNI.Width = 150;
            // 
            // PagoCuota
            // 
            this.PagoCuota.DataPropertyName = "PagoCuota";
            this.PagoCuota.HeaderText = "PagoCuota";
            this.PagoCuota.MinimumWidth = 8;
            this.PagoCuota.Name = "PagoCuota";
            this.PagoCuota.Width = 150;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 150;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.gymManagementDataSet;
            // 
            // gymManagementDataSet
            // 
            this.gymManagementDataSet.DataSetName = "GymManagementDataSet";
            this.gymManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1068, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1068, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(1068, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Número de teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(1068, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contacto de allegado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(1068, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "DNI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(1068, 298);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pago cuota? ";
            // 
            // txtNombreAlumnosForm
            // 
            this.txtNombreAlumnosForm.Location = new System.Drawing.Point(1148, 32);
            this.txtNombreAlumnosForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreAlumnosForm.Name = "txtNombreAlumnosForm";
            this.txtNombreAlumnosForm.Size = new System.Drawing.Size(226, 26);
            this.txtNombreAlumnosForm.TabIndex = 7;
            this.txtNombreAlumnosForm.TextChanged += new System.EventHandler(this.txtNombreAlumnosForm_TextChanged);
            this.txtNombreAlumnosForm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyLetter);
            // 
            // txtApellidoAlumnosForm
            // 
            this.txtApellidoAlumnosForm.Location = new System.Drawing.Point(1148, 75);
            this.txtApellidoAlumnosForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellidoAlumnosForm.Name = "txtApellidoAlumnosForm";
            this.txtApellidoAlumnosForm.Size = new System.Drawing.Size(226, 26);
            this.txtApellidoAlumnosForm.TabIndex = 8;
            this.txtApellidoAlumnosForm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyLetter);
            // 
            // txtNumTelAlumnosForm
            // 
            this.txtNumTelAlumnosForm.Location = new System.Drawing.Point(1227, 115);
            this.txtNumTelAlumnosForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumTelAlumnosForm.Name = "txtNumTelAlumnosForm";
            this.txtNumTelAlumnosForm.Size = new System.Drawing.Size(176, 26);
            this.txtNumTelAlumnosForm.TabIndex = 9;
            this.txtNumTelAlumnosForm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // txtContAlleAlumnosForm
            // 
            this.txtContAlleAlumnosForm.Location = new System.Drawing.Point(1244, 162);
            this.txtContAlleAlumnosForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContAlleAlumnosForm.Name = "txtContAlleAlumnosForm";
            this.txtContAlleAlumnosForm.Size = new System.Drawing.Size(160, 26);
            this.txtContAlleAlumnosForm.TabIndex = 10;
            this.txtContAlleAlumnosForm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // txtDNIAlumnosForm
            // 
            this.txtDNIAlumnosForm.Location = new System.Drawing.Point(1120, 202);
            this.txtDNIAlumnosForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDNIAlumnosForm.Name = "txtDNIAlumnosForm";
            this.txtDNIAlumnosForm.Size = new System.Drawing.Size(211, 26);
            this.txtDNIAlumnosForm.TabIndex = 11;
            this.txtDNIAlumnosForm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // cbxPagoCuotaAlumnosForm
            // 
            this.cbxPagoCuotaAlumnosForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPagoCuotaAlumnosForm.FormattingEnabled = true;
            this.cbxPagoCuotaAlumnosForm.Items.AddRange(new object[] {
            "Si ",
            "No"});
            this.cbxPagoCuotaAlumnosForm.Location = new System.Drawing.Point(1184, 294);
            this.cbxPagoCuotaAlumnosForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxPagoCuotaAlumnosForm.Name = "cbxPagoCuotaAlumnosForm";
            this.cbxPagoCuotaAlumnosForm.Size = new System.Drawing.Size(84, 28);
            this.cbxPagoCuotaAlumnosForm.TabIndex = 12;
            this.cbxPagoCuotaAlumnosForm.SelectedIndexChanged += new System.EventHandler(this.cbxPagoCuotaAlumnosForm_SelectedIndexChanged);
            // 
            // ButtonGuardarAlumnosForm
            // 
            this.ButtonGuardarAlumnosForm.BackColor = System.Drawing.Color.Transparent;
            this.ButtonGuardarAlumnosForm.Location = new System.Drawing.Point(1227, 466);
            this.ButtonGuardarAlumnosForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonGuardarAlumnosForm.Name = "ButtonGuardarAlumnosForm";
            this.ButtonGuardarAlumnosForm.Size = new System.Drawing.Size(162, 58);
            this.ButtonGuardarAlumnosForm.TabIndex = 13;
            this.ButtonGuardarAlumnosForm.Text = "Guardar";
            this.ButtonGuardarAlumnosForm.UseVisualStyleBackColor = false;
            this.ButtonGuardarAlumnosForm.Click += new System.EventHandler(this.ButtonGuardarAlumnosForm_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(20, 8);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(122, 35);
            this.btnAtras.TabIndex = 14;
            this.btnAtras.Text = "<-- Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnModificarAlumnos
            // 
            this.btnModificarAlumnos.Location = new System.Drawing.Point(20, 440);
            this.btnModificarAlumnos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarAlumnos.Name = "btnModificarAlumnos";
            this.btnModificarAlumnos.Size = new System.Drawing.Size(129, 48);
            this.btnModificarAlumnos.TabIndex = 15;
            this.btnModificarAlumnos.Text = "Modificar";
            this.btnModificarAlumnos.UseVisualStyleBackColor = true;
            this.btnModificarAlumnos.Click += new System.EventHandler(this.btnModificarAlumnos_Click);
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(208, 440);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 48);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1424, 543);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificarAlumnos);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.ButtonGuardarAlumnosForm);
            this.Controls.Add(this.cbxPagoCuotaAlumnosForm);
            this.Controls.Add(this.txtDNIAlumnosForm);
            this.Controls.Add(this.txtContAlleAlumnosForm);
            this.Controls.Add(this.txtNumTelAlumnosForm);
            this.Controls.Add(this.txtApellidoAlumnosForm);
            this.Controls.Add(this.txtNombreAlumnosForm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Alumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Alumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreAlumnosForm;
        private System.Windows.Forms.TextBox txtApellidoAlumnosForm;
        private System.Windows.Forms.TextBox txtNumTelAlumnosForm;
        private System.Windows.Forms.TextBox txtContAlleAlumnosForm;
        private System.Windows.Forms.TextBox txtDNIAlumnosForm;
        private System.Windows.Forms.ComboBox cbxPagoCuotaAlumnosForm;
        private System.Windows.Forms.Button ButtonGuardarAlumnosForm;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnModificarAlumnos;
        private GymManagementDataSet gymManagementDataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private GymManagementDataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn numAllegado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagoCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Button btnEliminar;
    }
}