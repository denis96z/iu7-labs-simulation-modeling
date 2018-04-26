using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Lab3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            dgvTable.ColumnCount = 7;
            dgvTable.RowCount = 1;

            SetColNames();
        }

        private void SetColNames()
        {
            dgvTable.Columns[0].Name = "Табл. 1р";
            dgvTable.Columns[1].Name = "Табл. 2р";
            dgvTable.Columns[2].Name = "Табл. 3р";

            dgvTable.Columns[3].Name = "Мат. 1р";
            dgvTable.Columns[4].Name = "Мат. 2р";
            dgvTable.Columns[5].Name = "Мат. 3р";

            dgvTable.Columns[6].Name = "Польз. посл.";
        }

        private void btnFillTable_Click(object sender, EventArgs e)
        {
            SetColNames();

            dgvTable.RowCount = tbSequenceLength.Value;

            var tRandomizer = new TableRandomizer();
            var mRandomizer = new MathRandomizer();
            for (int i = 0; i < tbSequenceLength.Value; i++)
            {
                dgvTable[0, i].Value = tRandomizer.RandomOneDigit();
                dgvTable[1, i].Value = tRandomizer.RandomTwoDigit();
                dgvTable[2, i].Value = tRandomizer.RandomThreeDigit();

                dgvTable[3, i].Value = mRandomizer.RandomOneDigit();
                dgvTable[4, i].Value = mRandomizer.RandomTwoDigit();
                dgvTable[5, i].Value = mRandomizer.RandomThreeDigit();
            }
        }

        private void btnEstimateRandomness_Click(object sender, EventArgs e)
        {
            SetColNames();

            try
            {
                int[] sequence = new int[dgvTable.RowCount];
                IRandomnessEstimator randEstimator = new RandomnessEstimator();

                for (int col = 0; col < 6; col++)
                {
                    for (int row = 0; row < dgvTable.RowCount; row++)
                    {
                        sequence[row] = int.Parse(dgvTable[col, row].Value.ToString());
                    }

                    int range = (int)Math.Pow(10, (col % 3) + 1);
                    double p = randEstimator.ApplyToSequence(sequence, range);
                    dgvTable.Columns[col].Name += " (" + (p * 100).ToString() + "%)";
                }

                var userSequence = new List<int>();
                for (int row = 0; row < dgvTable.RowCount; row++)
                {
                    if (dgvTable[6, row].Value == null)
                    {
                        break;
                    }
                    userSequence.Add(int.Parse(dgvTable[6, row].Value.ToString()));
                }

                int userRange = int.Parse(Interaction.InputBox(
                    "Количество различных чисел: ", String.Empty, ""));
                double pUser = randEstimator.ApplyToSequence(userSequence.ToArray(), userRange);
                dgvTable.Columns[6].Name += " (" + (pUser * 100).ToString() + "%)";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
