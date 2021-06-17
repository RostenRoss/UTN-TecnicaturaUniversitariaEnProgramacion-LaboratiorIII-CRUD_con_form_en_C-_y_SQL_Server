
namespace CrudBarrioFrom
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.casasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CrudBarrioFrom.DataSet1();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.agregarButton = new System.Windows.Forms.Button();
            this.mueblesBtn = new System.Windows.Forms.Button();
            this.interiorBtn = new System.Windows.Forms.Button();
            this.exteriorBtn = new System.Windows.Forms.Button();
            this.petBtn = new System.Windows.Forms.Button();
            this.servicesBtn = new System.Windows.Forms.Button();
            this.childrenBtn = new System.Windows.Forms.Button();
            this.casasDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.padresBtn = new System.Windows.Forms.Button();
            this.casasTableAdapter = new CrudBarrioFrom.DataSet1TableAdapters.casasTableAdapter();
            this.tableAdapterManager = new CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casasDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.casasDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(874, 460);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 0;
            // 
            // casasDataGridView
            // 
            this.casasDataGridView.AutoGenerateColumns = false;
            this.casasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.casasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.casasDataGridView.DataSource = this.casasBindingSource;
            this.casasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.casasDataGridView.Location = new System.Drawing.Point(0, 0);
            this.casasDataGridView.Name = "casasDataGridView";
            this.casasDataGridView.Size = new System.Drawing.Size(874, 236);
            this.casasDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "manzana";
            this.dataGridViewTextBoxColumn2.HeaderText = "manzana";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "parcela";
            this.dataGridViewTextBoxColumn3.HeaderText = "parcela";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "calle";
            this.dataGridViewTextBoxColumn4.HeaderText = "calle";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "altura";
            this.dataGridViewTextBoxColumn5.HeaderText = "altura";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // casasBindingSource
            // 
            this.casasBindingSource.DataMember = "casas";
            this.casasBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.splitContainer2.Panel2.Controls.Add(this.servicesBtn);
            this.splitContainer2.Panel2.Controls.Add(this.childrenBtn);
            this.splitContainer2.Panel2.Controls.Add(this.casasDataGridView1);
            this.splitContainer2.Panel2.Controls.Add(this.padresBtn);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(874, 460);
            this.splitContainer2.SplitterDistance = 63;
            this.splitContainer2.TabIndex = 2;
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
            this.agregarButton.Click += new System.EventHandler(this.agregarBtnClick);
            // 
            // mueblesBtn
            // 
            this.mueblesBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mueblesBtn.BackgroundImage")));
            this.mueblesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mueblesBtn.Location = new System.Drawing.Point(766, 336);
            this.mueblesBtn.Name = "mueblesBtn";
            this.mueblesBtn.Size = new System.Drawing.Size(75, 50);
            this.mueblesBtn.TabIndex = 7;
            this.mueblesBtn.UseVisualStyleBackColor = true;
            this.mueblesBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // interiorBtn
            // 
            this.interiorBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("interiorBtn.BackgroundImage")));
            this.interiorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.interiorBtn.Location = new System.Drawing.Point(768, 280);
            this.interiorBtn.Name = "interiorBtn";
            this.interiorBtn.Size = new System.Drawing.Size(75, 50);
            this.interiorBtn.TabIndex = 6;
            this.interiorBtn.UseVisualStyleBackColor = true;
            this.interiorBtn.Click += new System.EventHandler(this.interiorBtn_Click);
            // 
            // exteriorBtn
            // 
            this.exteriorBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exteriorBtn.BackgroundImage")));
            this.exteriorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exteriorBtn.Location = new System.Drawing.Point(768, 224);
            this.exteriorBtn.Name = "exteriorBtn";
            this.exteriorBtn.Size = new System.Drawing.Size(75, 50);
            this.exteriorBtn.TabIndex = 5;
            this.exteriorBtn.UseVisualStyleBackColor = true;
            this.exteriorBtn.Click += new System.EventHandler(this.exteriorBtn_Click);
            // 
            // petBtn
            // 
            this.petBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("petBtn.BackgroundImage")));
            this.petBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.petBtn.Location = new System.Drawing.Point(766, 168);
            this.petBtn.Name = "petBtn";
            this.petBtn.Size = new System.Drawing.Size(75, 50);
            this.petBtn.TabIndex = 4;
            this.petBtn.UseVisualStyleBackColor = true;
            this.petBtn.Click += new System.EventHandler(this.petBtn_Click);
            // 
            // servicesBtn
            // 
            this.servicesBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("servicesBtn.BackgroundImage")));
            this.servicesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.servicesBtn.Location = new System.Drawing.Point(768, 112);
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
            this.childrenBtn.Location = new System.Drawing.Point(768, 56);
            this.childrenBtn.Name = "childrenBtn";
            this.childrenBtn.Size = new System.Drawing.Size(73, 50);
            this.childrenBtn.TabIndex = 2;
            this.childrenBtn.UseVisualStyleBackColor = true;
            this.childrenBtn.Click += new System.EventHandler(this.children_Click);
            // 
            // casasDataGridView1
            // 
            this.casasDataGridView1.AutoGenerateColumns = false;
            this.casasDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.casasDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.casasDataGridView1.DataSource = this.casasBindingSource;
            this.casasDataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.casasDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.casasDataGridView1.Name = "casasDataGridView1";
            this.casasDataGridView1.Size = new System.Drawing.Size(718, 393);
            this.casasDataGridView1.TabIndex = 0;
            this.casasDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.casasDataGridView1_CellClick_1);
            this.casasDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.casasDataGridView1_CellContentClick);
            this.casasDataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.casasDataGridView1_CellPainting);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn6.HeaderText = "id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "manzana";
            this.dataGridViewTextBoxColumn7.HeaderText = "manzana";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "parcela";
            this.dataGridViewTextBoxColumn8.HeaderText = "parcela";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "calle";
            this.dataGridViewTextBoxColumn9.HeaderText = "calle";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "altura";
            this.dataGridViewTextBoxColumn10.HeaderText = "altura";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // padresBtn
            // 
            this.padresBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("padresBtn.BackgroundImage")));
            this.padresBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.padresBtn.Location = new System.Drawing.Point(768, 0);
            this.padresBtn.Name = "padresBtn";
            this.padresBtn.Size = new System.Drawing.Size(73, 50);
            this.padresBtn.TabIndex = 1;
            this.padresBtn.UseVisualStyleBackColor = true;
            this.padresBtn.Click += new System.EventHandler(this.padres_Click);
            // 
            // casasTableAdapter
            // 
            this.casasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.casasTableAdapter = this.casasTableAdapter;
            this.tableAdapterManager.exteriorTableAdapter = null;
            this.tableAdapterManager.habitacionTableAdapter = null;
            //this.tableAdapterManager.hijosTableAdapter = null;
            this.tableAdapterManager.mascotaTableAdapter = null;
            this.tableAdapterManager.mueblesTableAdapter = null;
            this.tableAdapterManager.padresTableAdapter = null;
            this.tableAdapterManager.servicioAguaTableAdapter = null;
            this.tableAdapterManager.servicioCableTableAdapter = null;
            this.tableAdapterManager.servicioElectricidadTableAdapter = null;
            this.tableAdapterManager.servicioInternetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 460);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.casasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.casasDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource casasBindingSource;
        private DataSet1TableAdapters.casasTableAdapter casasTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView casasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView casasDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.Button padresBtn;
        private System.Windows.Forms.Button servicesBtn;
        private System.Windows.Forms.Button childrenBtn;
        private System.Windows.Forms.Button exteriorBtn;
        private System.Windows.Forms.Button petBtn;
        private System.Windows.Forms.Button mueblesBtn;
        private System.Windows.Forms.Button interiorBtn;
    }
}

