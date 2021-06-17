
namespace CrudBarrioFrom.presentacion
{
    partial class AddExterior
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExterior));
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label metrosCuadradosLabel;
            System.Windows.Forms.Label id_casaLabel;
            this.dataSet1 = new CrudBarrioFrom.DataSet1();
            this.exteriorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exteriorTableAdapter = new CrudBarrioFrom.DataSet1TableAdapters.exteriorTableAdapter();
            this.tableAdapterManager = new CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.metrosCuadradosTextBox = new System.Windows.Forms.TextBox();
            this.id_casaTextBox = new System.Windows.Forms.TextBox();
            tipoLabel = new System.Windows.Forms.Label();
            metrosCuadradosLabel = new System.Windows.Forms.Label();
            id_casaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exteriorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exteriorBindingSource
            // 
            this.exteriorBindingSource.DataMember = "Exterior";
            this.exteriorBindingSource.DataSource = this.dataSet1;
            // 
            // exteriorTableAdapter
            // 
            this.exteriorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.casasTableAdapter = null;
            this.tableAdapterManager.exteriorTableAdapter = this.exteriorTableAdapter;
            this.tableAdapterManager.habitacionTableAdapter = null;
           // this.tableAdapterManager.hijosTableAdapter = null;
            this.tableAdapterManager.mascotaTableAdapter = null;
            this.tableAdapterManager.mueblesTableAdapter = null;
            this.tableAdapterManager.padresTableAdapter = null;
            this.tableAdapterManager.servicioAguaTableAdapter = null;
            this.tableAdapterManager.servicioCableTableAdapter = null;
            this.tableAdapterManager.servicioElectricidadTableAdapter = null;
            this.tableAdapterManager.servicioInternetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.aceptarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aceptarBtn.BackgroundImage")));
            this.aceptarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aceptarBtn.Location = new System.Drawing.Point(28, 150);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(69, 76);
            this.aceptarBtn.TabIndex = 9;
            this.aceptarBtn.UseVisualStyleBackColor = false;
            this.aceptarBtn.Click += new System.EventHandler(this.aceptarBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.LightCoral;
            this.cancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.BackgroundImage")));
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelBtn.Location = new System.Drawing.Point(157, 150);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(69, 76);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(25, 57);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(27, 13);
            tipoLabel.TabIndex = 12;
            tipoLabel.Text = "tipo:";
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exteriorBindingSource, "tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(126, 54);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(100, 20);
            this.tipoTextBox.TabIndex = 13;
            // 
            // metrosCuadradosLabel
            // 
            metrosCuadradosLabel.AutoSize = true;
            metrosCuadradosLabel.Location = new System.Drawing.Point(25, 83);
            metrosCuadradosLabel.Name = "metrosCuadradosLabel";
            metrosCuadradosLabel.Size = new System.Drawing.Size(95, 13);
            metrosCuadradosLabel.TabIndex = 14;
            metrosCuadradosLabel.Text = "metros Cuadrados:";
            // 
            // metrosCuadradosTextBox
            // 
            this.metrosCuadradosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exteriorBindingSource, "metrosCuadrados", true));
            this.metrosCuadradosTextBox.Location = new System.Drawing.Point(126, 80);
            this.metrosCuadradosTextBox.Name = "metrosCuadradosTextBox";
            this.metrosCuadradosTextBox.Size = new System.Drawing.Size(100, 20);
            this.metrosCuadradosTextBox.TabIndex = 15;
            // 
            // id_casaLabel
            // 
            id_casaLabel.AutoSize = true;
            id_casaLabel.Location = new System.Drawing.Point(25, 109);
            id_casaLabel.Name = "id_casaLabel";
            id_casaLabel.Size = new System.Drawing.Size(44, 13);
            id_casaLabel.TabIndex = 16;
            id_casaLabel.Text = "id casa:";
            // 
            // id_casaTextBox
            // 
            this.id_casaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exteriorBindingSource, "id_casa", true));
            this.id_casaTextBox.Location = new System.Drawing.Point(126, 106);
            this.id_casaTextBox.Name = "id_casaTextBox";
            this.id_casaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_casaTextBox.TabIndex = 17;
            // 
            // AddExterior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 254);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(metrosCuadradosLabel);
            this.Controls.Add(this.metrosCuadradosTextBox);
            this.Controls.Add(id_casaLabel);
            this.Controls.Add(this.id_casaTextBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.aceptarBtn);
            this.Name = "AddExterior";
            this.Text = "Agregar exterior";
            this.Load += new System.EventHandler(this.AddExterior_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exteriorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource exteriorBindingSource;
        private DataSet1TableAdapters.exteriorTableAdapter exteriorTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button aceptarBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.TextBox metrosCuadradosTextBox;
        private System.Windows.Forms.TextBox id_casaTextBox;
    }
}