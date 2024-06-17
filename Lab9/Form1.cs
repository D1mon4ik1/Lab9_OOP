using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab9OOP
{
    public partial class Form1 : Form
    {
        private float R, r, x0, y0;

        public Form1()
        {
            InitializeComponent();
            // ϳ��������� ��䳿 Paint �� ������ picGraph_Paint
            this.picGraph.Paint += new PaintEventHandler(this.picGraph_Paint);
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            // �������� �� ����������� �������� �������
            try
            {
                R = float.Parse(txtR.Text);
                r = float.Parse(txtRsmall.Text);
                x0 = float.Parse(txtX0.Text);
                y0 = float.Parse(txtY0.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("�������� �� ������� ����", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ������ Invalidate ��� ������������� PictureBox
            picGraph.Invalidate();
        }

        private void picGraph_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            Pen axisPen = new Pen(Color.Black);
            Pen tickPen = new Pen(Color.Gray);

            // ����� ���������
            int centerX = picGraph.Width / 2;
            int centerY = picGraph.Height / 2;

            // �������
            float scale = 30f;

            // ��������� ����
            g.DrawLine(axisPen, centerX, 0, centerX, picGraph.Height);
            g.DrawLine(axisPen, 0, centerY, picGraph.Width, centerY);

            // ��������� ������ �� ����
            Font font = new Font("Arial", 8);
            Brush brush = new SolidBrush(Color.Black);

            // ϳ����� �� �� X
            for (int i = -10; i <= 10; i++)
            {
                int x = centerX + (int)(i * scale);
                g.DrawLine(tickPen, x, centerY - 5, x, centerY + 5);
                g.DrawString(i.ToString(), font, brush, x - 10, centerY + 10);
            }

            // ϳ����� �� �� Y
            for (int i = -10; i <= 10; i++)
            {
                int y = centerY - (int)(i * scale);
                g.DrawLine(tickPen, centerX - 5, y, centerX + 5, y);
                g.DrawString(i.ToString(), font, brush, centerX + 10, y - 10);
            }

            // ���������� m
            float m = r / R;

            // ��������� ������������ �����
            Pen curvePen = new Pen(Color.Blue);
            float step = 0.01f; // ���� ��������� t
            for (float t = 0; t <= 2 * (float)Math.PI; t += step)
            {
                float x = (R - m * R) * (float)Math.Cos(m * t) + m * (float)Math.Cos(t - m * t);
                float y = (R - m * R) * (float)Math.Sin(m * t) - m * (float)Math.Sin(t - m * t);

                int plotX = (int)(centerX + x * scale);
                int plotY = (int)(centerY - y * scale);

                if (plotX >= 0 && plotX < picGraph.Width && plotY >= 0 && plotY < picGraph.Height)
                {
                    g.FillRectangle(new SolidBrush(Color.Blue), plotX, plotY, 1, 1);
                }
            }

            // ϳ���� �� �� X
            g.DrawString("X", font, brush, picGraph.Width - 20, centerY + 10);

            // ϳ���� �� �� Y
            g.DrawString("Y", font, brush, centerX + 10, 5);
        }
    }
}
