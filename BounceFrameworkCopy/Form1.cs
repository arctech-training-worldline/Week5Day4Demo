using System.Windows.Forms;

namespace BounceFrameworkCopy
{
    public partial class Form1 : Form
    {
        private const int TotalFootBalls = 5;
        private FootBall[] _footBall;
        private bool _bounceStarted;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    {
                        if (!_bounceStarted)
                        {
                            _bounceStarted = true;
                            for (var i = 0; i < _footBall.Length; i++)
                            {
                                _footBall[i] = new FootBall(this);
                                _footBall[i].Bounce();
                            }
                        }

                        break;
                    }
                case MouseButtons.Right:
                    {
                        if (_bounceStarted)
                        {
                            _bounceStarted = false;
                            foreach (var footBall in _footBall)
                            {
                                footBall.StopBounce();
                            }
                        }

                        break;
                    }
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            _footBall = new FootBall[TotalFootBalls];
        }
    }
}
