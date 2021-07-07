
namespace CrudBarrioFrom.presentacion
{
    partial class AddServicioAgua
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
            System.Windows.Forms.Label empresaLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label fechaInstaladoLabel;
            System.Windows.Forms.Label id_casaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServicioAgua));
            this.dataSet1 = new CrudBarrioFrom.DataSet1();
            this.servicioAguaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicioAguaTableAdapter = new CrudBarrioFrom.DataSet1TableAdapters.servicioAguaTableAdapter();
            this.tableAdapterManager = new CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.empresaTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.fechaInstaladoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_casaTextBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.aceptarBtn = new System.Windows.Forms.Button();
            tipoLabel = new System.Windows.Forms.Label();
            empresaLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            fechaInstaladoLabel = new System.Windows.Forms.Label();
            id_casaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioAguaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicioAguaBindingSource
            // 
            this.servicioAguaBindingSource.DataMember = "servicioAgua";
            this.servicioAguaBindingSource.DataSource = this.dataSet1;
            // 
            // servicioAguaTableAdapter
            // 
            this.servicioAguaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.servicioAguaTableAdapter = this.servicioAguaTableAdapter;
            this.tableAdapterManager.servicioCableTableAdapter = null;
            this.tableAdapterManager.servicioElectricidadTableAdapter = null;
            this.tableAdapterManager.servicioInternetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(47, 44);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(27, 13);
            tipoLabel.TabIndex = 3;
            tipoLabel.Text = "tipo:";
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicioAguaBindingSource, "tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(136, 41);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(200, 20);
            this.tipoTextBox.TabIndex = 4;
            // 
            // empresaLabel
            // 
            empresaLabel.AutoSize = true;
            empresaLabel.Location = new System.Drawing.Point(47, 70);
            empresaLabel.Name = "empresaLabel";
            empresaLabel.Size = new System.Drawing.Size(50, 13);
            empresaLabel.TabIndex = 5;
            empresaLabel.Text = "empresa:";
            // 
            // empresaTextBox
            // 
            this.empresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicioAguaBindingSource, "empresa", true));
            this.empresaTextBox.Location = new System.Drawing.Point(136, 67);
            this.empresaTextBox.Name = "empresaTextBox";
            this.empresaTextBox.Size = new System.Drawing.Size(200, 20);
            this.empresaTextBox.TabIndex = 6;
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(47, 96);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(39, 13);
            precioLabel.TabIndex = 7;
            precioLabel.Text = "precio:";
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicioAguaBindingSource, "precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(136, 93);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(200, 20);
            this.precioTextBox.TabIndex = 8;
            // 
            // fechaInstaladoLabel
            // 
            fechaInstaladoLabel.AutoSize = true;
            fechaInstaladoLabel.Location = new System.Drawing.Point(47, 123);
            fechaInstaladoLabel.Name = "fechaInstaladoLabel";
            fechaInstaladoLabel.Size = new System.Drawing.Size(83, 13);
            fechaInstaladoLabel.TabIndex = 9;
            fechaInstaladoLabel.Text = "fecha Instalado:";
            // 
            // fechaInstaladoDateTimePicker
            // 
            this.fechaInstaladoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.servicioAguaBindingSource, "fechaInstalado", true));
            this.fechaInstaladoDateTimePicker.Location = new System.Drawing.Point(136, 119);
            this.fechaInstaladoDateTimePicker.Name = "fechaInstaladoDateTimePicker";
            this.fechaInstaladoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaInstaladoDateTimePicker.TabIndex = 10;
            // 
            // id_casaLabel
            // 
            id_casaLabel.AutoSize = true;
            id_casaLabel.Location = new System.Drawing.Point(47, 148);
            id_casaLabel.Name = "id_casaLabel";
            id_casaLabel.Size = new System.Drawing.Size(44, 13);
            id_casaLabel.TabIndex = 11;
            id_casaLabel.Text = "id casa:";
            // 
            // id_casaTextBox
            // 
            this.id_casaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicioAguaBindingSource, "id_casa", true));
            this.id_casaTextBox.Location = new System.Drawing.Point(136, 145);
            this.id_casaTextBox.Name = "id_casaTextBox";
            this.id_casaTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_casaTextBox.TabIndex = 12;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.LightCoral;
            this.cancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.BackgroundImage")));
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelBtn.Location = new System.Drawing.Point(243, 210);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 57);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.aceptarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aceptarBtn.BackgroundImage")));
            this.aceptarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aceptarBtn.Location = new System.Drawing.Point(66, 210);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(75, 57);
            this.aceptarBtn.TabIndex = 13;
            this.aceptarBtn.UseVisualStyleBackColor = false;
            this.aceptarBtn.Click += new System.EventHandler(this.aceptarBtn_Click);
            // 
            // AddServicioAgua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 295);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.aceptarBtn);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(empresaLabel);
            this.Controls.Add(this.empresaTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(fechaInstaladoLabel);
            this.Controls.Add(this.fechaInstaladoDateTimePicker);
            this.Controls.Add(id_casaLabel);
            this.Controls.Add(this.id_casaTextBox);
            this.Name = "AddServicioAgua";
            this.Text = "Agregar servicio de agua";
            this.Load += new System.EventHandler(this.AddServicioAgua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioAguaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource servicioAguaBindingSource;
        private DataSet1TableAdapters.servicioAguaTableAdapter servicioAguaTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.TextBox empresaTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.DateTimePicker fechaInstaladoDateTimePicker;
        private System.Windows.Forms.TextBox id_casaTextBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button aceptarBtn;
    }
}