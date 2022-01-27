using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Week5Day4Demo
{
    /// <summary>
    /// 1. Create a PictureBox with a Football image.. done
    /// 2. Move it around using maths formula.. done
    /// 3. Use Thread
    /// </summary>
    internal class FootBall
    {
        private readonly Form _form;
        private readonly PictureBox _pictureBox;

        public FootBall(Form form)
        {
            _form = form;
            _pictureBox = CreatePictureBoxWithFootBallImage();
        }

        public void Bounce()
        {
            var thread = new Thread(WorkerThreadBounceBall);
            thread.Start();
        }

        private void WorkerThreadBounceBall()
        {
            var random = new Random();

            var x = random.Next(0, _form.Width - _pictureBox.Width);
            var y = random.Next(0, _form.Height - _pictureBox.Height);
            var position = new Point(x, y);

            var xFactor = random.Next(5, 20);
            var yFactor = random.Next(5, 20);

            do
            {
                position.X += xFactor;
                position.Y += yFactor;

                // The imaginary line is used so the ball does not fully go
                // out of the window before bouncing back.
                // If we bounce the left and top of the ball on the imaginary line
                // the ball always stays visible inside the form
                var rightImaginaryLine = _form.Width - _pictureBox.Width;
                var bottomImaginaryLine = _form.Height - _pictureBox.Height;

                if (position.X < 0 || position.X > rightImaginaryLine)
                    xFactor = -xFactor;

                if (position.Y < 0 || position.Y > bottomImaginaryLine)
                    yFactor = -yFactor;

                _pictureBox.Invoke((MethodInvoker)delegate
                {
                    _pictureBox.Left = position.X;
                    _pictureBox.Top = position.Y;
                });

                Thread.Sleep(10);

            } while (true);
        }

        private PictureBox CreatePictureBoxWithFootBallImage()
        {
            var pictureBoxFootBall = new PictureBox
            {
                Left = 100,
                Top = 100,
                ImageLocation = @"C:\Users\avina\OneDrive - arctechinfo.com\Documents\Training\Sessions\C#\27-Jan-2022\Week5Day4\Week5Day4Demo\football.jpg",
                SizeMode = PictureBoxSizeMode.AutoSize
            };

            _form.Controls.Add(pictureBoxFootBall);

            return pictureBoxFootBall;
        }
    }
}