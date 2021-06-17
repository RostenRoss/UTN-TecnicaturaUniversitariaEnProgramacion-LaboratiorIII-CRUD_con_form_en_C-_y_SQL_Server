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
    public partial class CasaInformacionCompleta : Form
    {
        private long id = 0;
        public CasaInformacionCompleta(long id)
        {
            InitializeComponent();
            this.id = id;
        }
        public CasaInformacionCompleta()
        {
            InitializeComponent();
        }

        private void CasaInformacionCompleta_Load(object sender, EventArgs e)
        {
            this.casasTableAdapter.Fill(this.dataSet1.casas);
            rellenarCaja(this.id);
        }

        private void casasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.casasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void rellenarCaja(long id) 
        {
            DataTable data = this.casasTableAdapter.GetCasaFullInformationById(id);
            gridCasaInformacionCompleta.DataSource = data;
            gridCasaInformacionCompleta.AutoResizeColumns();
        }

    }
}
