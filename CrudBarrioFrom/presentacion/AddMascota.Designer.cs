
namespace CrudBarrioFrom.presentacion
{
    partial class AddMascota
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
            System.Windows.Forms.Label familiaLabel;
            System.Windows.Forms.Label dietaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label edadLabel;
            System.Windows.Forms.Label id_casaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMascota));
            this.dataSet1 = new CrudBarrioFrom.DataSet1();
            this.mascotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mascotaTableAdapter = new CrudBarrioFrom.DataSet1TableAdapters.mascotaTableAdapter();
            this.tableAdapterManager = new CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager();
            this.familiaTextBox = new System.Windows.Forms.TextBox();
            this.dietaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.id_casaTextBox = new System.Windows.Forms.TextBox();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            familiaLabel = new System.Windows.Forms.Label();
            dietaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            edadLabel = new System.Windows.Forms.Label();
            id_casaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mascotaBindingSource
            // 
            this.mascotaBindingSource.DataMember = "mascota";
            this.mascotaBindingSource.DataSource = this.dataSet1;
            // 
            // mascotaTableAdapter
            // 
            this.mascotaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.casasTableAdapter = null;
            this.tableAdapterManager.exteriorTableAdapter = null;
            this.tableAdapterManager.habitacionTableAdapter = null;
            //this.tableAdapterManager.hijosTableAdapter = null;
            this.tableAdapterManager.mascotaTableAdapter = this.mascotaTableAdapter;
            this.tableAdapterManager.mueblesTableAdapter = null;
            this.tableAdapterManager.padresTableAdapter = null;
            this.tableAdapterManager.servicioAguaTableAdapter = null;
            this.tableAdapterManager.servicioCableTableAdapter = null;
            this.tableAdapterManager.servicioElectricidadTableAdapter = null;
            this.tableAdapterManager.servicioInternetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // familiaLabel
            // 
            familiaLabel.AutoSize = true;
            familiaLabel.Location = new System.Drawing.Point(30, 37);
            familiaLabel.Name = "familiaLabel";
            familiaLabel.Size = new System.Drawing.Size(39, 13);
            familiaLabel.TabIndex = 3;
            familiaLabel.Text = "familia:";
            // 
            // familiaTextBox
            // 
            this.familiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mascotaBindingSource, "familia", true));
            this.familiaTextBox.Location = new System.Drawing.Point(142, 34);
            this.familiaTextBox.Name = "familiaTextBox";
            this.familiaTextBox.Size = new System.Drawing.Size(100, 20);
            this.familiaTextBox.TabIndex = 4;
            // 
            // dietaLabel
            // 
            dietaLabel.AutoSize = true;
            dietaLabel.Location = new System.Drawing.Point(30, 63);
            dietaLabel.Name = "dietaLabel";
            dietaLabel.Size = new System.Drawing.Size(33, 13);
            dietaLabel.TabIndex = 5;
            dietaLabel.Text = "dieta:";
            // 
            // dietaTextBox
            // 
            this.dietaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mascotaBindingSource, "dieta", true));
            this.dietaTextBox.Location = new System.Drawing.Point(142, 60);
            this.dietaTextBox.Name = "dietaTextBox";
            this.dietaTextBox.Size = new System.Drawing.Size(100, 20);
            this.dietaTextBox.TabIndex = 6;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(30, 89);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mascotaBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(142, 86);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 8;
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(30, 115);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(27, 13);
            tipoLabel.TabIndex = 9;
            tipoLabel.Text = "tipo:";
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mascotaBindingSource, "tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(142, 112);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(100, 20);
            this.tipoTextBox.TabIndex = 10;
            // 
            // edadLabel
            // 
            edadLabel.AutoSize = true;
            edadLabel.Location = new System.Drawing.Point(30, 141);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new System.Drawing.Size(34, 13);
            edadLabel.TabIndex = 11;
            edadLabel.Text = "edad:";
            // 
            // edadTextBox
            // 
            this.edadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mascotaBindingSource, "edad", true));
            this.edadTextBox.Location = new System.Drawing.Point(142, 138);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(100, 20);
            this.edadTextBox.TabIndex = 12;
            // 
            // id_casaLabel
            // 
            id_casaLabel.AutoSize = true;
            id_casaLabel.Location = new System.Drawing.Point(30, 167);
            id_casaLabel.Name = "id_casaLabel";
            id_casaLabel.Size = new System.Drawing.Size(44, 13);
            id_casaLabel.TabIndex = 13;
            id_casaLabel.Text = "id casa:";
            // 
            // id_casaTextBox
            // 
            this.id_casaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mascotaBindingSource, "id_casa", true));
            this.id_casaTextBox.Location = new System.Drawing.Point(142, 164);
            this.id_casaTextBox.Name = "id_casaTextBox";
            this.id_casaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_casaTextBox.TabIndex = 14;
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.aceptarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aceptarBtn.BackgroundImage")));
            this.aceptarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aceptarBtn.Location = new System.Drawing.Point(33, 206);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(75, 64);
            this.aceptarBtn.TabIndex = 15;
            this.aceptarBtn.UseVisualStyleBackColor = false;
            this.aceptarBtn.Click += new System.EventHandler(this.aceptarBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.LightCoral;
            this.cancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.BackgroundImage")));
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelBtn.Location = new System.Drawing.Point(167, 206);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 64);
            this.cancelBtn.TabIndex = 16;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 282);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.aceptarBtn);
            this.Controls.Add(familiaLabel);
            this.Controls.Add(this.familiaTextBox);
            this.Controls.Add(dietaLabel);
            this.Controls.Add(this.dietaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(edadLabel);
            this.Controls.Add(this.edadTextBox);
            this.Controls.Add(id_casaLabel);
            this.Controls.Add(this.id_casaTextBox);
            this.Name = "AddMascota";
            this.Text = "AddHabitacion";
            this.Load += new System.EventHandler(this.AddMascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource mascotaBindingSource;
        private DataSet1TableAdapters.mascotaTableAdapter mascotaTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox familiaTextBox;
        private System.Windows.Forms.TextBox dietaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.TextBox id_casaTextBox;
        private System.Windows.Forms.Button aceptarBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}