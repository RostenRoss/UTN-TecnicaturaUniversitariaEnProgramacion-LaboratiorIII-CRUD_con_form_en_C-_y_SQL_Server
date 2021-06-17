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
    public partial class FmHijo : Form
    {
        private string cerrarBoton = "cerrar";

        private Form principal;
        public FmHijo()
        {
            InitializeComponent();
        }
        public FmHijo(Form principal)
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

        private void hijosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hijosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FmHijo_Load(object sender, EventArgs e)
        {
            refrescar();
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnDelete.Name = "Eliminar";
            btnEditar.Name = "Editar";
            this.hijosDataGridView.Columns.Add(btnDelete);
            this.hijosDataGridView.Columns.Add(btnEditar);
        }

        private void FmHijo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.cerrarBoton == "cerrar")
            {
                this.principal.Close();
            }
        }

        private void refrescar()
        {
            this.hijosTableAdapter.Fill(this.dataSet1.hijos);

        }

        private void hijosDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.hijosDataGridView.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell deleteButton = this.hijosDataGridView.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;

                Icon iconDelete = new Icon(Environment.CurrentDirectory + @"\\delete.ico");

                e.Graphics.DrawIcon(iconDelete, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.hijosDataGridView.Rows[e.RowIndex].Height = iconDelete.Height + 8;
                this.hijosDataGridView.Columns[e.ColumnIndex].Width = iconDelete.Width + 8;


                e.Handled = true;
            }

            if (e.ColumnIndex >= 0 && this.hijosDataGridView.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell editarButton = this.hijosDataGridView.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;

                Icon iconEdit = new Icon(Environment.CurrentDirectory + @"\\edit.ico");
                e.Graphics.DrawIcon(iconEdit, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.hijosDataGridView.Rows[e.RowIndex].Height = iconEdit.Height + 8;
                this.hijosDataGridView.Columns[e.ColumnIndex].Width = iconEdit.Width + 8;

                e.Handled = true;
            }
        }

        private void hijosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.hijosDataGridView.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                long id = getId();
                if (id != 0)
                {
                    hijosTableAdapter.DeleteById(id);
                    refrescar();
                }
            }

            if (this.hijosDataGridView.Columns[e.ColumnIndex].Name == "Editar")
            {
                long id = getId();
                if (id != 0)
                {
                    AddHijo agregarPadreFm = new AddHijo(id, this);
                    agregarPadreFm.ShowDialog();
                }
                refrescar();
            }           
        }
        private long getId()
        {
            try
            {
                return long.Parse(hijosDataGridView.Rows[hijosDataGridView.CurrentRow.Index].Cells[0].Value.ToString());
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

        private void agregarButton_Click(object sender, EventArgs e)
        {
            AddHijo agregarHijo = new AddHijo();
            agregarHijo.ShowDialog();
            refrescar();
        }

        private void padres_Click(object sender, EventArgs e)
        {
            FmPadre formPadre = new FmPadre(this.principal);
            formPadre.Show();
            if (((Button)sender).Name == padresBtn.Name)
            {
                this.cerrarBoton = ((Button)sender).Name;
            }
            this.Close();
        }
        private void casas_Click(object sender, EventArgs e)
        {
            this.principal.Show();
            if (((Button)sender).Name == casaBtn.Name)
            {
                this.cerrarBoton = ((Button)sender).Name;
            }
            this.Close();
        }

        private void services_Click(object sender, EventArgs e)
        {
            FmServicio fmServicio = new FmServicio(this.principal);
            fmServicio.Show();
            if (((Button)sender).Name == servicesBtn.Name)
            {
                this.cerrarBoton = ((Button)sender).Name;
            }
            this.Close();
        }

        private void mueblesBtn_Click(object sender, EventArgs e)
        {
            FmMuebles fmMuebles = new FmMuebles(this.principal);
            fmMuebles.Show();
            if (((Button)sender).Name == mueblesBtn.Name)
            {
                this.cerrarBoton = ((Button)sender).Name;
            }
            this.Close();
        }

        private void interiorBtn_Click(object sender, EventArgs e)
        {
            FmHabitacion fmHabitacion = new FmHabitacion(this.principal);
            fmHabitacion.Show();
            if (((Button)sender).Name == interiorBtn.Name)
            {
                this.cerrarBoton = ((Button)sender).Name;
            }
            this.Close();
        }

        private void exteriorBtn_Click(object sender, EventArgs e)
        {
            FmExterior fmExterior = new FmExterior(this.principal);
            fmExterior.Show();
            if (((Button)sender).Name == exteriorBtn.Name)
            {
                this.cerrarBoton = ((Button)sender).Name;
            }
            this.Close();
        }

        private void petBtn_Click(object sender, EventArgs e)
        {
            FmMascota fmMascota = new FmMascota(this.principal);
            fmMascota.Show();
            if (((Button)sender).Name == petBtn.Name)
            {
                this.cerrarBoton = ((Button)sender).Name;
            }
            this.Close();
        }
    }
}
