
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
            System.Windows.Forms.Label id_lugarLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMueble));
            this.dataSet1 = new CrudBarrioFrom.DataSet1();
            this.mueblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mueblesTableAdapter = new CrudBarrioFrom.DataSet1TableAdapters.mueblesTableAdapter();
            this.tableAdapterManager = new CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.id_lugarTextBox = new System.Windows.Forms.TextBox();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            nombreLabel = new System.Windows.Forms.Label();
            id_lugarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mueblesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(32, 48);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "nombre:";
            // 
            // id_lugarLabel
            // 
            id_lugarLabel.AutoSize = true;
            id_lugarLabel.Location = new System.Drawing.Point(32, 81);
            id_lugarLabel.Name = "id_lugarLabel";
            id_lugarLabel.Size = new System.Drawing.Size(44, 13);
            id_lugarLabel.TabIndex = 5;
            id_lugarLabel.Text = "id lugar:";
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
            //this.tableAdapterManager.hijosTableAdapter = null;
            this.tableAdapterManager.mascotaTableAdapter = null;
            this.tableAdapterManager.mueblesTableAdapter = this.mueblesTableAdapter;
            this.tableAdapterManager.padresTableAdapter = null;
            this.tableAdapterManager.servicioAguaTableAdapter = null;
            this.tableAdapterManager.servicioCableTableAdapter = null;
            this.tableAdapterManager.servicioElectricidadTableAdapter = null;
            this.tableAdapterManager.servicioInternetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mueblesBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(143, 48);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // id_lugarTextBox
            // 
            this.id_lugarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mueblesBindingSource, "id_lugar", true));
            this.id_lugarTextBox.Location = new System.Drawing.Point(143, 74);
            this.id_lugarTextBox.Name = "id_lugarTextBox";
            this.id_lugarTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_lugarTextBox.TabIndex = 6;
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
            // 
            // AddMueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 206);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.aceptarBtn);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(id_lugarLabel);
            this.Controls.Add(this.id_lugarTextBox);
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
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox id_lugarTextBox;
        private System.Windows.Forms.Button aceptarBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}