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
        public FmServicio grilla;

        public AddServicioLuz(FmServicio grilla)
        {
            InitializeComponent();
            this.grilla = grilla;
        }
        private void AddServicioLuz_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.servicioElectricidad' Puede moverla o quitarla según sea necesario.
          

        }

        private void servicioElectricidadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicioElectricidadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            
            
                long casa_id = long.Parse(id_casaTextBox.Text);
                this.servicioElectricidadTableAdapter.InsertServicioElectricidad(esTrifasicaCheckBox.Checked, Double.Parse(precioTextBox.Text),
                    empresaTextBox.Text, DateTime.Parse(fechaInstaladoDateTimePicker.Text), long.Parse(id_casaTextBox.Text));
            
            this.grilla.refrescar();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
