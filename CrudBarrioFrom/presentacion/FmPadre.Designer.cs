
namespace CrudBarrioFrom.presentacion
{
    partial class FmPadre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmPadre));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.agregarButton = new System.Windows.Forms.Button();
            this.mueblesBtn = new System.Windows.Forms.Button();
            this.interiorBtn = new System.Windows.Forms.Button();
            this.exteriorBtn = new System.Windows.Forms.Button();
            this.petBtn = new System.Windows.Forms.Button();
            this.padresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.padresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CrudBarrioFrom.DataSet1();
            this.servicesBtn = new System.Windows.Forms.Button();
            this.childrenBtn = new System.Windows.Forms.Button();
            this.casasBtn = new System.Windows.Forms.Button();
            this.padresTableAdapter = new CrudBarrioFrom.DataSet1TableAdapters.padresTableAdapter();
            this.tableAdapterManager = new CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.padresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padresBindingSource)).BeginInit();
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
            this.splitContainer2.Panel2.Controls.Add(this.mueblesBtn);
            this.splitContainer2.Panel2.Controls.Add(this.interiorBtn);
            this.splitContainer2.Panel2.Controls.Add(this.exteriorBtn);
            this.splitContainer2.Panel2.Controls.Add(this.petBtn);
            this.splitContainer2.Panel2.Controls.Add(this.padresDataGridView);
            this.splitContainer2.Panel2.Controls.Add(this.servicesBtn);
            this.splitContainer2.Panel2.Controls.Add(this.childrenBtn);
            this.splitContainer2.Panel2.Controls.Add(this.casasBtn);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(1042, 464);
            this.splitContainer2.SplitterDistance = 63;
            this.splitContainer2.TabIndex = 3;
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
            // mueblesBtn
            // 
            this.mueblesBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mueblesBtn.BackgroundImage")));
            this.mueblesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mueblesBtn.Location = new System.Drawing.Point(946, 339);
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
            this.interiorBtn.Location = new System.Drawing.Point(948, 283);
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
            this.exteriorBtn.Location = new System.Drawing.Point(948, 227);
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
            this.petBtn.Location = new System.Drawing.Point(946, 171);
            this.petBtn.Name = "petBtn";
            this.petBtn.Size = new System.Drawing.Size(75, 50);
            this.petBtn.TabIndex = 8;
            this.petBtn.UseVisualStyleBackColor = true;
            this.petBtn.Click += new System.EventHandler(this.petBtn_Click);
            // 
            // padresDataGridView
            // 
            this.padresDataGridView.AutoGenerateColumns = false;
            this.padresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.padresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.padresDataGridView.DataSource = this.padresBindingSource;
            this.padresDataGridView.Location = new System.Drawing.Point(3, 0);
            this.padresDataGridView.Name = "padresDataGridView";
            this.padresDataGridView.Size = new System.Drawing.Size(918, 397);
            this.padresDataGridView.TabIndex = 3;
            this.padresDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.padresDataGridView_CellClick);
            this.padresDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.padresDataGridView_CellContentClick);
            this.padresDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.padresDataGridView_CellPainting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "sexo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "sexo";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "edad";
            this.dataGridViewTextBoxColumn3.HeaderText = "edad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fechaNacimiento";
            this.dataGridViewTextBoxColumn4.HeaderText = "fechaNacimiento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "trabajo";
            this.dataGridViewTextBoxColumn5.HeaderText = "trabajo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_casa";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_casa";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // padresBindingSource
            // 
            this.padresBindingSource.DataMember = "padres";
            this.padresBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicesBtn
            // 
            this.servicesBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("servicesBtn.BackgroundImage")));
            this.servicesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.servicesBtn.Location = new System.Drawing.Point(948, 115);
            this.servicesBtn.Name = "servicesBtn";
            this.servicesBtn.Size = new System.Drawing.Size(73, 50);
            this.servicesBtn.TabIndex = 3;
            this.servicesBtn.UseVisualStyleBackColor = true;
            this.servicesBtn.Click += new System.EventHandler(this.services_Click);
            // 
            // childrenBtn
            // 
            this.childrenBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("childrenBtn.BackgroundImage")));
            this.childrenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.childrenBtn.Location = new System.Drawing.Point(948, 59);
            this.childrenBtn.Name = "childrenBtn";
            this.childrenBtn.Size = new System.Drawing.Size(73, 50);
            this.childrenBtn.TabIndex = 2;
            this.childrenBtn.UseVisualStyleBackColor = true;
            this.childrenBtn.Click += new System.EventHandler(this.children_Click);
            // 
            // casasBtn
            // 
            this.casasBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("casasBtn.BackgroundImage")));
            this.casasBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.casasBtn.Location = new System.Drawing.Point(948, 3);
            this.casasBtn.Name = "casasBtn";
            this.casasBtn.Size = new System.Drawing.Size(73, 50);
            this.casasBtn.TabIndex = 1;
            this.casasBtn.UseVisualStyleBackColor = true;
            this.casasBtn.Click += new System.EventHandler(this.casaClick);
            // 
            // padresTableAdapter
            // 
            this.padresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.casasTableAdapter = null;
            this.tableAdapterManager.exteriorTableAdapter = null;
            this.tableAdapterManager.habitacionTableAdapter = null;
            //this.tableAdapterManager.hijosTableAdapter = null;
            this.tableAdapterManager.mascotaTableAdapter = null;
            this.tableAdapterManager.mueblesTableAdapter = null;
            this.tableAdapterManager.padresTableAdapter = this.padresTableAdapter;
            this.tableAdapterManager.servicioAguaTableAdapter = null;
            this.tableAdapterManager.servicioCableTableAdapter = null;
            this.tableAdapterManager.servicioElectricidadTableAdapter = null;
            this.tableAdapterManager.servicioInternetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FmPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 464);
            this.Controls.Add(this.splitContainer2);
            this.Name = "FmPadre";
            this.Text = "FmPadre";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmPadre_FormClosing);
            this.Load += new System.EventHandler(this.FmPadre_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.padresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.Button servicesBtn;
        private System.Windows.Forms.Button childrenBtn;
        private System.Windows.Forms.Button casasBtn;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource padresBindingSource;
        private DataSet1TableAdapters.padresTableAdapter padresTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView padresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button mueblesBtn;
        private System.Windows.Forms.Button interiorBtn;
        private System.Windows.Forms.Button exteriorBtn;
        private System.Windows.Forms.Button petBtn;
    }
}