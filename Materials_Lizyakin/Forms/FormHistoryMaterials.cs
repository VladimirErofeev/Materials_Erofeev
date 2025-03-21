using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Materials_Erofeev
{
    public partial class FormHistoryMaterials : Form
    {
        private int _id;

        public FormHistoryMaterials(int id)
        {
            InitializeComponent();
            _id = id;
            using (Models.AppContext db = new Models.AppContext())
            {
                string name = db.Suppliers.Where(i => i.Id == id).Select(i => i.Name).First();
                labelSupplier.Text = $"История поставок: {name}";
            }                
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            using (Models.AppContext db = new Models.AppContext())
            {
                DGVHistorySupplies.DataContext = db.HistorySupplies
                    .Include(i => i.IdMaterialNavigation)
                    .Where(i => i.Id == _id)
                    .Select(i => new
                    {
                        i.Id,
                        i.IdMaterialNavigation.Name,
                        i.AmountOnePackage,
                        i.AmountOfPackages,
                        i.Date,
                        i.CostPerPackage,
                        i.QualitySupply
                    })
                    .OrderBy(i => i.Id)
                    .ToList();
            }
        }
    }
}
