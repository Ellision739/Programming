using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics.View.Forms
{
    public partial class AddDiscountForm : Form
    {
        // Событие, оповещающее, что добавлена новая скидка
        public event Action<string> DiscountAdded;
        public AddDiscountForm()
        {
            InitializeComponent();
            CategoryComboBox.SelectedIndex = 0;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            string discountInfo = CategoryComboBox.Text;
            DiscountAdded ?.Invoke(discountInfo);
            Close();
        }
    }
}
