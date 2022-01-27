using System;
using System.Windows.Forms;

namespace Week5Day4Demo
{
    public partial class FormBouncyBallAnimation : Form
    {
        public FormBouncyBallAnimation()
        {
            InitializeComponent();
        }

        private void FormBouncyBallAnimation_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < 5; i++)
            {
                var footBall = new FootBall(this);
                footBall.Bounce();
            }
        }
    }
}
