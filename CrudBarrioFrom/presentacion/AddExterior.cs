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
    public partial class AddExterior : Form
    {
        public AddExterior()
        {
            InitializeComponent();
        }

        private void AddExterior_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Exterior' Puede moverla o quitarla según sea necesario.
            this.exteriorTableAdapter.Fill(this.dataSet1.exterior);

        }

        private void exteriorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.exteriorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
