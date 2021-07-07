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
    public partial class AddServicioInternet : Form
    {
        public long id;
        public FmServicio grilla;

        public AddServicioInternet(FmServicio grilla)
        {
            InitializeComponent();
            this.id = 0; 
            this.grilla = grilla;
        }

        private void servicioInternetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicioInternetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void AddServicioInternet_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.servicioInternet' Puede moverla o quitarla según sea necesario.


        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                long casa_id = long.Parse(id_casaTextBox.Text);
                this.servicioInternetTableAdapter.InsertServicioInternet(tipoTextBox.Text, int.Parse(velocidadTextBox.Text),
                    float.Parse(precioTextBox.Text), empresaTextBox.Text, limiteDeDatosTextBox.Text, 
                    DateTime.Parse(fechaInstaladoDateTimePicker.Text), long.Parse(id_casaTextBox.Text));
            }
            this.grilla.refrescar();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
