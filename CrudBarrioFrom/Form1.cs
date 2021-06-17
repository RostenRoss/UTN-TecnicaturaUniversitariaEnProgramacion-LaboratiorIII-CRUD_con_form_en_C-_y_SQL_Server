using CrudBarrioFrom.presentacion;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrudBarrioFrom
{
    public partial class Form1 : Form
    {
        private string cerrarBoton = "cerrar";

        public Form1()
        {
            InitializeComponent();
        }

        private void casasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            refrescar();
            this.Validate();
            this.casasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            refrescar();
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
            btnDelete.Name = "Eliminar";
            btnEditar.Name = "Editar";
            btnVer.Name = "Ver";
            this.casasDataGridView1.Columns.Add(btnDelete);
            this.casasDataGridView1.Columns.Add(btnEditar);
            this.casasDataGridView1.Columns.Add(btnVer);
        }

        private void casasDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refrescar()
        {
            this.casasTableAdapter.Fill(this.dataSet1.casas);

        }

        private void agregarBtnClick(object sender, EventArgs e)
        {
            AddCasaForm formCasa = new AddCasaForm();
            formCasa.ShowDialog();
            refrescar();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void casasDataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.casasDataGridView1.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell deleteButton = this.casasDataGridView1.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;

                Icon iconDelete = new Icon(Environment.CurrentDirectory + @"\\delete.ico");

                e.Graphics.DrawIcon(iconDelete, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.casasDataGridView1.Rows[e.RowIndex].Height = iconDelete.Height + 8;
                this.casasDataGridView1.Columns[e.ColumnIndex].Width = iconDelete.Width + 8;


                e.Handled = true;
            }

            if (e.ColumnIndex >= 0 && this.casasDataGridView1.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell editarButton = this.casasDataGridView1.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;

                Icon iconEdit = new Icon(Environment.CurrentDirectory + @"\\edit.ico");
                e.Graphics.DrawIcon(iconEdit, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.casasDataGridView1.Rows[e.RowIndex].Height = iconEdit.Height + 8;
                this.casasDataGridView1.Columns[e.ColumnIndex].Width = iconEdit.Width + 8;

                e.Handled = true;
            }

            if (e.ColumnIndex >= 0 && this.casasDataGridView1.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell verButton = this.casasDataGridView1.Rows[e.RowIndex].Cells["Ver"] as DataGridViewButtonCell;

                Icon iconReview = new Icon(Environment.CurrentDirectory + @"\\review.ico");
                e.Graphics.DrawIcon(iconReview, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.casasDataGridView1.Rows[e.RowIndex].Height = iconReview.Height + 8;
                this.casasDataGridView1.Columns[e.ColumnIndex].Width = iconReview.Width + 8;

                e.Handled = true;
            }
        }


        private void casasDataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("colum" + this.casasDataGridView1.Columns[e.ColumnIndex].Name);

            if (this.casasDataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                long id = getId();
                if (id != 0)
                {
                    this.tableAdapterManager.casasTableAdapter.deleteById(id);
                    refrescar();
                }
            }

            if (this.casasDataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                long id = getId();
                if (id != 0)
                {
                    AddCasaForm casaForm = new AddCasaForm(id, this);
                    casaForm.ShowDialog();
                }
                refrescar();
            }

            if (this.casasDataGridView1.Columns[e.ColumnIndex].Name == "Ver")
            {
                long id = getId();
                if (id != 0)
                {
                    CasaInformacionCompleta casaInfo = new CasaInformacionCompleta(id);
                    casaInfo.ShowDialog();
                }
            }
        }


        private long getId()
        {
            try
            {
                return long.Parse(casasDataGridView1.Rows[casasDataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return 0;
            }
        }

        public void refrescarGrilla()
        {
            refrescar();
        }

        private void padres_Click(object sender, EventArgs e)
        {
            FmPadre formPadre = new FmPadre(this);
            formPadre.Show();
            if (((Button)sender).Name == padresBtn.Name)
            {
                this.cerrarBoton = ((Button)sender).Name;
            }
            this.Hide();
        }

        private void children_Click(object sender, EventArgs e)
        {
            FmHijo formHijo =new FmHijo(this);
            formHijo.Show();
            if (((Button)sender).Name == childrenBtn.Name)
            {
                this.cerrarBoton = ((Button)sender).Name;
            }
            this.Hide();
        }

        private void services_Click(object sender, EventArgs e)
        {
            FmServicio formServicio = new FmServicio(this);
            formServicio.Show();
            if (((Button)sender).Name == servicesBtn.Name)
            {
                this.cerrarBoton = ((Button)sender).Name;
            }
            this.Hide();
        }

        private void petBtn_Click(object sender, EventArgs e)
        {
            FmMascota formMascota = new FmMascota(this);
            formMascota.Show();
            if (((Button)sender).Name == petBtn.Name)
            {
                this.cerrarBoton = ((Button)sender).Name;
            }
            this.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void showForm() 
        {
            this.Show();
        }

        private void exteriorBtn_Click(object sender, EventArgs e)
        {
            FmExterior formExterior = new FmExterior(this);
            formExterior.Show();
            if (((Button)sender).Name == exteriorBtn.Name)
            {
                this.cerrarBoton = ((Button)sender).Name;
            }
            this.Hide();
        }

        private void interiorBtn_Click(object sender, EventArgs e)
        {
            FmHabitacion formHabitacion = new FmHabitacion(this);
            formHabitacion.Show();
            if (((Button)sender).Name == interiorBtn.Name)
            {
                this.cerrarBoton = ((Button)sender).Name;
            }
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FmMuebles formMuebles= new FmMuebles(this);
            formMuebles.Show();
            if (((Button)sender).Name == mueblesBtn.Name)
            {
                this.cerrarBoton = ((Button)sender).Name;
            }
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.cerrarBoton == "cerrar")
            {
                Application.Exit();
            }
        }
    }
}
