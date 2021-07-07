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
    public partial class AddServicioLuz : Form
    {
        public long id;
        public FmServicio grilla;

        public AddServicioLuz(long id, FmServicio grilla)
        {
            InitializeComponent();
            this.id = id;
            this.grilla = grilla;
        }
        public AddServicioLuz()
        {
            InitializeComponent();
            this.id = 0;
        }
        private void AddServicioLuz_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.servicioElectricidad' Puede moverla o quitarla según sea necesario.
            this.servicioElectricidadTableAdapter.Fill(this.dataSet1.servicioElectricidad);

        }

        private void servicioElectricidadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicioElectricidadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                long casa_id = long.Parse(id_casaTextBox.Text);
                this.servicioElectricidadTableAdapter.InsertServicioElectricidad(esTrifasicaCheckBox.Checked, Double.Parse(precioTextBox.Text),
                    empresaTextBox.Text, DateTime.Parse(fechaInstaladoDateTimePicker.Text), long.Parse(id_casaTextBox.Text));
            }
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
