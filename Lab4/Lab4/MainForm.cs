using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            tbGm.TextChanged += OnTextChanged;
            tbGd.TextChanged += OnTextChanged;
            tbOAm.TextChanged += OnTextChanged;
            tbOAd.TextChanged += OnTextChanged;

            rbDeltaT.CheckedChanged += OnMethodChanged;
            rbEvent.CheckedChanged += OnMethodChanged;
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            textBox.TextChanged -= OnTextChanged;

            if (textBox.Text.Length == 0)
            {
                textBox.ForeColor = Color.LightGray;
                textBox.Text = textBox.Name.Substring(textBox.Name.Length - 1);
            }
            else
            {
                textBox.ForeColor = Color.Black;
                if (textBox.Text.Contains('d'))
                {
                    textBox.Text = textBox.Text.Replace("d", String.Empty);
                    textBox.SelectionStart = textBox.Text.Length;
                    textBox.SelectionLength = 0;
                }
                if (textBox.Text.Contains('m'))
                {
                    textBox.Text = textBox.Text.Replace("m", String.Empty);
                    textBox.SelectionStart = textBox.Text.Length;
                    textBox.SelectionLength = 0;
                }
            }

            textBox.TextChanged += OnTextChanged;
        }

        private void OnValueChanged(object sender, EventArgs e)
        {
            lblOptQueueLen.Text = "Оптимальная длина очереди: ?";
        }

        private void OnMethodChanged(object sender, EventArgs e)
        {
            lblDt.Visible = rbDeltaT.Checked;
            tbDt.Visible = rbDeltaT.Checked;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(tbN.Text);
                double p = double.Parse(tbP.Text.Replace('.', ','));

                double gm = double.Parse(tbGm.Text.Replace('.', ','));
                double gd = double.Parse(tbGd.Text.Replace('.', ','));
                double oam = double.Parse(tbOAm.Text.Replace('.', ','));
                double oad = double.Parse(tbOAd.Text.Replace('.', ','));

                ITimeGenerator recvGen = new GaussTimeRandomizer(gm, gd);
                ITimeGenerator handleGen = new GaussTimeRandomizer(oam, oad);
                IDecisionRandomizer decRand = new StdDecisionRandomizer(p);

                ModelController modelController = null;
                if (rbDeltaT.Checked)
                {
                    double dt = double.Parse(tbDt.Text.Replace('.', ','));
                    modelController = new TimeModelController(recvGen, handleGen, n, decRand, dt);
                }
                else if (rbEvent.Checked)
                {
                    modelController = new EventModelController(recvGen, handleGen, n, decRand);
                }
                    
                modelController.Initialize();
                while (!modelController.Finished())
                {
                    modelController.MoveOn();
                }

                lblOptQueueLen.Text = "Оптимальная длина очереди: " + modelController.MaxQueueLength;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
