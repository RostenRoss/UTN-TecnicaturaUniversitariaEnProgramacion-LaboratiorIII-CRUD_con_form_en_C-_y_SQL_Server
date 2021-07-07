
namespace CrudBarrioFrom.presentacion
{
    partial class AddServicioLuz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServicioLuz));
            System.Windows.Forms.Label esTrifasicaLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label empresaLabel;
            System.Windows.Forms.Label fechaInstaladoLabel;
            System.Windows.Forms.Label id_casaLabel;
            this.cancelBtn = new System.Windows.Forms.Button();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.dataSet1 = new CrudBarrioFrom.DataSet1();
            this.servicioElectricidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicioElectricidadTableAdapter = new CrudBarrioFrom.DataSet1TableAdapters.servicioElectricidadTableAdapter();
            this.tableAdapterManager = new CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager();
            this.esTrifasicaCheckBox = new System.Windows.Forms.CheckBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.empresaTextBox = new System.Windows.Forms.TextBox();
            this.fechaInstaladoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_casaTextBox = new System.Windows.Forms.TextBox();
            esTrifasicaLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            empresaLabel = new System.Windows.Forms.Label();
            fechaInstaladoLabel = new System.Windows.Forms.Label();
            id_casaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElectricidadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.LightCoral;
            this.cancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.BackgroundImage")));
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelBtn.Location = new System.Drawing.Point(232, 200);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 57);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.aceptarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aceptarBtn.BackgroundImage")));
            this.aceptarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aceptarBtn.Location = new System.Drawing.Point(55, 200);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(75, 57);
            this.aceptarBtn.TabIndex = 12;
            this.aceptarBtn.UseVisualStyleBackColor = false;
            this.aceptarBtn.Click += new System.EventHandler(this.aceptarBtn_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicioElectricidadBindingSource
            // 
            this.servicioElectricidadBindingSource.DataMember = "servicioElectricidad";
            this.servicioElectricidadBindingSource.DataSource = this.dataSet1;
            // 
            // servicioElectricidadTableAdapter
            // 
            this.servicioElectricidadTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.servicioElectricidadTableAdapter = this.servicioElectricidadTableAdapter;
            this.tableAdapterManager.servicioInternetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // esTrifasicaLabel
            // 
            esTrifasicaLabel.AutoSize = true;
            esTrifasicaLabel.Location = new System.Drawing.Point(30, 40);
            esTrifasicaLabel.Name = "esTrifasicaLabel";
            esTrifasicaLabel.Size = new System.Drawing.Size(64, 13);
            esTrifasicaLabel.TabIndex = 16;
            esTrifasicaLabel.Text = "es Trifasica:";
            // 
            // esTrifasicaCheckBox
            // 
            this.esTrifasicaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.servicioElectricidadBindingSource, "esTrifasica", true));
            this.esTrifasicaCheckBox.Location = new System.Drawing.Point(119, 35);
            this.esTrifasicaCheckBox.Name = "esTrifasicaCheckBox";
            this.esTrifasicaCheckBox.Size = new System.Drawing.Size(200, 24);
            this.esTrifasicaCheckBox.TabIndex = 17;
            this.esTrifasicaCheckBox.UseVisualStyleBackColor = true;
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(30, 68);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(39, 13);
            precioLabel.TabIndex = 18;
            precioLabel.Text = "precio:";
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicioElectricidadBindingSource, "precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(119, 65);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(200, 20);
            this.precioTextBox.TabIndex = 19;
            // 
            // empresaLabel
            // 
            empresaLabel.AutoSize = true;
            empresaLabel.Location = new System.Drawing.Point(30, 94);
            empresaLabel.Name = "empresaLabel";
            empresaLabel.Size = new System.Drawing.Size(50, 13);
            empresaLabel.TabIndex = 20;
            empresaLabel.Text = "empresa:";
            // 
            // empresaTextBox
            // 
            this.empresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicioElectricidadBindingSource, "empresa", true));
            this.empresaTextBox.Location = new System.Drawing.Point(119, 91);
            this.empresaTextBox.Name = "empresaTextBox";
            this.empresaTextBox.Size = new System.Drawing.Size(200, 20);
            this.empresaTextBox.TabIndex = 21;
            // 
            // fechaInstaladoLabel
            // 
            fechaInstaladoLabel.AutoSize = true;
            fechaInstaladoLabel.Location = new System.Drawing.Point(30, 121);
            fechaInstaladoLabel.Name = "fechaInstaladoLabel";
            fechaInstaladoLabel.Size = new System.Drawing.Size(83, 13);
            fechaInstaladoLabel.TabIndex = 22;
            fechaInstaladoLabel.Text = "fecha Instalado:";
            // 
            // fechaInstaladoDateTimePicker
            // 
            this.fechaInstaladoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.servicioElectricidadBindingSource, "fechaInstalado", true));
            this.fechaInstaladoDateTimePicker.Location = new System.Drawing.Point(119, 117);
            this.fechaInstaladoDateTimePicker.Name = "fechaInstaladoDateTimePicker";
            this.fechaInstaladoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaInstaladoDateTimePicker.TabIndex = 23;
            // 
            // id_casaLabel
            // 
            id_casaLabel.AutoSize = true;
            id_casaLabel.Location = new System.Drawing.Point(30, 146);
            id_casaLabel.Name = "id_casaLabel";
            id_casaLabel.Size = new System.Drawing.Size(44, 13);
            id_casaLabel.TabIndex = 24;
            id_casaLabel.Text = "id casa:";
            // 
            // id_casaTextBox
            // 
            this.id_casaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicioElectricidadBindingSource, "id_casa", true));
            this.id_casaTextBox.Location = new System.Drawing.Point(119, 143);
            this.id_casaTextBox.Name = "id_casaTextBox";
            this.id_casaTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_casaTextBox.TabIndex = 25;
            // 
            // AddServicioLuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 286);
            this.Controls.Add(esTrifasicaLabel);
            this.Controls.Add(this.esTrifasicaCheckBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(empresaLabel);
            this.Controls.Add(this.empresaTextBox);
            this.Controls.Add(fechaInstaladoLabel);
            this.Controls.Add(this.fechaInstaladoDateTimePicker);
            this.Controls.Add(id_casaLabel);
            this.Controls.Add(this.id_casaTextBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.aceptarBtn);
            this.Name = "AddServicioLuz";
            this.Text = "Agregar servicio de luz";
            this.Load += new System.EventHandler(this.AddServicioLuz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElectricidadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button aceptarBtn;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource servicioElectricidadBindingSource;
        private DataSet1TableAdapters.servicioElectricidadTableAdapter servicioElectricidadTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox esTrifasicaCheckBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox empresaTextBox;
        private System.Windows.Forms.DateTimePicker fechaInstaladoDateTimePicker;
        private System.Windows.Forms.TextBox id_casaTextBox;
    }
}