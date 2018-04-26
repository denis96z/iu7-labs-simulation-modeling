using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MainForm : Form
    {
        private const int TABLE_CELL_SIZE = 60;

        public MainForm()
        {
            InitializeComponent();

            dgvTable.Font = new Font(dgvTable.Font.FontFamily,
                8, FontStyle.Bold);

            dgvTable.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvTable.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.EnableResizing;

            dgvTable.RowHeadersWidth = TABLE_CELL_SIZE;
            dgvTable.ColumnHeadersHeight = TABLE_CELL_SIZE;

            tbNumConditions_Scroll(null, null);
        }

        private void tbNumConditions_Scroll(object sender, EventArgs e)
        {
            int numConditions = tbNumConditions.Value;

            dgvTable.RowCount = dgvTable.ColumnCount = numConditions;

            Font boldFont = new Font(dgvTable.Font.FontFamily,
                dgvTable.Font.Size, FontStyle.Bold);

            for (int i = 0; i < numConditions; i++)
            {
                dgvTable.Columns[i].Width = dgvTable.Rows[i].Height = TABLE_CELL_SIZE;

                dgvTable.Columns[i].HeaderCell.Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvTable.Rows[i].HeaderCell.Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvTable.Columns[i].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                dgvTable.Columns[i].Name = (string)(dgvTable.Rows[i]
                    .HeaderCell.Value = "S" + i.ToString());
                dgvTable.Columns[i].HeaderCell.Style.Font = dgvTable
                    .Rows[i].HeaderCell.Style.Font = boldFont;
            }

            lbSolution.Items.Clear();
        }

        private void btnRandomFillTable_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < tbNumConditions.Value; i++)
            {
                for (int j = 0; j < tbNumConditions.Value; j++)
                {
                    double value = r.NextDouble();

                    if (i == j || value == 0)
                    {
                        dgvTable[i, j].Value = null;
                    }
                    else
                    {
                        dgvTable[i, j].Value = value;
                    }
                }
            }
            lbSolution.Items.Clear();
        }

        private void dgvTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTable[e.ColumnIndex, e.RowIndex].Value?.ToString() == "0")
            {
                dgvTable[e.ColumnIndex, e.RowIndex].Value = null;
            }
            lbSolution.Items.Clear();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                int n = tbNumConditions.Value;
                double[,] lambda = new double[n, n];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        string value = dgvTable[j, i].Value?.ToString().Replace('.', ',');
                        lambda[i, j] = value != null ? double.Parse(value) : 0;
                    }
                }

                double[] solution = new States().Solve(lambda);

                lbSolution.Items.Clear();
                for (int i = 0; i < n; i++)
                {
                    lbSolution.Items.Add("t" + i + "=" + solution[i]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, String.Empty,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
