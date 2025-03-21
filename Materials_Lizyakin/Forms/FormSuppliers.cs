using Materials_Erofeev.Forms;
using Materials_Erofeev.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace Materials_Erofeev
{
    public partial class FormSuppliers : Form
    {
        public FormSuppliers()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            using (Models.AppContext db = new Models.AppContext())
            {
                DGVSuppliers.DataSource = db.Suppliers
                    .Include(x => x.IdTypeSupplierNavigation)
                    .Select(x => new { x.Id, x.IdTypeSupplierNavigation.TypeSupplier, x.Name, x.Tin, x.IsWorking })
                    .OrderByDescending(x => x.Id)
                    .ToList();

                DGVSuppliers.Columns["Id"].Visible = false;

                DGVSuppliers.Columns["TypeSupplier"].HeaderText = "Типы партнёров";
                DGVSuppliers.Columns["Name"].HeaderText = "Наименование";
                DGVSuppliers.Columns["Tin"].HeaderText = "ИНН";
                DGVSuppliers.Columns["IsWorking"].HeaderText = "Актуальность";

                DataGridViewColumn columnQuality = new DataGridViewColumn(DGVSuppliers.Columns[0].CellTemplate);
                columnQuality.Name = "averageSupplier";
                columnQuality.HeaderText = "Среднее количество поставок";
                DGVSuppliers.Columns.Add(columnQuality);

                for (int i = 0; i < DGVSuppliers.RowCount; i++)
                {
                    int id = (int)DGVSuppliers.Rows[i].Cells["Id"].Value;

                    double avgQuality;
                    try
                    {
                        avgQuality = db.HistorySupplies
                        .Where(x => x.IdSupplier == id)
                        .Average(x => x.QualitySupply);
                    }
                    catch
                    {
                        avgQuality = 0;
                    }
                    DGVSuppliers.Rows[i].Cells["averageSupplier"].Value = avgQuality;

                    if (avgQuality < 6)
                    {
                        db.Suppliers.FirstOrDefault(x => x.Id == id).IsWorking = false;
                        db.SaveChanges();
                    }
                }
            }
        }

        private void ButtonHistory_Click(object sender, EventArgs e)
        {
            int rowIndex = DGVSuppliers.SelectedCells[0].RowIndex;
            int id = (int)(DGVSuppliers.Rows[rowIndex].Cells["Id"].Value);
            FormHistoryMaterials form = new FormHistoryMaterials(id);
            form.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormEntry entry = new FormEntry();
            entry.ShowDialog();
            DGVSuppliers.DataContext = null;
            OnLoad(new EventArgs());
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int rowIndex = DGVSuppliers.SelectedCells[0].RowIndex;
            int id = (int)(DGVSuppliers.Rows[rowIndex].Cells["Id"].Value);
            FormEntry entry = new FormEntry(id);
            entry.ShowDialog();
            DGVSuppliers.DataContext = null;
            OnLoad(new EventArgs());
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = DGVSuppliers.SelectedCells[0].RowIndex;
            int id = (int)(DGVSuppliers.Rows[rowIndex].Cells["Id"].Value);
            /*using (Models.AppContext db = new Models.AppContext())
            {
                db.Suppliers.Remove(i => i.Id == id);
                db.SaveChanges();
            }*/
        }
    }
}
