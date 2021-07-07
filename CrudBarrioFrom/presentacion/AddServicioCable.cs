using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudBarrioFrom.presentacion
{
    public partial class AddServicioCable : Form
    {
        public long id;
        public FmServicio grilla;

        public AddServicioCable(long id, FmServicio grilla)
        {
            InitializeComponent();
            this.id = id;
            this.grilla = grilla;
        }
        public AddServicioCable()
        {
            InitializeComponent();
            this.id = 0;
        }

        private void AddServicioCable_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.servicioCable' Puede moverla o quitarla según sea necesario.
            this.servicioCableTableAdapter.Fill(this.dataSet1.servicioCable);

        }

        private void servicioCableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicioCableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void esHdCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {

            if (id == 0)
            {
                long casa_id = long.Parse(id_casaTextBox.Text);
                this.servicioCableTableAdapter.InsertServicioCable(tipoTextBox.Text, esHdCheckBox.Checked, Double.Parse(precioTextBox.Text), 
                    empresaTextBox.Text, Double.Parse(limiteDeDatosTextBox.Text), 
                    DateTime.Parse(fechaInstaladoDateTimePicker.Text), long.Parse(id_casaTextBox.Text));
            }            
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
