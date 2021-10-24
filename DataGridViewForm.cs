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
        public DataGridViewForm(DataGridView dataGridView)
        {
            InitializeComponent();
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView1.Columns.Add(dataGridView.Columns[i].Name, dataGridView.Columns[i].HeaderText);
            }
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                int indexRow = dataGridView1.Rows.Add();
                for (int j = 0; j < dataGridView.Rows[i].Cells.Count; j++)
                {
                    dataGridView1.Rows[indexRow].Cells[j].Value = dataGridView.Rows[i].Cells[j].Value;
                }
            }
        }
    }
}
