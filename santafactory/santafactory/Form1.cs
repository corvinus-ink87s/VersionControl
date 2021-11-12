using santafactory.Abstractions;
using santafactory.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace santafactory
{
    public partial class Form1 : Form
    {

        private List<Toy> _toys = new List<Toy>();
        Toy _nextToy;
        private IToyFactory _ToyFactory;

        public IToyFactory BallFactory
        {
            get { return _ToyFactory; }
            set { _ToyFactory = value; displayNext(); }
        }

        internal PresentFactory Factory { get; private set; }
        public BallFactory ToyFactory { get; }

        public Form1()
        {
            InitializeComponent();
            ToyFactory = new BallFactory();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var toy = (Toy)BallFactory.CreateNew();
            _toys.Add(toy);
            toy.Left = -toy.Width;
            mainPanel.Controls.Add(toy);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var ball in _toys)
            {
                ball.MoveToy();
                if (ball.Left > maxPosition)
                    maxPosition = ball.Left;
            }

            if (maxPosition > 1000)
            {
                var oldestBall = _toys[0];
                mainPanel.Controls.Remove(oldestBall);
                _toys.Remove(oldestBall);
            }
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            ToyFactory = new CarFactory();
        }

        private void btnBall_Click(object sender, EventArgs e)
        {
            ToyFactory = new BallFactory()
            { 
            BallColor = btnColor.BackColor
            };

        }
        private void displayNext()
        {
            if (_nextToy != null)
            {
                this.Controls.Remove(_nextToy);
            }
                _nextToy = ToyFactory.CreateNew();
                _nextToy.Left = lblNext.Left + lblNext.Width;
                _nextToy.Top = lblNext.Top;
                this.Controls.Add(_nextToy);
            
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var cd = new ColorDialog();
            cd.Color = button.BackColor;

            if (cd.ShowDialog()!= DialogResult.OK)
            {
                return;
            }
            button.BackColor = cd.Color;
        }

        private void btnPresent_Click(object sender, EventArgs e)
        {
            Factory = new PresentFactory
            {
                RibbonColor = colorRibbon.BackColor,
                BoxColor = colorBox.BackColor,
            };
        }
    }
}
