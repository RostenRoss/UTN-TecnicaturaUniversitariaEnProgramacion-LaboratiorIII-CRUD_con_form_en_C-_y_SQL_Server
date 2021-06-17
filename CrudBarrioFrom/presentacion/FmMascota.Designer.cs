
namespace CrudBarrioFrom.presentacion
{
    partial class FmMascota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMascota));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.agregarButton = new System.Windows.Forms.Button();
            this.mueblesBtn = new System.Windows.Forms.Button();
            this.interiorBtn = new System.Windows.Forms.Button();
            this.exteriorBtn = new System.Windows.Forms.Button();
            this.padresBtn = new System.Windows.Forms.Button();
            this.mascotaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mascotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CrudBarrioFrom.DataSet1();
            this.servicesBtb = new System.Windows.Forms.Button();
            this.childrenBtn = new System.Windows.Forms.Button();
            this.casasBtn = new System.Windows.Forms.Button();
            this.mascotaTableAdapter = new CrudBarrioFrom.DataSet1TableAdapters.mascotaTableAdapter();
            this.tableAdapterManager = new CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mascotaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotaBindingSource)).BeginInit();
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
            this.splitContainer2.Panel2.Controls.Add(this.padresBtn);
            this.splitContainer2.Panel2.Controls.Add(this.mascotaDataGridView);
            this.splitContainer2.Panel2.Controls.Add(this.servicesBtb);
            this.splitContainer2.Panel2.Controls.Add(this.childrenBtn);
            this.splitContainer2.Panel2.Controls.Add(this.casasBtn);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(1042, 464);
            this.splitContainer2.SplitterDistance = 63;
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
            // 
            // mueblesBtn
            // 
            this.mueblesBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mueblesBtn.BackgroundImage")));
            this.mueblesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mueblesBtn.Location = new System.Drawing.Point(931, 337);
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
            this.interiorBtn.Location = new System.Drawing.Point(933, 281);
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
            this.exteriorBtn.Location = new System.Drawing.Point(933, 225);
            this.exteriorBtn.Name = "exteriorBtn";
            this.exteriorBtn.Size = new System.Drawing.Size(75, 50);
            this.exteriorBtn.TabIndex = 9;
            this.exteriorBtn.UseVisualStyleBackColor = true;
            this.exteriorBtn.Click += new System.EventHandler(this.exteriorBtn_Click);
            // 
            // padresBtn
            // 
            this.padresBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("padresBtn.BackgroundImage")));
            this.padresBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.padresBtn.Location = new System.Drawing.Point(931, 57);
            this.padresBtn.Name = "padresBtn";
            this.padresBtn.Size = new System.Drawing.Size(75, 50);
            this.padresBtn.TabIndex = 8;
            this.padresBtn.UseVisualStyleBackColor = true;
            this.padresBtn.Click += new System.EventHandler(this.padresBtn_Click);
            // 
            // mascotaDataGridView
            // 
            this.mascotaDataGridView.AutoGenerateColumns = false;
            this.mascotaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mascotaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.mascotaDataGridView.DataSource = this.mascotaBindingSource;
            this.mascotaDataGridView.Location = new System.Drawing.Point(0, -1);
            this.mascotaDataGridView.Name = "mascotaDataGridView";
            this.mascotaDataGridView.Size = new System.Drawing.Size(890, 394);
            this.mascotaDataGridView.TabIndex = 3;
            this.mascotaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mascotaDataGridView_CellClick);
            this.mascotaDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.mascotaDataGridView_CellPainting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "familia";
            this.dataGridViewTextBoxColumn2.HeaderText = "familia";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dieta";
            this.dataGridViewTextBoxColumn3.HeaderText = "dieta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn4.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tipo";
            this.dataGridViewTextBoxColumn5.HeaderText = "tipo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "edad";
            this.dataGridViewTextBoxColumn6.HeaderText = "edad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id_casa";
            this.dataGridViewTextBoxColumn7.HeaderText = "id_casa";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // mascotaBindingSource
            // 
            this.mascotaBindingSource.DataMember = "mascota";
            this.mascotaBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicesBtb
            // 
            this.servicesBtb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("servicesBtb.BackgroundImage")));
            this.servicesBtb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.servicesBtb.Location = new System.Drawing.Point(933, 169);
            this.servicesBtb.Name = "servicesBtb";
            this.servicesBtb.Size = new System.Drawing.Size(73, 50);
            this.servicesBtb.TabIndex = 3;
            this.servicesBtb.UseVisualStyleBackColor = true;
            this.servicesBtb.Click += new System.EventHandler(this.servicesBtb_Click);
            // 
            // childrenBtn
            // 
            this.childrenBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("childrenBtn.BackgroundImage")));
            this.childrenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.childrenBtn.Location = new System.Drawing.Point(931, 113);
            this.childrenBtn.Name = "childrenBtn";
            this.childrenBtn.Size = new System.Drawing.Size(73, 50);
            this.childrenBtn.TabIndex = 2;
            this.childrenBtn.UseVisualStyleBackColor = true;
            this.childrenBtn.Click += new System.EventHandler(this.childrenBtn_Click);
            // 
            // casasBtn
            // 
            this.casasBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("casasBtn.BackgroundImage")));
            this.casasBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.casasBtn.Location = new System.Drawing.Point(931, 1);
            this.casasBtn.Name = "casasBtn";
            this.casasBtn.Size = new System.Drawing.Size(73, 50);
            this.casasBtn.TabIndex = 1;
            this.casasBtn.UseVisualStyleBackColor = true;
            this.casasBtn.Click += new System.EventHandler(this.casasBtn_Click);
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
            this.tableAdapterManager.mascotaTableAdapter = this.mascotaTableAdapter;
            this.tableAdapterManager.mueblesTableAdapter = null;
            this.tableAdapterManager.padresTableAdapter = null;
            this.tableAdapterManager.servicioAguaTableAdapter = null;
            this.tableAdapterManager.servicioCableTableAdapter = null;
            this.tableAdapterManager.servicioElectricidadTableAdapter = null;
            this.tableAdapterManager.servicioInternetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FmMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 464);
            this.Controls.Add(this.splitContainer2);
            this.Name = "FmMascota";
            this.Text = "FmMascota";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmMascota_FormClosing);
            this.Load += new System.EventHandler(this.FmMascota_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mascotaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.Button servicesBtb;
        private System.Windows.Forms.Button childrenBtn;
        private System.Windows.Forms.Button casasBtn;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource mascotaBindingSource;
        private DataSet1TableAdapters.mascotaTableAdapter mascotaTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView mascotaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button mueblesBtn;
        private System.Windows.Forms.Button interiorBtn;
        private System.Windows.Forms.Button exteriorBtn;
        private System.Windows.Forms.Button padresBtn;
    }
}