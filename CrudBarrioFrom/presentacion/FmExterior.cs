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
    public partial class FmExterior : Form
    {
        private string cerrarBoton = "cerrar";

        private Form principal;
        public FmExterior()
        {
            InitializeComponent();
        }
        public FmExterior(Form principal)
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

        private void exteriorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.exteriorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FmExterior_Load(object sender, EventArgs e)
        {
            refrescar();
            this.exteriorTableAdapter.Fill(this.dataSet1.exterior);
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnDelete.Name = "Eliminar";
            btnEditar.Name = "Editar";
            this.exteriorDataGridView.Columns.Add(btnDelete);
            this.exteriorDataGridView.Columns.Add(btnEditar);
        }

        private void FmExterior_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.cerrarBoton == "cerrar")
            {
                this.principal.Close();
            }
        }

        private void casaBtn_Click(object sender, EventArgs e)
        {
            this.principal.Show();
            if (((Button)sender).Name == casaBtn.Name)
            {
                this.cerrarBoton = ((Button)sender).Name;
            }
            this.Close();
        }

        private void childrenBtn_Click(object sender, EventArgs e)
        {
            FmHijo fmHijo = new FmHijo(this.principal);
            fmHijo.Show();
            if (((Button)sender).Name == childrenBtn.Name)
            {
                this.cerrarBoton = ((Button)sender).Name;
            }
            this.Close();
        }

        private void servicesBtn_Click(object sender, EventArgs e)
        {
            FmServicio fmServicio = new FmServicio(this.principal);
            fmServicio.Show();
            if (((Button)sender).Name == servicesBtn.Name)
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

        private void exteriorBtn_Click(object sender, EventArgs e)
        {
            FmPadre fmPadre = new FmPadre(this.principal);
            fmPadre.Show();
            if (((Button)sender).Name == padresBtn.Name)
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

        private void exteriorDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.exteriorDataGridView.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell deleteButton = this.exteriorDataGridView.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;

                Icon iconDelete = new Icon(Environment.CurrentDirectory + @"\\delete.ico");

                e.Graphics.DrawIcon(iconDelete, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.exteriorDataGridView.Rows[e.RowIndex].Height = iconDelete.Height + 8;
                this.exteriorDataGridView.Columns[e.ColumnIndex].Width = iconDelete.Width + 8;


                e.Handled = true;
            }

            if (e.ColumnIndex >= 0 && this.exteriorDataGridView.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell editarButton = this.exteriorDataGridView.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;

                Icon iconEdit = new Icon(Environment.CurrentDirectory + @"\\edit.ico");
                e.Graphics.DrawIcon(iconEdit, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.exteriorDataGridView.Rows[e.RowIndex].Height = iconEdit.Height + 8;
                this.exteriorDataGridView.Columns[e.ColumnIndex].Width = iconEdit.Width + 8;

                e.Handled = true;
            }

        }

        private void exteriorDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.exteriorDataGridView.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                long id = getId();
                if (id != 0)
                {
                    exteriorTableAdapter.DeleteExteriorById(id);
                    refrescar();
                }
            }

            if (this.exteriorDataGridView.Columns[e.ColumnIndex].Name == "Editar")
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
        private void refrescar()
        {
            this.exteriorTableAdapter.Fill(this.dataSet1.exterior);

        }

        private long getId()
        {
            try
            {
                return long.Parse(exteriorDataGridView.Rows[exteriorDataGridView.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return 0;
            }
        }
    }
}
