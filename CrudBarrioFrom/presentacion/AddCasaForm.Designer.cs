
namespace CrudBarrioFrom.presentacion
{
    partial class AddCasaForm
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
            System.Windows.Forms.Label manzanaLabel;
            System.Windows.Forms.Label parcelaLabel;
            System.Windows.Forms.Label calleLabel;
            System.Windows.Forms.Label alturaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCasaForm));
            this.guardarButton = new System.Windows.Forms.Button();
            this.cancelarButon = new System.Windows.Forms.Button();
            this.manzanaTextBox = new System.Windows.Forms.TextBox();
            this.casasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CrudBarrioFrom.DataSet1();
            this.parcelaTextBox = new System.Windows.Forms.TextBox();
            this.calleTextBox = new System.Windows.Forms.TextBox();
            this.alturaTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.casasTableAdapter = new CrudBarrioFrom.DataSet1TableAdapters.casasTableAdapter();
            this.tableAdapterManager = new CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager();
            manzanaLabel = new System.Windows.Forms.Label();
            parcelaLabel = new System.Windows.Forms.Label();
            calleLabel = new System.Windows.Forms.Label();
            alturaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.casasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // manzanaLabel
            // 
            manzanaLabel.AutoSize = true;
            manzanaLabel.Location = new System.Drawing.Point(21, 41);
            manzanaLabel.Name = "manzanaLabel";
            manzanaLabel.Size = new System.Drawing.Size(53, 13);
            manzanaLabel.TabIndex = 12;
            manzanaLabel.Text = "manzana:";
            // 
            // parcelaLabel
            // 
            parcelaLabel.AutoSize = true;
            parcelaLabel.Location = new System.Drawing.Point(21, 67);
            parcelaLabel.Name = "parcelaLabel";
            parcelaLabel.Size = new System.Drawing.Size(45, 13);
            parcelaLabel.TabIndex = 14;
            parcelaLabel.Text = "parcela:";
            // 
            // calleLabel
            // 
            calleLabel.AutoSize = true;
            calleLabel.Location = new System.Drawing.Point(21, 93);
            calleLabel.Name = "calleLabel";
            calleLabel.Size = new System.Drawing.Size(32, 13);
            calleLabel.TabIndex = 16;
            calleLabel.Text = "calle:";
            // 
            // alturaLabel
            // 
            alturaLabel.AutoSize = true;
            alturaLabel.Location = new System.Drawing.Point(21, 119);
            alturaLabel.Name = "alturaLabel";
            alturaLabel.Size = new System.Drawing.Size(36, 13);
            alturaLabel.TabIndex = 18;
            alturaLabel.Text = "altura:";
            // 
            // guardarButton
            // 
            this.guardarButton.BackColor = System.Drawing.Color.LimeGreen;
            this.guardarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guardarButton.BackgroundImage")));
            this.guardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guardarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guardarButton.Location = new System.Drawing.Point(50, 164);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(71, 57);
            this.guardarButton.TabIndex = 8;
            this.guardarButton.UseVisualStyleBackColor = false;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // cancelarButon
            // 
            this.cancelarButon.BackColor = System.Drawing.Color.LightCoral;
            this.cancelarButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelarButon.BackgroundImage")));
            this.cancelarButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelarButon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelarButon.Location = new System.Drawing.Point(225, 164);
            this.cancelarButon.Name = "cancelarButon";
            this.cancelarButon.Size = new System.Drawing.Size(71, 57);
            this.cancelarButon.TabIndex = 9;
            this.cancelarButon.UseVisualStyleBackColor = false;
            this.cancelarButon.Click += new System.EventHandler(this.cancelarButon_Click);
            // 
            // manzanaTextBox
            // 
            this.manzanaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casasBindingSource, "manzana", true));
            this.manzanaTextBox.Location = new System.Drawing.Point(80, 38);
            this.manzanaTextBox.Name = "manzanaTextBox";
            this.manzanaTextBox.Size = new System.Drawing.Size(230, 20);
            this.manzanaTextBox.TabIndex = 13;
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
            // parcelaTextBox
            // 
            this.parcelaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casasBindingSource, "parcela", true));
            this.parcelaTextBox.Location = new System.Drawing.Point(80, 64);
            this.parcelaTextBox.Name = "parcelaTextBox";
            this.parcelaTextBox.Size = new System.Drawing.Size(230, 20);
            this.parcelaTextBox.TabIndex = 15;
            // 
            // calleTextBox
            // 
            this.calleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casasBindingSource, "calle", true));
            this.calleTextBox.Location = new System.Drawing.Point(80, 90);
            this.calleTextBox.Name = "calleTextBox";
            this.calleTextBox.Size = new System.Drawing.Size(230, 20);
            this.calleTextBox.TabIndex = 17;
            // 
            // alturaTextBox
            // 
            this.alturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casasBindingSource, "altura", true));
            this.alturaTextBox.Location = new System.Drawing.Point(80, 116);
            this.alturaTextBox.Name = "alturaTextBox";
            this.alturaTextBox.Size = new System.Drawing.Size(230, 20);
            this.alturaTextBox.TabIndex = 19;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casasBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(80, 12);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(230, 20);
            this.idTextBox.TabIndex = 11;
            this.idTextBox.Visible = false;
            // 
            // casasTableAdapter
            // 
            this.casasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.casasTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = CrudBarrioFrom.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FmCasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 233);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(manzanaLabel);
            this.Controls.Add(this.manzanaTextBox);
            this.Controls.Add(parcelaLabel);
            this.Controls.Add(this.parcelaTextBox);
            this.Controls.Add(calleLabel);
            this.Controls.Add(this.calleTextBox);
            this.Controls.Add(alturaLabel);
            this.Controls.Add(this.alturaTextBox);
            this.Controls.Add(this.cancelarButon);
            this.Controls.Add(this.guardarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmCasa";
            this.Text = "Datos de la casa";
            this.Load += new System.EventHandler(this.FmCasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.casasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.Button cancelarButon;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource casasBindingSource;
        private DataSet1TableAdapters.casasTableAdapter casasTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox manzanaTextBox;
        private System.Windows.Forms.TextBox parcelaTextBox;
        private System.Windows.Forms.TextBox calleTextBox;
        private System.Windows.Forms.TextBox alturaTextBox;
        private System.Windows.Forms.TextBox idTextBox;
    }
}