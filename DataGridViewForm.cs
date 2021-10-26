using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathVectorCharts
{
    public partial class DataGridViewForm : Form
    {
        public DataGridViewForm(List<string> columns, List<List<string>> rows)
        {
            InitializeComponent();
            foreach (var col in columns)
            {
                dataGridView1.Columns.Add(col, col);
            }
            foreach (var rowCells in rows)
            {
                int indexRow = dataGridView1.Rows.Add();
                for (int i = 0; i < rowCells.Count; i++)
                {
                    dataGridView1.Rows[indexRow].Cells[i].Value = rowCells[i];
                }
            }
        }
    }
}
