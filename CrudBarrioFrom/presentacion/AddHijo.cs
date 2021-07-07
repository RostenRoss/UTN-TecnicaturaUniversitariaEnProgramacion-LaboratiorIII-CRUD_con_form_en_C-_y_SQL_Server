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
    public partial class AddHijo : Form
    {
        private long id;
        private FmHijo grilla;
        public AddHijo(long id, FmHijo grilla)
        {
            InitializeComponent();
            this.id = id;
            this.grilla = grilla;
        }
        public AddHijo()
        {
            InitializeComponent();
        }
        private void hijosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hijosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void AddHijo_Load(object sender, EventArgs e)
        {
            cargaDatos();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                this.hijosTableAdapter.InsertHijo(int.Parse(gradoEscuelaTextBox.Text), nombreTextBox.Text,
                                sexoCheckBox.Checked, int.Parse(edadTextBox.Text), DateTime.Parse(fechaNacimientoDateTimePicker.Text),
                                long.Parse(id_padreTextBox.Text), long.Parse(id_casaTextBox.Text));
            }
            else
            {
                this.hijosTableAdapter.UpdateHijo(nombreTextBox.Text, int.Parse(gradoEscuelaTextBox.Text), 
                                sexoCheckBox.Checked, int.Parse(edadTextBox.Text), DateTime.Parse(fechaNacimientoDateTimePicker.Text),
                                long.Parse(id_padreTextBox.Text), long.Parse(id_casaTextBox.Text), this.id);
                this.grilla.refrescarForm();
            }

            this.Close();
        }

        private void cargaDatos()
        {
            if (this.id != 0)
            {
                this.hijosBindingSource.DataSource = this.hijosTableAdapter.GetDataById(this.id);

            }
        }

        private void sexoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
