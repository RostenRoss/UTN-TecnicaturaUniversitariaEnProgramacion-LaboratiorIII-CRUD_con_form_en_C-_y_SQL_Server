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
    public partial class AddMueble : Form
    {
        long id=0;
        FmMuebles grilla;
        public AddMueble()
        {
            InitializeComponent();
        }
        public AddMueble(long id, FmMuebles grilla)
        {
            InitializeComponent();
            this.id= id;
            this.grilla = grilla;
        }

        private void mueblesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mueblesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void AddMueble_Load(object sender, EventArgs e)
        {
            cargaDatos();
        }

        private void cargaDatos()
        {
            if (this.id != 0)
            {
                this.mueblesBindingSource.DataSource = this.mueblesTableAdapter.GetDataById(this.id);

            }
        }
        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                if (id_exteriorTextBox.Text == "" || id_exteriorTextBox.Text == null)
                {
                    this.mueblesTableAdapter.InsertMuebleEnHabitacion(nombreTextBox.Text, long.Parse(id_habitacionTextBox.Text));
                }
                else 
                {
                    this.mueblesTableAdapter.InsertMuebleEnExterior(nombreTextBox.Text, long.Parse(id_exteriorTextBox.Text));
                }
            }
            else
            {
                if (id_exteriorTextBox.Text == "" || id_exteriorTextBox.Text == null)
                {
                    this.mueblesTableAdapter.UpdateMuebleHabitacion(nombreTextBox.Text, long.Parse(id_habitacionTextBox.Text), this.id);
                }else
                {
                    this.mueblesTableAdapter.UpdateMuebleExterior(nombreTextBox.Text, long.Parse(id_exteriorTextBox.Text), this.id);
                }
            }
            this.grilla.refrescarGrilla();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
