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
    public partial class AddServicioAgua : Form
    {
        public long id;
        public FmServicio grilla;

        public AddServicioAgua(FmServicio grilla)
        {
            InitializeComponent();
            this.id = 0;
            this.grilla = grilla;
        }

        private void servicioAguaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicioAguaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void AddServicioAgua_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.servicioAgua' Puede moverla o quitarla según sea necesario.

        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                long casa_id = long.Parse(id_casaTextBox.Text);
                this.servicioAguaTableAdapter.InsertServicioAgua(tipoTextBox.Text, empresaTextBox.Text, Double.Parse(precioTextBox.Text),
                    DateTime.Parse(fechaInstaladoDateTimePicker.Text), long.Parse(id_casaTextBox.Text));
            }
            grilla.refrescar();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
