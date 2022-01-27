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

        public FootBall(Form form)
        {
            _form = form;
        }

        public void Bounce()
        {
            var thread = new Thread(WorkerThreadBounceBall);
            thread.Start();
        }

        private void WorkerThreadBounceBall()
        {
            var pictureBox = CreatePictureBoxWithFootBallImage();

            var random = new Random();

            var x = random.Next(0, _form.Width - pictureBox.Width);
            var y = random.Next(0, _form.Height - pictureBox.Height);
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
                var rightImaginaryLine = _form.Width - pictureBox.Width;
                var bottomImaginaryLine = _form.Height - pictureBox.Height;

                if (position.X < 0 || position.X > rightImaginaryLine)
                    xFactor = -xFactor;

                if (position.Y < 0 || position.Y > bottomImaginaryLine)
                    yFactor = -yFactor;

                pictureBox.Invoke((MethodInvoker)delegate
                {
                    pictureBox.Left = position.X;
                    pictureBox.Top = position.Y;
                });

                Thread.Sleep(10);

            } while (true);
        }

        private PictureBox CreatePictureBoxWithFootBallImage()
        {
            var pictureBoxFootBall = new PictureBox();
            pictureBoxFootBall.Left = 100;
            pictureBoxFootBall.Top = 100;
            pictureBoxFootBall.ImageLocation = @"C:\Users\avina\OneDrive - arctechinfo.com\Documents\Training\Sessions\C#\27-Jan-2022\Week5Day4\Week5Day4Demo\football.jpg";
            pictureBoxFootBall.SizeMode = PictureBoxSizeMode.AutoSize;

            // Cannot do this in Thread. Have to use invoke
            //_form.Controls.Add(pictureBoxFootBall);

            _form.Invoke((MethodInvoker)delegate
            {
                _form.Controls.Add(pictureBoxFootBall);
            });

            return pictureBoxFootBall;
        }
    }
}