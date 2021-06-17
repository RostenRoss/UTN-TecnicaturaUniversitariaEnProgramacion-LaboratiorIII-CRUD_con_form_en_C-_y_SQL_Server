using System;
using System.Windows.Forms;

namespace CrudBarrioFrom.presentacion
{
    public partial class AddCasaForm : Form
    {
        public long id;
        public Form1 grilla;
        public AddCasaForm(long id, Form1 grilla)
        {
            InitializeComponent();
            this.id = id;
            this.grilla = grilla;
        }
        public AddCasaForm()
        {
            InitializeComponent();
            this.id = 0;
        }
        private void FmCasa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.casas' Puede moverla o quitarla según sea necesario.
            //this.casasTableAdapter.Fill(this.dataSet1.casas);
            cargaDatos();
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                this.casasTableAdapter.save(int.Parse(manzanaTextBox.Text), int.Parse(parcelaTextBox.Text), calleTextBox.Text, int.Parse(alturaTextBox.Text));

            }
            else
            {
                this.casasTableAdapter.UpdateCasa(int.Parse(manzanaTextBox.Text), int.Parse(parcelaTextBox.Text), calleTextBox.Text, int.Parse(alturaTextBox.Text), this.id);
                grilla.refrescarGrilla();
            }

            this.Close();
        }

        private void cancelarButon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargaDatos()
        {
            if (this.id != 0)
            {
                casasBindingSource.DataSource = this.casasTableAdapter.GetDataById(this.id);
            }
        }
    }
}
