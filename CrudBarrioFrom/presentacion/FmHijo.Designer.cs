
namespace CrudBarrioFrom.presentacion
{
    partial class FmHijo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmHijo));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.agregarButton = new System.Windows.Forms.Button();
            this.hijosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hijosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CrudBarrioFrom.DataSet1();
            this.mueblesBtn = new System.Windows.Forms.Button();
            this.interiorBtn = new System.Windows.Forms.Button();
            this.exteriorBtn = new System.Windows.Forms.Button();
            this.petBtn = new System.Windows.Forms.Button();
            this.servicesBtn = new System.Windows.Forms.Button();
            this.padresBtn = new System.Windows.Forms.Button();
            this.casaBtn = new System.Windows.Forms.Button();
            this.hijosTableAdapter = new CrudBarrioFrom.DataSet1TableAdapters.hijosTableAdapter();
            this.tableAdapterManager = new CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hijosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hijosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.agregarButton);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.hijosDataGridView);
            this.splitContainer2.Panel2.Controls.Add(this.mueblesBtn);
            this.splitContainer2.Panel2.Controls.Add(this.interiorBtn);
            this.splitContainer2.Panel2.Controls.Add(this.exteriorBtn);
            this.splitContainer2.Panel2.Controls.Add(this.petBtn);
            this.splitContainer2.Panel2.Controls.Add(this.servicesBtn);
            this.splitContainer2.Panel2.Controls.Add(this.padresBtn);
            this.splitContainer2.Panel2.Controls.Add(this.casaBtn);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(1122, 466);
            this.splitContainer2.SplitterDistance = 64;
            this.splitContainer2.TabIndex = 4;
            // 
            // agregarButton
            // 
            this.agregarButton.BackColor = System.Drawing.Color.LightBlue;
            this.agregarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("agregarButton.BackgroundImage")));
            this.agregarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.agregarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.agregarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.agregarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.agregarButton.Location = new System.Drawing.Point(12, 3);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(60, 57);
            this.agregarButton.TabIndex = 0;
            this.agregarButton.Tag = "";
            this.agregarButton.UseVisualStyleBackColor = false;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // hijosDataGridView
            // 
            this.hijosDataGridView.AutoGenerateColumns = false;
            this.hijosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hijosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.hijosDataGridView.DataSource = this.hijosBindingSource;
            this.hijosDataGridView.Location = new System.Drawing.Point(0, 3);
            this.hijosDataGridView.Name = "hijosDataGridView";
            this.hijosDataGridView.Size = new System.Drawing.Size(1017, 392);
            this.hijosDataGridView.TabIndex = 11;
            this.hijosDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.hijosDataGridView_CellPainting);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn8.HeaderText = "id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn9.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "gradoEscuela";
            this.dataGridViewTextBoxColumn10.HeaderText = "gradoEscuela";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "sexo";
            this.dataGridViewCheckBoxColumn2.HeaderText = "sexo";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "edad";
            this.dataGridViewTextBoxColumn11.HeaderText = "edad";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "fechaNacimiento";
            this.dataGridViewTextBoxColumn12.HeaderText = "fechaNacimiento";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "id_padre";
            this.dataGridViewTextBoxColumn13.HeaderText = "id_padre";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "id_casa";
            this.dataGridViewTextBoxColumn14.HeaderText = "id_casa";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // hijosBindingSource
            // 
            this.hijosBindingSource.DataMember = "hijos";
            this.hijosBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mueblesBtn
            // 
            this.mueblesBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mueblesBtn.BackgroundImage")));
            this.mueblesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mueblesBtn.Location = new System.Drawing.Point(1035, 336);
            this.mueblesBtn.Name = "mueblesBtn";
            this.mueblesBtn.Size = new System.Drawing.Size(75, 50);
            this.mueblesBtn.TabIndex = 11;
            this.mueblesBtn.UseVisualStyleBackColor = true;
            this.mueblesBtn.Click += new System.EventHandler(this.mueblesBtn_Click);
            // 
            // interiorBtn
            // 
            this.interiorBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("interiorBtn.BackgroundImage")));
            this.interiorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.interiorBtn.Location = new System.Drawing.Point(1037, 280);
            this.interiorBtn.Name = "interiorBtn";
            this.interiorBtn.Size = new System.Drawing.Size(75, 50);
            this.interiorBtn.TabIndex = 10;
            this.interiorBtn.UseVisualStyleBackColor = true;
            this.interiorBtn.Click += new System.EventHandler(this.interiorBtn_Click);
            // 
            // exteriorBtn
            // 
            this.exteriorBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exteriorBtn.BackgroundImage")));
            this.exteriorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exteriorBtn.Location = new System.Drawing.Point(1037, 224);
            this.exteriorBtn.Name = "exteriorBtn";
            this.exteriorBtn.Size = new System.Drawing.Size(75, 50);
            this.exteriorBtn.TabIndex = 9;
            this.exteriorBtn.UseVisualStyleBackColor = true;
            this.exteriorBtn.Click += new System.EventHandler(this.exteriorBtn_Click);
            // 
            // petBtn
            // 
            this.petBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("petBtn.BackgroundImage")));
            this.petBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.petBtn.Location = new System.Drawing.Point(1035, 168);
            this.petBtn.Name = "petBtn";
            this.petBtn.Size = new System.Drawing.Size(75, 50);
            this.petBtn.TabIndex = 8;
            this.petBtn.UseVisualStyleBackColor = true;
            this.petBtn.Click += new System.EventHandler(this.petBtn_Click);
            // 
            // servicesBtn
            // 
            this.servicesBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("servicesBtn.BackgroundImage")));
            this.servicesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.servicesBtn.Location = new System.Drawing.Point(1037, 112);
            this.servicesBtn.Name = "servicesBtn";
            this.servicesBtn.Size = new System.Drawing.Size(73, 50);
            this.servicesBtn.TabIndex = 3;
            this.servicesBtn.UseVisualStyleBackColor = true;
            this.servicesBtn.Click += new System.EventHandler(this.services_Click);
            // 
            // padresBtn
            // 
            this.padresBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("padresBtn.BackgroundImage")));
            this.padresBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.padresBtn.Location = new System.Drawing.Point(1037, 56);
            this.padresBtn.Name = "padresBtn";
            this.padresBtn.Size = new System.Drawing.Size(73, 50);
            this.padresBtn.TabIndex = 2;
            this.padresBtn.UseVisualStyleBackColor = true;
            this.padresBtn.Click += new System.EventHandler(this.padres_Click);
            // 
            // casaBtn
            // 
            this.casaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("casaBtn.BackgroundImage")));
            this.casaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.casaBtn.Location = new System.Drawing.Point(1037, 0);
            this.casaBtn.Name = "casaBtn";
            this.casaBtn.Size = new System.Drawing.Size(73, 50);
            this.casaBtn.TabIndex = 1;
            this.casaBtn.UseVisualStyleBackColor = true;
            this.casaBtn.Click += new System.EventHandler(this.casas_Click);
            // 
            // hijosTableAdapter
            // 
            this.hijosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.casasTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.exteriorTableAdapter = null;
            this.tableAdapterManager.habitacionTableAdapter = null;
            this.tableAdapterManager.mascotaTableAdapter = null;
            this.tableAdapterManager.mueblesTableAdapter = null;
            this.tableAdapterManager.padresTableAdapter = null;
            this.tableAdapterManager.servicioAguaTableAdapter = null;
            this.tableAdapterManager.servicioCableTableAdapter = null;
            this.tableAdapterManager.servicioElectricidadTableAdapter = null;
            this.tableAdapterManager.servicioInternetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FmHijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 466);
            this.Controls.Add(this.splitContainer2);
            this.Name = "FmHijo";
            this.Text = "FmHijo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmHijo_FormClosing);
            this.Load += new System.EventHandler(this.FmHijo_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hijosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hijosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.Button servicesBtn;
        private System.Windows.Forms.Button padresBtn;
        private System.Windows.Forms.Button casaBtn;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource hijosBindingSource;
        private DataSet1TableAdapters.hijosTableAdapter hijosTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button mueblesBtn;
        private System.Windows.Forms.Button interiorBtn;
        private System.Windows.Forms.Button exteriorBtn;
        private System.Windows.Forms.Button petBtn;
        private System.Windows.Forms.DataGridView hijosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}