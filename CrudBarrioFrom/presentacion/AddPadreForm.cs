using System;
using System.Windows.Forms;

namespace CrudBarrioFrom.presentacion
{
    public partial class AddPadreForm : Form
    {
        public long id;
        public FmPadre grilla;

        public AddPadreForm( long id, FmPadre grilla)
        {
            InitializeComponent();
            this.id = id;
            this.grilla = grilla;
        }
        public AddPadreForm()
        {
            InitializeComponent();
            this.id = 0;
        }

        private void AddPadreForm_Load(object sender, EventArgs e)
        {
            cargaDatos();
        }

        private void cargaDatos()
        {
            if (this.id != 0)
            {
               this.padresBindingSource1.DataSource = this.padresTableAdapter1.GetDataById(this.id);
            }
        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                long casa_id =long.Parse( id_casaTextBox.Text);
                this.padresTableAdapter1.save(nombreTextBox.Text,DateTime.Parse(fechaNacimientoDateTimePicker.Text),
                    sexoCheckBox.Checked, trabajoTextBox.Text, casa_id, 
                    int.Parse(edadTextBox.Text));

            }
            else
            {
                this.padresTableAdapter1.update(nombreTextBox.Text, sexoCheckBox.Checked,
                    int.Parse(edadTextBox.Text), DateTime.Parse(fechaNacimientoDateTimePicker.Text),
                    trabajoTextBox.Text, long.Parse(id_casaTextBox.Text), this.id);

                grilla.refrescarForm();
            }

            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
