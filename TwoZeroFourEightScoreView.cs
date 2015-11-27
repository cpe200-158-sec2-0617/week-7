using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class TwoZeroFourEightScoreView : Form, View
    {
        Model model;
        Controller controller;
        public TwoZeroFourEightScoreView()
        {
            InitializeComponent();
            model = new TwoZeroFourEightModel();
            model.AttachObserver(this);
            controller = new TwoZeroFourEightController();
        }

        void View.Notify(Model m)
        {
            Score.Text = "Total Score : " + ((TwoZeroFourEightModel)m).score.ToString();
        }
    }
}
