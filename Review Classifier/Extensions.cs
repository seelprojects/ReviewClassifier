using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Review_Classifier
{
    public static class Extensions
    {
        public static void SetColumnSortMode(this DataGridView dataGridView, DataGridViewColumnSortMode sortMode)
        {
            foreach (var column in dataGridView.Columns)
            {
                //column.SortMode = sortMode;
            }
        }
    }
}
