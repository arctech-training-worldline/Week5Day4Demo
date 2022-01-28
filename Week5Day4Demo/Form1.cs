using System;
using System.Windows.Forms;

namespace Week5Day4Demo
{
    public partial class FormBouncyBallAnimation : Form
    {
        private const int TotalFootBalls = 5;
        private FootBall[] _footBall;
        private bool _bounceStarted;
        public FormBouncyBallAnimation()
        {
            InitializeComponent();
        }

        private void FormBouncyBallAnimation_Load(object sender, EventArgs e)
        {
            _footBall = new FootBall[TotalFootBalls];
        }

        private void FormBouncyBallAnimation_MouseUp(object sender, MouseEventArgs e)
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
    }
}
