namespace lab1;

public partial class ChangingRhombusForm : Form
{
    private readonly Point[] _dirs = new Point[] { new(-1, 0), new(0, -1), new(1, 0), new(0, 1) };
    private readonly float _rhombusSize = 50;
    private readonly float _step = 0.1f;
    private readonly PointF DEFAULT_DELTA = new(1, 1);
    private PointF _delta;

    public ChangingRhombusForm()
    {
        InitializeComponent();
        pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        _delta = DEFAULT_DELTA;
    }

    private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Right)
        {
            return;
        }

        _delta = DEFAULT_DELTA;
        var bitmap = (Bitmap)pictureBox1.Image;
        DrawRhombus(bitmap);
        pictureBox1.Image = bitmap;
    }

    private void DrawRhombus(Bitmap bitmap)
    {
        Pen pen = new(Color.Black);
        Brush brush = new SolidBrush(Color.Red);
        PointF startPoint = new(pictureBox1.Width / 2, pictureBox1.Height / 2);
        var points = _dirs.Select(d => new PointF(startPoint.X + _delta.X * d.X * _rhombusSize, startPoint.Y + _delta.Y * d.Y * _rhombusSize)).ToArray();
        using var graphics = Graphics.FromImage(pictureBox1.Image);
        graphics.Clear(Color.White);
        graphics.DrawPolygon(pen, points);
        graphics.FillPolygon(brush, points);
    }

    private void ChangingRhombusForm_KeyDown(object sender, KeyEventArgs e)
    {

    }

    public void ChangingRhombusForm_KeyPress(object sender, KeyPressEventArgs e)
    {
        switch (e.KeyChar)
        {
            case 'I':
                _delta.X += _step;
                break;
            case 'O':
                _delta.X -= _step;
                break;
            case 'K':
                _delta.Y += _step;
                break;
            case 'L':
                _delta.Y -= _step;
                break;
            case 'q':
                Clear();
                return;
            default:
                return;
        }

        if (_delta.X < 0 || _delta.Y < 0)
        {
            _delta = DEFAULT_DELTA;
        }

        var bitmap = (Bitmap)pictureBox1.Image;
        DrawRhombus(bitmap);
        pictureBox1.Image = bitmap;
    }

    private void Clear()
    {
        var bitmap = (Bitmap)pictureBox1.Image;
        using var graphics = Graphics.FromImage(bitmap);
        graphics.Clear(Color.White);
        pictureBox1.Image = bitmap;
    }
}
