using System;
using System.Drawing;
using System.Windows.Forms;

using ZedGraph;

namespace Lab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            graphControl.GraphPane.Title.Text = "Нормальная случайная величина";
            graphControl.GraphPane.XAxis.Title.Text = "X";
            graphControl.GraphPane.YAxis.Title.Text = "F(x), f(x)";
        }

        private void btnDrawGraph_Click(object sender, EventArgs e)
        {
            try
            {
                double me = double.Parse(tbMathExpectation.Text.Replace('.', ','));
                double d = double.Parse(tbDispersion.Text.Replace('.', ','));

                double x0 = (double)nudFrom.Value;
                double xf = (double)nudTo.Value;

                var rValue = new NormalDistribution(me, d);
                var dValues = rValue.DensityFunctionRange(x0, xf, 1000);
                var fValues = rValue.DistributionFunctionRange(x0, xf, 1000);

                GraphPane pane = graphControl.GraphPane;
                pane.CurveList.Clear();

                PointPairList flist = new PointPairList();
                foreach ((double x, double y) in fValues)
                {
                    flist.Add(new PointPair(x, y));
                }
                pane.AddCurve("", flist, Color.Red, SymbolType.None);

                PointPairList dlist = new PointPairList();
                foreach ((double x, double y) in dValues)
                {
                    dlist.Add(new PointPair(x, y));
                }
                pane.AddCurve("", dlist, Color.Blue, SymbolType.None);


                graphControl.AxisChange();
                graphControl.Invalidate();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, String.Empty,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
