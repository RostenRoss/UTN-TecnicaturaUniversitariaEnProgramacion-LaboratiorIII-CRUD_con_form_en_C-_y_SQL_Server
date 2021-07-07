
namespace CrudBarrioFrom.presentacion
{
    partial class AddServicioInternet
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
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label velocidadLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label empresaLabel;
            System.Windows.Forms.Label limiteDeDatosLabel;
            System.Windows.Forms.Label fechaInstaladoLabel;
            System.Windows.Forms.Label id_casaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServicioInternet));
            this.dataSet1 = new CrudBarrioFrom.DataSet1();
            this.servicioInternetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicioInternetTableAdapter = new CrudBarrioFrom.DataSet1TableAdapters.servicioInternetTableAdapter();
            this.tableAdapterManager = new CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.velocidadTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.empresaTextBox = new System.Windows.Forms.TextBox();
            this.limiteDeDatosTextBox = new System.Windows.Forms.TextBox();
            this.fechaInstaladoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_casaTextBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.aceptarBtn = new System.Windows.Forms.Button();
            tipoLabel = new System.Windows.Forms.Label();
            velocidadLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            empresaLabel = new System.Windows.Forms.Label();
            limiteDeDatosLabel = new System.Windows.Forms.Label();
            fechaInstaladoLabel = new System.Windows.Forms.Label();
            id_casaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioInternetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicioInternetBindingSource
            // 
            this.servicioInternetBindingSource.DataMember = "servicioInternet";
            this.servicioInternetBindingSource.DataSource = this.dataSet1;
            // 
            // servicioInternetTableAdapter
            // 
            this.servicioInternetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.casasTableAdapter = null;
            this.tableAdapterManager.exteriorTableAdapter = null;
            this.tableAdapterManager.habitacionTableAdapter = null;
            this.tableAdapterManager.mascotaTableAdapter = null;
            this.tableAdapterManager.mueblesTableAdapter = null;
            this.tableAdapterManager.padresTableAdapter = null;
            this.tableAdapterManager.servicioAguaTableAdapter = null;
            this.tableAdapterManager.servicioCableTableAdapter = null;
            this.tableAdapterManager.servicioElectricidadTableAdapter = null;
            this.tableAdapterManager.servicioInternetTableAdapter = this.servicioInternetTableAdapter;
            this.tableAdapterManager.UpdateOrder = CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(40, 42);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(27, 13);
            tipoLabel.TabIndex = 3;
            tipoLabel.Text = "tipo:";
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicioInternetBindingSource, "tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(129, 39);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(200, 20);
            this.tipoTextBox.TabIndex = 4;
            // 
            // velocidadLabel
            // 
            velocidadLabel.AutoSize = true;
            velocidadLabel.Location = new System.Drawing.Point(40, 68);
            velocidadLabel.Name = "velocidadLabel";
            velocidadLabel.Size = new System.Drawing.Size(56, 13);
            velocidadLabel.TabIndex = 5;
            velocidadLabel.Text = "velocidad:";
            // 
            // velocidadTextBox
            // 
            this.velocidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicioInternetBindingSource, "velocidad", true));
            this.velocidadTextBox.Location = new System.Drawing.Point(129, 65);
            this.velocidadTextBox.Name = "velocidadTextBox";
            this.velocidadTextBox.Size = new System.Drawing.Size(200, 20);
            this.velocidadTextBox.TabIndex = 6;
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(40, 94);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(39, 13);
            precioLabel.TabIndex = 7;
            precioLabel.Text = "precio:";
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicioInternetBindingSource, "precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(129, 91);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(200, 20);
            this.precioTextBox.TabIndex = 8;
            // 
            // empresaLabel
            // 
            empresaLabel.AutoSize = true;
            empresaLabel.Location = new System.Drawing.Point(40, 120);
            empresaLabel.Name = "empresaLabel";
            empresaLabel.Size = new System.Drawing.Size(50, 13);
            empresaLabel.TabIndex = 9;
            empresaLabel.Text = "empresa:";
            // 
            // empresaTextBox
            // 
            this.empresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicioInternetBindingSource, "empresa", true));
            this.empresaTextBox.Location = new System.Drawing.Point(129, 117);
            this.empresaTextBox.Name = "empresaTextBox";
            this.empresaTextBox.Size = new System.Drawing.Size(200, 20);
            this.empresaTextBox.TabIndex = 10;
            // 
            // limiteDeDatosLabel
            // 
            limiteDeDatosLabel.AutoSize = true;
            limiteDeDatosLabel.Location = new System.Drawing.Point(40, 146);
            limiteDeDatosLabel.Name = "limiteDeDatosLabel";
            limiteDeDatosLabel.Size = new System.Drawing.Size(81, 13);
            limiteDeDatosLabel.TabIndex = 11;
            limiteDeDatosLabel.Text = "limite De Datos:";
            // 
            // limiteDeDatosTextBox
            // 
            this.limiteDeDatosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicioInternetBindingSource, "limiteDeDatos", true));
            this.limiteDeDatosTextBox.Location = new System.Drawing.Point(129, 143);
            this.limiteDeDatosTextBox.Name = "limiteDeDatosTextBox";
            this.limiteDeDatosTextBox.Size = new System.Drawing.Size(200, 20);
            this.limiteDeDatosTextBox.TabIndex = 12;
            // 
            // fechaInstaladoLabel
            // 
            fechaInstaladoLabel.AutoSize = true;
            fechaInstaladoLabel.Location = new System.Drawing.Point(40, 173);
            fechaInstaladoLabel.Name = "fechaInstaladoLabel";
            fechaInstaladoLabel.Size = new System.Drawing.Size(83, 13);
            fechaInstaladoLabel.TabIndex = 13;
            fechaInstaladoLabel.Text = "fecha Instalado:";
            // 
            // fechaInstaladoDateTimePicker
            // 
            this.fechaInstaladoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.servicioInternetBindingSource, "fechaInstalado", true));
            this.fechaInstaladoDateTimePicker.Location = new System.Drawing.Point(129, 169);
            this.fechaInstaladoDateTimePicker.Name = "fechaInstaladoDateTimePicker";
            this.fechaInstaladoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaInstaladoDateTimePicker.TabIndex = 14;
            // 
            // id_casaLabel
            // 
            id_casaLabel.AutoSize = true;
            id_casaLabel.Location = new System.Drawing.Point(40, 198);
            id_casaLabel.Name = "id_casaLabel";
            id_casaLabel.Size = new System.Drawing.Size(44, 13);
            id_casaLabel.TabIndex = 15;
            id_casaLabel.Text = "id casa:";
            // 
            // id_casaTextBox
            // 
            this.id_casaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicioInternetBindingSource, "id_casa", true));
            this.id_casaTextBox.Location = new System.Drawing.Point(129, 195);
            this.id_casaTextBox.Name = "id_casaTextBox";
            this.id_casaTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_casaTextBox.TabIndex = 16;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.LightCoral;
            this.cancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.BackgroundImage")));
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelBtn.Location = new System.Drawing.Point(237, 256);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 57);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.aceptarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aceptarBtn.BackgroundImage")));
            this.aceptarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aceptarBtn.Location = new System.Drawing.Point(60, 256);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(75, 57);
            this.aceptarBtn.TabIndex = 17;
            this.aceptarBtn.UseVisualStyleBackColor = false;
            this.aceptarBtn.Click += new System.EventHandler(this.aceptarBtn_Click);
            // 
            // AddServicioInternet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 334);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.aceptarBtn);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(velocidadLabel);
            this.Controls.Add(this.velocidadTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(empresaLabel);
            this.Controls.Add(this.empresaTextBox);
            this.Controls.Add(limiteDeDatosLabel);
            this.Controls.Add(this.limiteDeDatosTextBox);
            this.Controls.Add(fechaInstaladoLabel);
            this.Controls.Add(this.fechaInstaladoDateTimePicker);
            this.Controls.Add(id_casaLabel);
            this.Controls.Add(this.id_casaTextBox);
            this.Name = "AddServicioInternet";
            this.Text = "Agregar servicio de internet";
            this.Load += new System.EventHandler(this.AddServicioInternet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioInternetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource servicioInternetBindingSource;
        private DataSet1TableAdapters.servicioInternetTableAdapter servicioInternetTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.TextBox velocidadTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox empresaTextBox;
        private System.Windows.Forms.TextBox limiteDeDatosTextBox;
        private System.Windows.Forms.DateTimePicker fechaInstaladoDateTimePicker;
        private System.Windows.Forms.TextBox id_casaTextBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button aceptarBtn;
    }
}