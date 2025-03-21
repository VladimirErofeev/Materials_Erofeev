using Materials_Erofeev.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Materials_Lizyakin.Forms
{
    public partial class FormEntry : System.Windows.Forms.Form
    {
        private Supplier? _supplier;
        private int _selectedTypeIndex;

        public FormEntry()
        {
            InitializeComponent();
            SetupTypes();
        }
        public FormEntry(int id)
        {
            InitializeComponent();
            SetupTypes();

            using (Models.AppContext db = new Models.AppContext())
            {
                _supplier = db.Suppliers.Where(i => i.Id == id).First();
                textBoxName.Text = _supplier.Name;
                textBoxTin.Text = _supplier.Tin;
            }
        }

        private void SetupTypes()
        {
            using (Models.AppContext db = new Models.AppContext())
            {
                List<TypesSupplier> supplierTypes = db.TypesSuppliers.OrderBy(o => o.Id).ToList();
                comboBoxType.DataSource = supplierTypes;
                comboBoxType.DisplayMember = "TypeSupplier";
                comboBoxType.ValueMember = "Id";

                if (_supplier != null)
                {
                    TypesSupplier type = db.TypesSuppliers.Where(i => i.Id == _supplier.IdTypeSupplier).First();
                    comboBoxType.SelectedIndex = supplierTypes.IndexOf(type);
                }
            }
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            if (_supplier != null)
            {
                using (Models.AppContext db = new Models.AppContext())
                {
                    _supplier.IdTypeSupplier = _selectedTypeIndex;
                    _supplier.Name = textBoxName.Text;
                    _supplier.Tin = textBoxTin.Text;

                    db.SaveChanges();
                    MessageBox.Show("Запись успешно обновлена");
                }
            }
            else
            {
                using (Models.AppContext db = new Models.AppContext())
                {
                    Supplier supplier = new Supplier();

                    supplier.IdTypeSupplier = _selectedTypeIndex;
                    supplier.Name = textBoxName.Text;
                    supplier.Tin = textBoxTin.Text;
                    supplier.IsWorking = true;
                    supplier.Id = db.Suppliers
                        .OrderByDescending(x => x.Id)
                        .Select(x => x.Id)
                        .First() + 1;

                    db.Suppliers.Add(supplier);
                    db.SaveChanges();
                    MessageBox.Show("Запись успешно создана");
                }
            }
            this.Close();
        }

        private void ComboBoxType_TextChanged(object sender, EventArgs e)
        {
            _selectedTypeIndex = comboBoxType.SelectedIndex + 1;
        }
    }
}
