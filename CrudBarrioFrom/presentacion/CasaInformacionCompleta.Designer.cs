
namespace CrudBarrioFrom.presentacion
{
    partial class CasaInformacionCompleta
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
            this.dataSet1 = new CrudBarrioFrom.DataSet1();
            this.casasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casasTableAdapter = new CrudBarrioFrom.DataSet1TableAdapters.casasTableAdapter();
            this.tableAdapterManager = new CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager();
            this.dataSet11 = new CrudBarrioFrom.DataSet1();
            this.gridCasaInformacionCompleta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCasaInformacionCompleta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // casasBindingSource
            // 
            this.casasBindingSource.DataMember = "casas";
            this.casasBindingSource.DataSource = this.dataSet1;
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
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridCasaInformacionCompleta
            // 
            this.gridCasaInformacionCompleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCasaInformacionCompleta.Location = new System.Drawing.Point(1, 146);
            this.gridCasaInformacionCompleta.Name = "gridCasaInformacionCompleta";
            this.gridCasaInformacionCompleta.Size = new System.Drawing.Size(1158, 185);
            this.gridCasaInformacionCompleta.TabIndex = 0;
            // 
            // CasaInformacionCompleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 336);
            this.Controls.Add(this.gridCasaInformacionCompleta);
            this.Name = "CasaInformacionCompleta";
            this.Text = "CasaInformacionCompleta";
            this.Load += new System.EventHandler(this.CasaInformacionCompleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCasaInformacionCompleta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource casasBindingSource;
        private DataSet1TableAdapters.casasTableAdapter casasTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DataSet1 dataSet11;
        private System.Windows.Forms.DataGridView gridCasaInformacionCompleta;
    }
}