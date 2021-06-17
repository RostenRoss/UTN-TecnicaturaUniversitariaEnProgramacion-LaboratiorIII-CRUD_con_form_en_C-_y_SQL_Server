
namespace CrudBarrioFrom.presentacion
{
    partial class AddHijo
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
            System.Windows.Forms.Label gradoEscuelaLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label edadLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label id_padreLabel;
            System.Windows.Forms.Label id_casaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHijo));
            this.dataSet1 = new CrudBarrioFrom.DataSet1();
            this.hijosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hijosTableAdapter = new CrudBarrioFrom.DataSet1TableAdapters.hijosTableAdapter();
            this.tableAdapterManager = new CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.gradoEscuelaTextBox = new System.Windows.Forms.TextBox();
            this.sexoCheckBox = new System.Windows.Forms.CheckBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_padreTextBox = new System.Windows.Forms.TextBox();
            this.id_casaTextBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.aceptarBtn = new System.Windows.Forms.Button();
            nombreLabel = new System.Windows.Forms.Label();
            gradoEscuelaLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            edadLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            id_padreLabel = new System.Windows.Forms.Label();
            id_casaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hijosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hijosBindingSource
            // 
            this.hijosBindingSource.DataMember = "hijos";
            this.hijosBindingSource.DataSource = this.dataSet1;
            // 
            // hijosTableAdapter
            // 
            this.hijosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.casasTableAdapter = null;
            this.tableAdapterManager.exteriorTableAdapter = null;
            this.tableAdapterManager.habitacionTableAdapter = null;
            //this.tableAdapterManager.hijosTableAdapter = this.hijosTableAdapter;
            this.tableAdapterManager.mascotaTableAdapter = null;
            this.tableAdapterManager.mueblesTableAdapter = null;
            this.tableAdapterManager.padresTableAdapter = null;
            this.tableAdapterManager.servicioAguaTableAdapter = null;
            this.tableAdapterManager.servicioCableTableAdapter = null;
            this.tableAdapterManager.servicioElectricidadTableAdapter = null;
            this.tableAdapterManager.servicioInternetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(25, 26);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hijosBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(124, 23);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // gradoEscuelaLabel
            // 
            gradoEscuelaLabel.AutoSize = true;
            gradoEscuelaLabel.Location = new System.Drawing.Point(25, 52);
            gradoEscuelaLabel.Name = "gradoEscuelaLabel";
            gradoEscuelaLabel.Size = new System.Drawing.Size(78, 13);
            gradoEscuelaLabel.TabIndex = 5;
            gradoEscuelaLabel.Text = "grado Escuela:";
            // 
            // gradoEscuelaTextBox
            // 
            this.gradoEscuelaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hijosBindingSource, "gradoEscuela", true));
            this.gradoEscuelaTextBox.Location = new System.Drawing.Point(124, 49);
            this.gradoEscuelaTextBox.Name = "gradoEscuelaTextBox";
            this.gradoEscuelaTextBox.Size = new System.Drawing.Size(200, 20);
            this.gradoEscuelaTextBox.TabIndex = 6;
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(25, 80);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(32, 13);
            sexoLabel.TabIndex = 7;
            sexoLabel.Text = "sexo:";
            // 
            // sexoCheckBox
            // 
            this.sexoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.hijosBindingSource, "sexo", true));
            this.sexoCheckBox.Location = new System.Drawing.Point(124, 75);
            this.sexoCheckBox.Name = "sexoCheckBox";
            this.sexoCheckBox.Size = new System.Drawing.Size(200, 24);
            this.sexoCheckBox.TabIndex = 8;
            this.sexoCheckBox.Text = "hombre/ mujer";
            this.sexoCheckBox.UseVisualStyleBackColor = true;
            // 
            // edadLabel
            // 
            edadLabel.AutoSize = true;
            edadLabel.Location = new System.Drawing.Point(25, 108);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new System.Drawing.Size(34, 13);
            edadLabel.TabIndex = 9;
            edadLabel.Text = "edad:";
            // 
            // edadTextBox
            // 
            this.edadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hijosBindingSource, "edad", true));
            this.edadTextBox.Location = new System.Drawing.Point(124, 105);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(200, 20);
            this.edadTextBox.TabIndex = 10;
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(25, 135);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(93, 13);
            fechaNacimientoLabel.TabIndex = 11;
            fechaNacimientoLabel.Text = "fecha Nacimiento:";
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hijosBindingSource, "fechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(124, 131);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 12;
            // 
            // id_padreLabel
            // 
            id_padreLabel.AutoSize = true;
            id_padreLabel.Location = new System.Drawing.Point(25, 160);
            id_padreLabel.Name = "id_padreLabel";
            id_padreLabel.Size = new System.Drawing.Size(48, 13);
            id_padreLabel.TabIndex = 13;
            id_padreLabel.Text = "id padre:";
            // 
            // id_padreTextBox
            // 
            this.id_padreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hijosBindingSource, "id_padre", true));
            this.id_padreTextBox.Location = new System.Drawing.Point(124, 157);
            this.id_padreTextBox.Name = "id_padreTextBox";
            this.id_padreTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_padreTextBox.TabIndex = 14;
            // 
            // id_casaLabel
            // 
            id_casaLabel.AutoSize = true;
            id_casaLabel.Location = new System.Drawing.Point(25, 186);
            id_casaLabel.Name = "id_casaLabel";
            id_casaLabel.Size = new System.Drawing.Size(44, 13);
            id_casaLabel.TabIndex = 15;
            id_casaLabel.Text = "id casa:";
            // 
            // id_casaTextBox
            // 
            this.id_casaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hijosBindingSource, "id_casa", true));
            this.id_casaTextBox.Location = new System.Drawing.Point(124, 183);
            this.id_casaTextBox.Name = "id_casaTextBox";
            this.id_casaTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_casaTextBox.TabIndex = 16;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.BackgroundImage")));
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelBtn.Location = new System.Drawing.Point(233, 227);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(62, 61);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.BackColor = System.Drawing.Color.Lime;
            this.aceptarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aceptarBtn.BackgroundImage")));
            this.aceptarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aceptarBtn.Location = new System.Drawing.Point(56, 227);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(62, 61);
            this.aceptarBtn.TabIndex = 18;
            this.aceptarBtn.UseVisualStyleBackColor = false;
            this.aceptarBtn.Click += new System.EventHandler(this.aceptarBtn_Click);
            // 
            // AddHijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 320);
            this.Controls.Add(this.aceptarBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(gradoEscuelaLabel);
            this.Controls.Add(this.gradoEscuelaTextBox);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoCheckBox);
            this.Controls.Add(edadLabel);
            this.Controls.Add(this.edadTextBox);
            this.Controls.Add(fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(id_padreLabel);
            this.Controls.Add(this.id_padreTextBox);
            this.Controls.Add(id_casaLabel);
            this.Controls.Add(this.id_casaTextBox);
            this.Name = "AddHijo";
            this.Text = "Agregar hijo";
            this.Load += new System.EventHandler(this.AddHijo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hijosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource hijosBindingSource;
        private DataSet1TableAdapters.hijosTableAdapter hijosTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox gradoEscuelaTextBox;
        private System.Windows.Forms.CheckBox sexoCheckBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.TextBox id_padreTextBox;
        private System.Windows.Forms.TextBox id_casaTextBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button aceptarBtn;
    }
}