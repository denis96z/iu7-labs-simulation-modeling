using System;
using System.Globalization;
using System.Windows.Forms;

namespace Lab6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            tbTimeInterval.Text = Constants.TimeInterval.ToString(CultureInfo.InvariantCulture);
            tbMaxQueueLength.Text = Constants.QueueLengthLimit.ToString(CultureInfo.InvariantCulture);
            tbMinArrivalInt.Text = Constants.MinClientArrivalTime.ToString(CultureInfo.InvariantCulture);
            tbMaxArrivalInt.Text = Constants.MaxClientArrivalTime.ToString(CultureInfo.InvariantCulture);
            tbMinStyleTime.Text = Constants.MinStyleTime.ToString(CultureInfo.InvariantCulture);
            tbMaxStyleTime.Text = Constants.MaxStyleTime.ToString(CultureInfo.InvariantCulture);
            tbMinDelay.Text = Constants.MinStylistDelay.ToString(CultureInfo.InvariantCulture);
            tbMaxDelay.Text = Constants.MaxStylistDelay.ToString(CultureInfo.InvariantCulture);
            tbTime.Text = Constants.SimulationTime.ToString(CultureInfo.InvariantCulture);
            tbClientHasStylistProb.Text = Constants.ClientHasStylistProbability.ToString(CultureInfo.InvariantCulture);
            lblResult.Text = String.Empty;
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            try
            {
                var model = new Model();
                model.TimeInterval = double.Parse(tbTimeInterval.Text.Replace('.', ','));
                model.QueueLengthLimit = int.Parse(tbMaxQueueLength.Text);
                model.ClientHasStylistProbability = double.Parse(tbClientHasStylistProb.Text.Replace('.', ','));
                model.MinClientArrivalTime = int.Parse(tbMinArrivalInt.Text);
                model.MaxClientArrivalTime = int.Parse(tbMaxArrivalInt.Text);
                model.MinStyleTime = int.Parse(tbMinStyleTime.Text);
                model.MaxStyleTime = int.Parse(tbMaxStyleTime.Text);
                model.MinStylistDelay = int.Parse(tbMinDelay.Text);
                model.MaxStylistDelay = int.Parse(tbMaxDelay.Text);

                int numStyles = int.Parse(tbNumStyles.Text);
                int numStylists = int.Parse(tbNumStylists.Text);
                model.Initialize(numStyles, numStylists);

                double simTime = double.Parse(tbTime.Text.Replace('.', ','));
                model.Simulate(simTime);

                double p = (double)model.ClientsDeclined /
                    (model.ClientsServed + model.ClientsDeclined);

                lblResult.Text = "Прибыло клиентов: " + model.ClientsArrived +
                                 Environment.NewLine + "Обслужено клиентов: " + model.ClientsServed +
                                 Environment.NewLine + "Отказов в обслуживании: " + model.ClientsDeclined +
                                 Environment.NewLine + "Вероятность отказа: " + p;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, String.Empty,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
