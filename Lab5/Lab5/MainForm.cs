using System;
using System.Windows.Forms;

namespace Lab5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            try
            {
                double timeInt = double.Parse(tbTimeInterval.Text.Replace('.', ','));

                Model model = new Model(timeInt);
                model.Restart();

                while (model.NumHandledRequests < 300)
                {
                    model.MoveOn();
                }

                double p = (double)model.NumDeclinedRequests / (model.NumHandledRequests + model.NumDeclinedRequests);

                lblReqHandled.Text = "Заявок обработано: " + model.NumHandledRequests.ToString();
                lblReqDeclined.Text = "Заявок отклонено: " + model.NumDeclinedRequests.ToString();
                lblModellingTime.Text = "Время моделирования: " + String.Format("{0:0.####}", model.CurrentTime);
                lblPDecline.Text = "Вероятность отказа: " + String.Format("{0:0.####}", p);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
