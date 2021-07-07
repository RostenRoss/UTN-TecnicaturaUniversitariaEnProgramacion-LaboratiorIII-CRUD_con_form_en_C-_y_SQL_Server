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

    public partial class FmMuebles : Form
    {
        private string cerrarBoton = "cerrar";
        
        private Form principal;
        public FmMuebles()
        {
            InitializeComponent();
        }
        public FmMuebles(Form principal)
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

        private void mueblesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mueblesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FmMuebles_Load(object sender, EventArgs e)
        {
            refrescar();
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnDelete.Name = "Eliminar";
            btnEditar.Name = "Editar";
            this.mueblesDataGridView.Columns.Add(btnDelete);
            this.mueblesDataGridView.Columns.Add(btnEditar);

        }

        private void FmMuebles_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.cerrarBoton == "cerrar")
            {
                this.principal.Close();
            }
        }

        private void casasBtn_Click(object sender, EventArgs e)
        {
            this.principal.Show();
            if (((Button)sender).Name == casasBtn.Name)
            {
                this.cerrarBoton = ((Button)sender).Name;
            }
            this.Close();
        }

        private void padresBtn_Click(object sender, EventArgs e)
        {
            FmPadre fmPadre = new FmPadre(this.principal);
            fmPadre.Show();
            if (((Button)sender).Name == padresBtn.Name)
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
            FmExterior fmExterior = new FmExterior(this.principal);
            fmExterior.Show();
            if (((Button)sender).Name == exteriorBtn.Name)
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

        private long getId()
        {
            try
            {
                return long.Parse(mueblesDataGridView.Rows[mueblesDataGridView.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return 0;
            }
        }
        private void refrescar()
        {
            this.mueblesTableAdapter.Fill(this.dataSet1.muebles);

        }
     
        private void agregarButton_Click(object sender, EventArgs e)
        {
            AddMueble addMueble = new AddMueble();
            addMueble.ShowDialog();
            refrescar();

        }
             
        private void mueblesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.mueblesDataGridView.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                long id = getId();
                if (id != 0)
                {
                    mueblesTableAdapter.DeleteMuebleById(id);
                    refrescar();
                }
            }

            if (this.mueblesDataGridView.Columns[e.ColumnIndex].Name == "Editar")
            {
                long id = getId();
                if (id != 0)
                {
                    AddMueble agregarPadreFm = new AddMueble(id, this);
                    agregarPadreFm.ShowDialog();
                }
                refrescar();
            }
        }

        private void mueblesDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.mueblesDataGridView.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell deleteButton = this.mueblesDataGridView.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;

                Icon iconDelete = new Icon(Environment.CurrentDirectory + @"\\delete.ico");

                e.Graphics.DrawIcon(iconDelete, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.mueblesDataGridView.Rows[e.RowIndex].Height = iconDelete.Height + 8;
                this.mueblesDataGridView.Columns[e.ColumnIndex].Width = iconDelete.Width + 8;


                e.Handled = true;
            }

            if (e.ColumnIndex >= 0 && this.mueblesDataGridView.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell editarButton = this.mueblesDataGridView.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;

                Icon iconEdit = new Icon(Environment.CurrentDirectory + @"\\edit.ico");
                e.Graphics.DrawIcon(iconEdit, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.mueblesDataGridView.Rows[e.RowIndex].Height = iconEdit.Height + 8;
                this.mueblesDataGridView.Columns[e.ColumnIndex].Width = iconEdit.Width + 8;

                e.Handled = true;
            }
        }

        public void refrescarGrilla()
        {
            this.refrescar();
        }
    }
}
