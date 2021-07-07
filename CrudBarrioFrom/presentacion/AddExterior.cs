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
        public long id;
        public FmExterior grilla;

        public AddExterior(long id, FmExterior grilla)
        {
            InitializeComponent();
            this.id = id;
            this.grilla = grilla;
        }
        public AddExterior(FmExterior grilla)
        {
            InitializeComponent();
            this.id = 0;
            this.grilla = grilla;
        }

        private void AddExterior_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Exterior' Puede moverla o quitarla según sea necesario.
            cargaDatos();
        }
        private void cargaDatos()
        {
            if (this.id != 0)
            {
                this.exteriorBindingSource.DataSource = this.exteriorTableAdapter.GetDataById(this.id);
            }
        }

        private void exteriorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.exteriorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                long casa_id = long.Parse(id_casaTextBox.Text);
                this.exteriorTableAdapter.InsertExterior(tipoTextBox.Text, Double.Parse(metrosCuadradosTextBox.Text), 
                    long.Parse(id_casaTextBox.Text));
            }
            else
            {
                this.exteriorTableAdapter.UpdateExterior(tipoTextBox.Text, long.Parse(id_casaTextBox.Text), 
                    Double.Parse(metrosCuadradosTextBox.Text), this.id);

            }
            grilla.refrescarGrilla();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
