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
    public partial class AddMascota : Form
    {
        private long id;
        private FmMascota grilla;
        public AddMascota(long id, FmMascota grilla)
        {
            InitializeComponent();
            this.id = id;
            this.grilla = grilla;
        }
        public AddMascota()
        {
            InitializeComponent();
        }

        private void mascotaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mascotaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void AddMascota_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.mascota' Puede moverla o quitarla según sea necesario.
            this.mascotaTableAdapter.Fill(this.dataSet1.mascota);

        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                this.mascotaTableAdapter.InsertMascota(familiaTextBox.Text, dietaTextBox.Text, nombreTextBox.Text, tipoTextBox.Text,
                    int.Parse(edadTextBox.Text), long.Parse(id_casaTextBox.Text));
            }
            else
            {
                this.mascotaTableAdapter.UpdateMascotaById(familiaTextBox.Text, dietaTextBox.Text, nombreTextBox.Text, tipoTextBox.Text,
                    int.Parse(edadTextBox.Text), long.Parse(id_casaTextBox.Text), this.id);
                grilla.refrescarGrilla();
            }
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
