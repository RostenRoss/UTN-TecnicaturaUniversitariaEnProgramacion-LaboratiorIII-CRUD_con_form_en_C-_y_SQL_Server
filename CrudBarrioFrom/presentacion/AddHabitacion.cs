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
    public partial class AddHabitacion : Form
    {
        public long id;
        public FmHabitacion grilla;

        public AddHabitacion(long id, FmHabitacion grilla)
        {
            InitializeComponent();
            this.id = id;
            this.grilla = grilla;
        }
        public AddHabitacion()
        {
            InitializeComponent();
            this.id = 0;
        }

        private void habitacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.habitacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Habitacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.habitacion' Puede moverla o quitarla según sea necesario.
            //this.habitacionTableAdapter.Fill(this.dataSet1.habitacion);
            cargaDatos();

        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {

            if (id == 0)
            {
                long casa_id = long.Parse(id_casaTextBox.Text);
                this.habitacionTableAdapter.InsertInterior(tipoTextBox.Text, Double.Parse(metrosCuadradosTextBox.Text), 
                                            long.Parse(id_casaTextBox.Text));

            }
            else
            {
                this.habitacionTableAdapter.UpdateHabitacionById(tipoTextBox.Text, Double.Parse(metrosCuadradosTextBox.Text),
                                            long.Parse(id_casaTextBox.Text), this.id);

                grilla.refrescarGrilla();
            }

            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargaDatos()
        {
            if (this.id != 0)
            {
                this.habitacionBindingSource.DataSource = this.habitacionTableAdapter.GetDataById(this.id);
            }
        }
    }
}
