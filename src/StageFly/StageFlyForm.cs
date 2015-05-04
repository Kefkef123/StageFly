using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StageFly
{
    public partial class StageFlyForm : Form
    {
        public StageFlyForm()
        {
            InitializeComponent();
        }

        private async void SubmitButtom_Click(object sender, System.EventArgs e)
        {
            _playerId = Int32.Parse(PlayerIdTextBox.Text);
            _score = Int32.Parse(ScoreTextBox.Text);
        }

        private int _playerId;
        private int _score;
        private readonly string _apiEndPoint = "http://api.dancetourgos.nl";
    }
}