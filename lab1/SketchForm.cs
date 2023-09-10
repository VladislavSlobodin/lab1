namespace lab1;

public partial class SketchForm : Form
{
    public SketchForm()
    {
        InitializeComponent();
        pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
    }

    private void SketchForm_Load(object sender, EventArgs e)
    {
        var bitmap = (Bitmap)pictureBox1.Image;
        Draw(bitmap);
        pictureBox1.Image = bitmap;
    }

    private void Draw(Bitmap bitmap)
    {

    }
}
