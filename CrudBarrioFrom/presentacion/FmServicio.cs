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
    public partial class FmServicio : Form
    {
        private int tipoServicio =1;
        private Form principal;
        private FormClosingEventArgs formClosingEventArgs;

        private string cerrarBoton = "cerrar";
        public FmServicio()
        {
            InitializeComponent();
        }
        public FmServicio(Form principal)
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

        private void FmServicio_FormClosing(object sender, FormClosingEventArgs e)
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
        private void FmServicio_Load(object sender, EventArgs e)
        {
            rellenarCaja();
            agergarBotones();
        }

        private void agergarBotones() 
        {
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
;
            btnDelete.Name = "Eliminar";
      
            this.serviciosGridView.Columns.Add(btnDelete);           
        }

        private void rellenarCaja()
        {
            serviciosGridView.DataSource = null;
            switch (this.tipoServicio) 
            {
                case 1:
                    serviciosGridView.DataSource = this.servicioElectricidadTableAdapter.GetData();
                    serviciosGridView.AutoResizeColumns();
                    break;
                case 2:
                    serviciosGridView.DataSource = this.servicioCableTableAdapter.GetData();
                    serviciosGridView.AutoResizeColumns();
                    break;
                case 3:
                    serviciosGridView.DataSource = this.servicioAguaTableAdapter.GetData();
                    serviciosGridView.AutoResizeColumns(); 
                    break;
                case 4:
                    serviciosGridView.DataSource = this.servicioInternetTableAdapter.GetData();
                    serviciosGridView.AutoResizeColumns(); 
                    break;
            }
           
        }
        public void refrescar()
        {
            this.rellenarCaja();
        }

        private void cableServBtn_Click(object sender, EventArgs e)
        {
            this.tipoServicio = 2;
            rellenarCaja();
        }

        private void internetServBtn_Click(object sender, EventArgs e)
        {
            this.tipoServicio = 4;
            rellenarCaja();
        }

        private void aguaServBtn_Click(object sender, EventArgs e)
        {
            this.tipoServicio = 3;
            rellenarCaja();
        }

        private void electricidadServBtn_Click(object sender, EventArgs e)
        {
            this.tipoServicio = 1;
            rellenarCaja();
        }

        private void serviciosGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
          
            if (e.ColumnIndex >= 0 && this.serviciosGridView.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell deleteButton = this.serviciosGridView.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;

                Icon iconDelete = new Icon(Environment.CurrentDirectory + @"\\delete.ico");

                e.Graphics.DrawIcon(iconDelete, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.serviciosGridView.Rows[e.RowIndex].Height = iconDelete.Height + 8;
                this.serviciosGridView.Columns[e.ColumnIndex].Width = iconDelete.Width + 8;


                e.Handled = true;
            }

        }
        private long getId()
        {
            try
            {
                return long.Parse(serviciosGridView.Rows[serviciosGridView.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return 0;
            }
        }
        private void serviciosGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("colum" + this.serviciosGridView.Columns[e.ColumnIndex].Name);

            if (this.serviciosGridView.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                long id = getId();
                if (id != 0)
                {
                    this.tableAdapterManager.casasTableAdapter.deleteById(id);
                    rellenarCaja();
                }
            }
           
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {            
            switch (this.tipoServicio)
            {
                case 1:
                    
                    AddServicioLuz agregarLuz = new AddServicioLuz(this);
                    agregarLuz.ShowDialog();
                    break;
                case 2:
                    AddServicioCable agregarCable = new AddServicioCable(this);
                    agregarCable.ShowDialog();
                    break;
                case 3:
                    AddServicioAgua agregarAgua = new AddServicioAgua(this);
                    agregarAgua.ShowDialog();
                    break;
                case 4:
                    AddServicioInternet agregarInternet = new AddServicioInternet(this);
                    agregarInternet.ShowDialog();
                    break;
            }
        }
    }
}
