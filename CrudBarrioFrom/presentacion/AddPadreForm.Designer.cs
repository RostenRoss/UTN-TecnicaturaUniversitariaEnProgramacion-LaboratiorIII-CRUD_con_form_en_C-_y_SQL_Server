
namespace CrudBarrioFrom.presentacion
{
    partial class AddPadreForm
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label edadLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label trabajoLabel;
            System.Windows.Forms.Label id_casaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPadreForm));
            this.dataSet1 = new CrudBarrioFrom.DataSet1();
            this.padresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.padresTableAdapter1 = new CrudBarrioFrom.DataSet1TableAdapters.padresTableAdapter();
            this.tableAdapterManager1 = new CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.sexoCheckBox = new System.Windows.Forms.CheckBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.trabajoTextBox = new System.Windows.Forms.TextBox();
            this.id_casaTextBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.aceptarBtn = new System.Windows.Forms.Button();
            nombreLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            edadLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            trabajoLabel = new System.Windows.Forms.Label();
            id_casaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padresBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(46, 28);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "nombre:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(46, 56);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(53, 13);
            sexoLabel.TabIndex = 4;
            sexoLabel.Text = "femenino:";
            // 
            // edadLabel
            // 
            edadLabel.AutoSize = true;
            edadLabel.Location = new System.Drawing.Point(46, 84);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new System.Drawing.Size(34, 13);
            edadLabel.TabIndex = 6;
            edadLabel.Text = "edad:";
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(46, 111);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(93, 13);
            fechaNacimientoLabel.TabIndex = 8;
            fechaNacimientoLabel.Text = "fecha Nacimiento:";
            // 
            // trabajoLabel
            // 
            trabajoLabel.AutoSize = true;
            trabajoLabel.Location = new System.Drawing.Point(46, 136);
            trabajoLabel.Name = "trabajoLabel";
            trabajoLabel.Size = new System.Drawing.Size(42, 13);
            trabajoLabel.TabIndex = 10;
            trabajoLabel.Text = "trabajo:";
            // 
            // id_casaLabel
            // 
            id_casaLabel.AutoSize = true;
            id_casaLabel.Location = new System.Drawing.Point(46, 162);
            id_casaLabel.Name = "id_casaLabel";
            id_casaLabel.Size = new System.Drawing.Size(44, 13);
            id_casaLabel.TabIndex = 12;
            id_casaLabel.Text = "id casa:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // padresBindingSource1
            // 
            this.padresBindingSource1.DataMember = "padres";
            this.padresBindingSource1.DataSource = this.dataSet1;
            // 
            // padresTableAdapter1
            // 
            this.padresTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.casasTableAdapter = null;
            this.tableAdapterManager1.exteriorTableAdapter = null;
            this.tableAdapterManager1.habitacionTableAdapter = null;
            this.tableAdapterManager1.mascotaTableAdapter = null;
            this.tableAdapterManager1.mueblesTableAdapter = null;
            this.tableAdapterManager1.padresTableAdapter = this.padresTableAdapter1;
            this.tableAdapterManager1.servicioAguaTableAdapter = null;
            this.tableAdapterManager1.servicioCableTableAdapter = null;
            this.tableAdapterManager1.servicioElectricidadTableAdapter = null;
            this.tableAdapterManager1.servicioInternetTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.padresBindingSource1, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(145, 25);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 3;
            // 
            // sexoCheckBox
            // 
            this.sexoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.padresBindingSource1, "sexo", true));
            this.sexoCheckBox.Location = new System.Drawing.Point(145, 51);
            this.sexoCheckBox.Name = "sexoCheckBox";
            this.sexoCheckBox.Size = new System.Drawing.Size(200, 24);
            this.sexoCheckBox.TabIndex = 5;
            this.sexoCheckBox.UseVisualStyleBackColor = true;
            // 
            // edadTextBox
            // 
            this.edadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.padresBindingSource1, "edad", true));
            this.edadTextBox.Location = new System.Drawing.Point(145, 81);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(200, 20);
            this.edadTextBox.TabIndex = 7;
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.padresBindingSource1, "fechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(145, 107);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 9;
            // 
            // trabajoTextBox
            // 
            this.trabajoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.padresBindingSource1, "trabajo", true));
            this.trabajoTextBox.Location = new System.Drawing.Point(145, 133);
            this.trabajoTextBox.Name = "trabajoTextBox";
            this.trabajoTextBox.Size = new System.Drawing.Size(200, 20);
            this.trabajoTextBox.TabIndex = 11;
            // 
            // id_casaTextBox
            // 
            this.id_casaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.padresBindingSource1, "id_casa", true));
            this.id_casaTextBox.Location = new System.Drawing.Point(145, 159);
            this.id_casaTextBox.Name = "id_casaTextBox";
            this.id_casaTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_casaTextBox.TabIndex = 13;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Tomato;
            this.cancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.BackgroundImage")));
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelBtn.Location = new System.Drawing.Point(251, 205);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(61, 53);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.aceptarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aceptarBtn.BackgroundImage")));
            this.aceptarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aceptarBtn.Location = new System.Drawing.Point(78, 205);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(61, 53);
            this.aceptarBtn.TabIndex = 15;
            this.aceptarBtn.UseVisualStyleBackColor = false;
            this.aceptarBtn.Click += new System.EventHandler(this.aceptarBtn_Click);
            // 
            // AddPadreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 288);
            this.Controls.Add(this.aceptarBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoCheckBox);
            this.Controls.Add(edadLabel);
            this.Controls.Add(this.edadTextBox);
            this.Controls.Add(fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(trabajoLabel);
            this.Controls.Add(this.trabajoTextBox);
            this.Controls.Add(id_casaLabel);
            this.Controls.Add(this.id_casaTextBox);
            this.Name = "AddPadreForm";
            this.Text = "Agregar padre";
            this.Load += new System.EventHandler(this.AddPadreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padresBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource padresBindingSource1;
        private DataSet1TableAdapters.padresTableAdapter padresTableAdapter1;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.CheckBox sexoCheckBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.TextBox trabajoTextBox;
        private System.Windows.Forms.TextBox id_casaTextBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button aceptarBtn;
    }
}