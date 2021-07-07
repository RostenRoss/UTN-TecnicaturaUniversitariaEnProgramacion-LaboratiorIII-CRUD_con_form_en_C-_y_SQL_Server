
namespace CrudBarrioFrom.presentacion
{
    partial class AddMueble
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
            System.Windows.Forms.Label id_habitacionLabel;
            System.Windows.Forms.Label id_exteriorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMueble));
            this.dataSet1 = new CrudBarrioFrom.DataSet1();
            this.mueblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mueblesTableAdapter = new CrudBarrioFrom.DataSet1TableAdapters.mueblesTableAdapter();
            this.tableAdapterManager = new CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.id_habitacionTextBox = new System.Windows.Forms.TextBox();
            this.id_exteriorTextBox = new System.Windows.Forms.TextBox();
            nombreLabel = new System.Windows.Forms.Label();
            id_habitacionLabel = new System.Windows.Forms.Label();
            id_exteriorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mueblesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(52, 41);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 11;
            nombreLabel.Text = "nombre:";
            // 
            // id_habitacionLabel
            // 
            id_habitacionLabel.AutoSize = true;
            id_habitacionLabel.Location = new System.Drawing.Point(52, 67);
            id_habitacionLabel.Name = "id_habitacionLabel";
            id_habitacionLabel.Size = new System.Drawing.Size(70, 13);
            id_habitacionLabel.TabIndex = 13;
            id_habitacionLabel.Text = "id habitacion:";
            // 
            // id_exteriorLabel
            // 
            id_exteriorLabel.AutoSize = true;
            id_exteriorLabel.Location = new System.Drawing.Point(52, 93);
            id_exteriorLabel.Name = "id_exteriorLabel";
            id_exteriorLabel.Size = new System.Drawing.Size(55, 13);
            id_exteriorLabel.TabIndex = 15;
            id_exteriorLabel.Text = "id exterior:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mueblesBindingSource
            // 
            this.mueblesBindingSource.DataMember = "muebles";
            this.mueblesBindingSource.DataSource = this.dataSet1;
            // 
            // mueblesTableAdapter
            // 
            this.mueblesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.casasTableAdapter = null;
            this.tableAdapterManager.exteriorTableAdapter = null;
            this.tableAdapterManager.habitacionTableAdapter = null;
            this.tableAdapterManager.mascotaTableAdapter = null;
            this.tableAdapterManager.mueblesTableAdapter = this.mueblesTableAdapter;
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
            this.aceptarBtn.Location = new System.Drawing.Point(34, 138);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(75, 56);
            this.aceptarBtn.TabIndex = 8;
            this.aceptarBtn.UseVisualStyleBackColor = false;
            this.aceptarBtn.Click += new System.EventHandler(this.aceptarBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.LightCoral;
            this.cancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.BackgroundImage")));
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelBtn.Location = new System.Drawing.Point(168, 138);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 56);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mueblesBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(128, 38);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 12;
            // 
            // id_habitacionTextBox
            // 
            this.id_habitacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mueblesBindingSource, "id_habitacion", true));
            this.id_habitacionTextBox.Location = new System.Drawing.Point(128, 64);
            this.id_habitacionTextBox.Name = "id_habitacionTextBox";
            this.id_habitacionTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_habitacionTextBox.TabIndex = 14;
            // 
            // id_exteriorTextBox
            // 
            this.id_exteriorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mueblesBindingSource, "id_exterior", true));
            this.id_exteriorTextBox.Location = new System.Drawing.Point(128, 90);
            this.id_exteriorTextBox.Name = "id_exteriorTextBox";
            this.id_exteriorTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_exteriorTextBox.TabIndex = 16;
            // 
            // AddMueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 214);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(id_habitacionLabel);
            this.Controls.Add(this.id_habitacionTextBox);
            this.Controls.Add(id_exteriorLabel);
            this.Controls.Add(this.id_exteriorTextBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.aceptarBtn);
            this.Name = "AddMueble";
            this.Text = "Agregar mueble";
            this.Load += new System.EventHandler(this.AddMueble_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mueblesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource mueblesBindingSource;
        private DataSet1TableAdapters.mueblesTableAdapter mueblesTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button aceptarBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox id_habitacionTextBox;
        private System.Windows.Forms.TextBox id_exteriorTextBox;
    }
}