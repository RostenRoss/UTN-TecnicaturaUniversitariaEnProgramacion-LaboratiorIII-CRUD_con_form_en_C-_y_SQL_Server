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
    public partial class FmPadre : Form
    {
        private Form principal;
        private string cerrarBoton = "cerrar";
        public FmPadre(Form principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void padresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.padresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FmPadre_Load(object sender, EventArgs e)
        {
            refrescar();
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnDelete.Name = "Eliminar";
            btnEditar.Name = "Editar";
            this.padresDataGridView.Columns.Add(btnDelete);
            this.padresDataGridView.Columns.Add(btnEditar);

        }

        private void padresDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            AddPadreForm agregarPadre = new AddPadreForm();
            agregarPadre.ShowDialog();
            refrescar();
        }

        private void FmPadre_FormClosing(object sender, FormClosingEventArgs e)
        {       
            if (this.cerrarBoton == "cerrar")
            {
                this.principal.Close();
            }

        }

        private void refrescar()
        {
            this.padresTableAdapter.Fill(this.dataSet1.padres);

        }

        private void padresDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.padresDataGridView.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell deleteButton = this.padresDataGridView.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;

                Icon iconDelete = new Icon(Environment.CurrentDirectory + @"\\delete.ico");

                e.Graphics.DrawIcon(iconDelete, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.padresDataGridView.Rows[e.RowIndex].Height = iconDelete.Height + 8;
                this.padresDataGridView.Columns[e.ColumnIndex].Width = iconDelete.Width + 8;


                e.Handled = true;
            }

            if (e.ColumnIndex >= 0 && this.padresDataGridView.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell editarButton = this.padresDataGridView.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;

                Icon iconEdit = new Icon(Environment.CurrentDirectory + @"\\edit.ico");
                e.Graphics.DrawIcon(iconEdit, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.padresDataGridView.Rows[e.RowIndex].Height = iconEdit.Height + 8;
                this.padresDataGridView.Columns[e.ColumnIndex].Width = iconEdit.Width + 8;

                e.Handled = true;
            }

        }

        private void padresDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.padresDataGridView.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                long id = getId();
                if (id != 0)
                {
                    AddCasaForm casaForm = new AddCasaForm();
                    this.tableAdapterManager.casasTableAdapter.deleteById(id);
                    refrescar();
                }
            }

            if (this.padresDataGridView.Columns[e.ColumnIndex].Name == "Editar")
            {
                long id = getId();
                Console.WriteLine("id: " + id);

                if (id != 0)
                {
                    AddPadreForm agregarPadreFm = new AddPadreForm(id, this);
                    agregarPadreFm.ShowDialog();
                }
                refrescar();
            }
           
        }

        private long getId()
        {
            try
            {
                return long.Parse(padresDataGridView.Rows[padresDataGridView.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return 0;
            }
        }

        public void refrescarForm() 
        {
            this.refrescar();
        }

     

        private void casaClick(object sender, EventArgs e)
        {
            this.principal.Show();
            if (((Button)sender).Name == casasBtn.Name)
            {
                this.cerrarBoton = ((Button)sender).Name;
            }
            this.Close();
        }

        private void children_Click(object sender, EventArgs e)
        {
            FmHijo formHijos = new FmHijo(this.principal);
            formHijos.Show();
            if (((Button)sender).Name == "childrenBtn")
            {
                this.cerrarBoton= ((Button)sender).Name;
            }
            this.Close();
        }

        private void services_Click(object sender, EventArgs e)
        {
            FmServicio formServicios = new FmServicio(this.principal);
            formServicios.Show();
            if (((Button)sender).Name == "servicesBtn")
            {
                this.cerrarBoton = ((Button)sender).Name;

            }
            this.Close();
           
        }

        private void petBtn_Click(object sender, EventArgs e)
        {
            FmMascota fmMascota = new FmMascota(this.principal);
            fmMascota.Show();
            if (((Button)sender).Name == "petBtn")
            {
                this.cerrarBoton = ((Button)sender).Name;

            }
            this.Close();
        }

        private void exteriorBtn_Click(object sender, EventArgs e)
        {
            FmExterior fmExterio = new FmExterior(this.principal);
            fmExterio.Show();
            if (((Button)sender).Name == "exteriorBtn")
            {
                this.cerrarBoton = ((Button)sender).Name;

            }
            this.Close();
        }

        private void interiorBtn_Click(object sender, EventArgs e)
        {
            FmHabitacion fmHabitacion = new FmHabitacion(this.principal);
            fmHabitacion.Show();
            if (((Button)sender).Name == "interiorBtn")
            {
                this.cerrarBoton = ((Button)sender).Name;

            }
            this.Close();
        }

        private void mueblesBtn_Click(object sender, EventArgs e)
        {
            FmMuebles fmMuebles = new FmMuebles(this.principal);
            fmMuebles.Show();
            if (((Button)sender).Name == "mueblesBtn")
            {
                this.cerrarBoton = ((Button)sender).Name;

            }
            this.Close();
        }
    }
}
