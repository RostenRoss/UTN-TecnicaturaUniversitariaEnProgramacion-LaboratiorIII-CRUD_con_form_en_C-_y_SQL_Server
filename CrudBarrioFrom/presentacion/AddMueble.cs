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
        //Form grilla;
        public AddMueble()
        {
            InitializeComponent();
        }
        public AddMueble(long id)
        {
            InitializeComponent();
            this.id= id;
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
                this.mueblesTableAdapter.InsertMueble(nombreTextBox.Text, long.Parse(id_lugarTextBox.Text));

            }
            else
            {
                this.mueblesTableAdapter.UpdateMueble(nombreTextBox.Text,long.Parse(id_lugarTextBox.Text), this.id);
            }

            this.Close();
        }
    }
}
