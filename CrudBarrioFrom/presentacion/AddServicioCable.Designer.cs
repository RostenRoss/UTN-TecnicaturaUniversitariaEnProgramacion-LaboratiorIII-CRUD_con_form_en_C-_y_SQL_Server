
namespace CrudBarrioFrom.presentacion
{
    partial class AddServicioCable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServicioCable));
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label esHdLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label empresaLabel;
            System.Windows.Forms.Label limiteDeDatosLabel;
            System.Windows.Forms.Label fechaInstaladoLabel;
            System.Windows.Forms.Label id_casaLabel;
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.dataSet1 = new CrudBarrioFrom.DataSet1();
            this.servicioCableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicioCableTableAdapter = new CrudBarrioFrom.DataSet1TableAdapters.servicioCableTableAdapter();
            this.tableAdapterManager = new CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.esHdCheckBox = new System.Windows.Forms.CheckBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.empresaTextBox = new System.Windows.Forms.TextBox();
            this.limiteDeDatosTextBox = new System.Windows.Forms.TextBox();
            this.fechaInstaladoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_casaTextBox = new System.Windows.Forms.TextBox();
            tipoLabel = new System.Windows.Forms.Label();
            esHdLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            empresaLabel = new System.Windows.Forms.Label();
            limiteDeDatosLabel = new System.Windows.Forms.Label();
            fechaInstaladoLabel = new System.Windows.Forms.Label();
            id_casaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioCableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.aceptarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aceptarBtn.BackgroundImage")));
            this.aceptarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aceptarBtn.Location = new System.Drawing.Point(55, 230);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(75, 57);
            this.aceptarBtn.TabIndex = 10;
            this.aceptarBtn.UseVisualStyleBackColor = false;
            this.aceptarBtn.Click += new System.EventHandler(this.aceptarBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.LightCoral;
            this.cancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.BackgroundImage")));
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelBtn.Location = new System.Drawing.Point(232, 230);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 57);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicioCableBindingSource
            // 
            this.servicioCableBindingSource.DataMember = "servicioCable";
            this.servicioCableBindingSource.DataSource = this.dataSet1;
            // 
            // servicioCableTableAdapter
            // 
            this.servicioCableTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.servicioCableTableAdapter = this.servicioCableTableAdapter;
            this.tableAdapterManager.servicioElectricidadTableAdapter = null;
            this.tableAdapterManager.servicioInternetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(36, 27);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(27, 13);
            tipoLabel.TabIndex = 14;
            tipoLabel.Text = "tipo:";
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicioCableBindingSource, "tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(125, 24);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(200, 20);
            this.tipoTextBox.TabIndex = 15;
            // 
            // esHdLabel
            // 
            esHdLabel.AutoSize = true;
            esHdLabel.Location = new System.Drawing.Point(36, 55);
            esHdLabel.Name = "esHdLabel";
            esHdLabel.Size = new System.Drawing.Size(38, 13);
            esHdLabel.TabIndex = 16;
            esHdLabel.Text = "es Hd:";
            // 
            // esHdCheckBox
            // 
            this.esHdCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.servicioCableBindingSource, "esHd", true));
            this.esHdCheckBox.Location = new System.Drawing.Point(125, 50);
            this.esHdCheckBox.Name = "esHdCheckBox";
            this.esHdCheckBox.Size = new System.Drawing.Size(200, 24);
            this.esHdCheckBox.TabIndex = 17;
            this.esHdCheckBox.UseVisualStyleBackColor = true;
            this.esHdCheckBox.CheckedChanged += new System.EventHandler(this.esHdCheckBox_CheckedChanged);
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(36, 83);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(39, 13);
            precioLabel.TabIndex = 18;
            precioLabel.Text = "precio:";
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicioCableBindingSource, "precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(125, 80);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(200, 20);
            this.precioTextBox.TabIndex = 19;
            // 
            // empresaLabel
            // 
            empresaLabel.AutoSize = true;
            empresaLabel.Location = new System.Drawing.Point(36, 109);
            empresaLabel.Name = "empresaLabel";
            empresaLabel.Size = new System.Drawing.Size(50, 13);
            empresaLabel.TabIndex = 20;
            empresaLabel.Text = "empresa:";
            // 
            // empresaTextBox
            // 
            this.empresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicioCableBindingSource, "empresa", true));
            this.empresaTextBox.Location = new System.Drawing.Point(125, 106);
            this.empresaTextBox.Name = "empresaTextBox";
            this.empresaTextBox.Size = new System.Drawing.Size(200, 20);
            this.empresaTextBox.TabIndex = 21;
            // 
            // limiteDeDatosLabel
            // 
            limiteDeDatosLabel.AutoSize = true;
            limiteDeDatosLabel.Location = new System.Drawing.Point(36, 135);
            limiteDeDatosLabel.Name = "limiteDeDatosLabel";
            limiteDeDatosLabel.Size = new System.Drawing.Size(81, 13);
            limiteDeDatosLabel.TabIndex = 22;
            limiteDeDatosLabel.Text = "limite De Datos:";
            // 
            // limiteDeDatosTextBox
            // 
            this.limiteDeDatosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicioCableBindingSource, "limiteDeDatos", true));
            this.limiteDeDatosTextBox.Location = new System.Drawing.Point(125, 132);
            this.limiteDeDatosTextBox.Name = "limiteDeDatosTextBox";
            this.limiteDeDatosTextBox.Size = new System.Drawing.Size(200, 20);
            this.limiteDeDatosTextBox.TabIndex = 23;
            // 
            // fechaInstaladoLabel
            // 
            fechaInstaladoLabel.AutoSize = true;
            fechaInstaladoLabel.Location = new System.Drawing.Point(36, 162);
            fechaInstaladoLabel.Name = "fechaInstaladoLabel";
            fechaInstaladoLabel.Size = new System.Drawing.Size(83, 13);
            fechaInstaladoLabel.TabIndex = 24;
            fechaInstaladoLabel.Text = "fecha Instalado:";
            // 
            // fechaInstaladoDateTimePicker
            // 
            this.fechaInstaladoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.servicioCableBindingSource, "fechaInstalado", true));
            this.fechaInstaladoDateTimePicker.Location = new System.Drawing.Point(125, 158);
            this.fechaInstaladoDateTimePicker.Name = "fechaInstaladoDateTimePicker";
            this.fechaInstaladoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaInstaladoDateTimePicker.TabIndex = 25;
            // 
            // id_casaLabel
            // 
            id_casaLabel.AutoSize = true;
            id_casaLabel.Location = new System.Drawing.Point(36, 187);
            id_casaLabel.Name = "id_casaLabel";
            id_casaLabel.Size = new System.Drawing.Size(44, 13);
            id_casaLabel.TabIndex = 26;
            id_casaLabel.Text = "id casa:";
            // 
            // id_casaTextBox
            // 
            this.id_casaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicioCableBindingSource, "id_casa", true));
            this.id_casaTextBox.Location = new System.Drawing.Point(125, 184);
            this.id_casaTextBox.Name = "id_casaTextBox";
            this.id_casaTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_casaTextBox.TabIndex = 27;
            // 
            // AddServicioCable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 299);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(esHdLabel);
            this.Controls.Add(this.esHdCheckBox);
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
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.aceptarBtn);
            this.Name = "AddServicioCable";
            this.Text = "Agregar servicio de cable";
            this.Load += new System.EventHandler(this.AddServicioCable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioCableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aceptarBtn;
        private System.Windows.Forms.Button cancelBtn;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource servicioCableBindingSource;
        private DataSet1TableAdapters.servicioCableTableAdapter servicioCableTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.CheckBox esHdCheckBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox empresaTextBox;
        private System.Windows.Forms.TextBox limiteDeDatosTextBox;
        private System.Windows.Forms.DateTimePicker fechaInstaladoDateTimePicker;
        private System.Windows.Forms.TextBox id_casaTextBox;
    }
}