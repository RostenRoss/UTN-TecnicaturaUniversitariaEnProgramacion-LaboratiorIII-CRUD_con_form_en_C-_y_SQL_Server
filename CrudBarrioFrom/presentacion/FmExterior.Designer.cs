﻿
namespace CrudBarrioFrom.presentacion
{
    partial class FmExterior
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmExterior));
            this.casaBtn = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.agregarButton = new System.Windows.Forms.Button();
            this.mueblesBtn = new System.Windows.Forms.Button();
            this.interiorBtn = new System.Windows.Forms.Button();
            this.padresBtn = new System.Windows.Forms.Button();
            this.petBtn = new System.Windows.Forms.Button();
            this.exteriorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exteriorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CrudBarrioFrom.DataSet1();
            this.servicesBtn = new System.Windows.Forms.Button();
            this.childrenBtn = new System.Windows.Forms.Button();
            this.exteriorTableAdapter = new CrudBarrioFrom.DataSet1TableAdapters.exteriorTableAdapter();
            this.tableAdapterManager = new CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exteriorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exteriorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // casaBtn
            // 
            this.casaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("casaBtn.BackgroundImage")));
            this.casaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.casaBtn.Location = new System.Drawing.Point(650, 0);
            this.casaBtn.Name = "casaBtn";
            this.casaBtn.Size = new System.Drawing.Size(73, 50);
            this.casaBtn.TabIndex = 1;
            this.casaBtn.UseVisualStyleBackColor = true;
            this.casaBtn.Click += new System.EventHandler(this.casaBtn_Click);
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
            this.splitContainer2.Panel2.Controls.Add(this.padresBtn);
            this.splitContainer2.Panel2.Controls.Add(this.petBtn);
            this.splitContainer2.Panel2.Controls.Add(this.exteriorDataGridView);
            this.splitContainer2.Panel2.Controls.Add(this.servicesBtn);
            this.splitContainer2.Panel2.Controls.Add(this.childrenBtn);
            this.splitContainer2.Panel2.Controls.Add(this.casaBtn);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(747, 475);
            this.splitContainer2.SplitterDistance = 65;
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
            // mueblesBtn
            // 
            this.mueblesBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mueblesBtn.BackgroundImage")));
            this.mueblesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mueblesBtn.Location = new System.Drawing.Point(650, 336);
            this.mueblesBtn.Name = "mueblesBtn";
            this.mueblesBtn.Size = new System.Drawing.Size(75, 50);
            this.mueblesBtn.TabIndex = 15;
            this.mueblesBtn.UseVisualStyleBackColor = true;
            this.mueblesBtn.Click += new System.EventHandler(this.mueblesBtn_Click);
            // 
            // interiorBtn
            // 
            this.interiorBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("interiorBtn.BackgroundImage")));
            this.interiorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.interiorBtn.Location = new System.Drawing.Point(650, 280);
            this.interiorBtn.Name = "interiorBtn";
            this.interiorBtn.Size = new System.Drawing.Size(75, 50);
            this.interiorBtn.TabIndex = 14;
            this.interiorBtn.UseVisualStyleBackColor = true;
            this.interiorBtn.Click += new System.EventHandler(this.interiorBtn_Click);
            // 
            // padresBtn
            // 
            this.padresBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("padresBtn.BackgroundImage")));
            this.padresBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.padresBtn.Location = new System.Drawing.Point(650, 56);
            this.padresBtn.Name = "padresBtn";
            this.padresBtn.Size = new System.Drawing.Size(75, 50);
            this.padresBtn.TabIndex = 13;
            this.padresBtn.UseVisualStyleBackColor = true;
            this.padresBtn.Click += new System.EventHandler(this.exteriorBtn_Click);
            // 
            // petBtn
            // 
            this.petBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("petBtn.BackgroundImage")));
            this.petBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.petBtn.Location = new System.Drawing.Point(650, 224);
            this.petBtn.Name = "petBtn";
            this.petBtn.Size = new System.Drawing.Size(75, 50);
            this.petBtn.TabIndex = 12;
            this.petBtn.UseVisualStyleBackColor = true;
            this.petBtn.Click += new System.EventHandler(this.petBtn_Click);
            // 
            // exteriorDataGridView
            // 
            this.exteriorDataGridView.AutoGenerateColumns = false;
            this.exteriorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exteriorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.exteriorDataGridView.DataSource = this.exteriorBindingSource;
            this.exteriorDataGridView.Location = new System.Drawing.Point(3, 0);
            this.exteriorDataGridView.Name = "exteriorDataGridView";
            this.exteriorDataGridView.Size = new System.Drawing.Size(587, 406);
            this.exteriorDataGridView.TabIndex = 3;
            this.exteriorDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.exteriorDataGridView_CellClick);
            this.exteriorDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.exteriorDataGridView_CellPainting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tipo";
            this.dataGridViewTextBoxColumn2.HeaderText = "tipo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "metrosCuadrados";
            this.dataGridViewTextBoxColumn3.HeaderText = "metrosCuadrados";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_casa";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_casa";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // exteriorBindingSource
            // 
            this.exteriorBindingSource.DataMember = "Exterior";
            this.exteriorBindingSource.DataSource = this.dataSet1;
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
            this.servicesBtn.Location = new System.Drawing.Point(650, 168);
            this.servicesBtn.Name = "servicesBtn";
            this.servicesBtn.Size = new System.Drawing.Size(73, 50);
            this.servicesBtn.TabIndex = 3;
            this.servicesBtn.UseVisualStyleBackColor = true;
            this.servicesBtn.Click += new System.EventHandler(this.servicesBtn_Click);
            // 
            // childrenBtn
            // 
            this.childrenBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("childrenBtn.BackgroundImage")));
            this.childrenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.childrenBtn.Location = new System.Drawing.Point(650, 112);
            this.childrenBtn.Name = "childrenBtn";
            this.childrenBtn.Size = new System.Drawing.Size(73, 50);
            this.childrenBtn.TabIndex = 2;
            this.childrenBtn.UseVisualStyleBackColor = true;
            this.childrenBtn.Click += new System.EventHandler(this.childrenBtn_Click);
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
            this.tableAdapterManager.mascotaTableAdapter = null;
            this.tableAdapterManager.mueblesTableAdapter = null;
            this.tableAdapterManager.padresTableAdapter = null;
            this.tableAdapterManager.servicioAguaTableAdapter = null;
            this.tableAdapterManager.servicioCableTableAdapter = null;
            this.tableAdapterManager.servicioElectricidadTableAdapter = null;
            this.tableAdapterManager.servicioInternetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FmExterior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 475);
            this.Controls.Add(this.splitContainer2);
            this.Name = "FmExterior";
            this.Text = "FmExterior";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmExterior_FormClosing);
            this.Load += new System.EventHandler(this.FmExterior_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exteriorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exteriorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button casaBtn;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.Button servicesBtn;
        private System.Windows.Forms.Button childrenBtn;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource exteriorBindingSource;
        private DataSet1TableAdapters.exteriorTableAdapter exteriorTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView exteriorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button mueblesBtn;
        private System.Windows.Forms.Button interiorBtn;
        private System.Windows.Forms.Button padresBtn;
        private System.Windows.Forms.Button petBtn;
    }
}