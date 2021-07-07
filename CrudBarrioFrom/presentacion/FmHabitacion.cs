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
    public partial class FmHabitacion : Form
    {
        private string cerrarBoton="cerrar";
        private Form principal;
        public FmHabitacion()
        {
            InitializeComponent();
        }
        public FmHabitacion(Form principal)
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

        private void habitacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.habitacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FmHabitacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.habitacion' Puede moverla o quitarla según sea necesario.
            refrescar();
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnDelete.Name = "Eliminar";
            btnEditar.Name = "Editar";
            this.habitacionDataGridView.Columns.Add(btnDelete);
            this.habitacionDataGridView.Columns.Add(btnEditar);

        }

        private void FmHabitacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.cerrarBoton == "cerrar")
            {
                this.principal.Close();
            }
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

        private void children_Click(object sender, EventArgs e)
        {
            FmHijo fmHijo = new FmHijo(this.principal);
            fmHijo.Show();
            if (((Button)sender).Name == childrenBtn.Name)
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

        private void casas_Click(object sender, EventArgs e)
        {
            
            this.principal.Show();
            if (((Button)sender).Name == casasBtn.Name)
            {
                this.cerrarBoton = ((Button)sender).Name;
            }
            this.Close();
        }

        private void muebles_Click(object sender, EventArgs e)
        {
            FmMuebles fmMuebles = new FmMuebles(this.principal);
            fmMuebles.Show();
            if (((Button)sender).Name == mueblesBtn.Name)
            {
                this.cerrarBoton = ((Button)sender).Name;
            }
            this.Close();
        }

        private void habitacionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.habitacionDataGridView.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                long id = getId();
                if (id != 0)
                {
                    habitacionTableAdapter.DeleteHabitacionById(id);
                    refrescar();
                }
            }

            if (this.habitacionDataGridView.Columns[e.ColumnIndex].Name == "Editar")
            {
                long id = getId();
                if (id != 0)
                {
                    AddHabitacion agregarPadreFm = new AddHabitacion(id, this);
                    agregarPadreFm.ShowDialog();
                }
                refrescar();
            }
        }

        private void habitacionDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.habitacionDataGridView.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell deleteButton = this.habitacionDataGridView.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;

                Icon iconDelete = new Icon(Environment.CurrentDirectory + @"\\delete.ico");

                e.Graphics.DrawIcon(iconDelete, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.habitacionDataGridView.Rows[e.RowIndex].Height = iconDelete.Height + 8;
                this.habitacionDataGridView.Columns[e.ColumnIndex].Width = iconDelete.Width + 8;


                e.Handled = true;
            }

            if (e.ColumnIndex >= 0 && this.habitacionDataGridView.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell editarButton = this.habitacionDataGridView.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;

                Icon iconEdit = new Icon(Environment.CurrentDirectory + @"\\edit.ico");
                e.Graphics.DrawIcon(iconEdit, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.habitacionDataGridView.Rows[e.RowIndex].Height = iconEdit.Height + 8;
                this.habitacionDataGridView.Columns[e.ColumnIndex].Width = iconEdit.Width + 8;

                e.Handled = true;
            }
        }
        private long getId()
        {
            try
            {
                return long.Parse(habitacionDataGridView.Rows[habitacionDataGridView.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return 0;
            }
        }

        private void refrescar()
        {
            this.habitacionTableAdapter.Fill(this.dataSet1.habitacion);

        }

        public void refrescarGrilla() { refrescar(); }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            AddHabitacion agregarHabitacion = new AddHabitacion();
            agregarHabitacion.ShowDialog();
            refrescar();
        }
    }
}
