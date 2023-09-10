namespace lab1;

public partial class Form1 : Form
{
    private Form _activeForm = null!;
    private Size _prevSize;

    public Form1()
    {
        InitializeComponent();
        _prevSize = Size;
    }

    private void OpenForm(Form form)
    {
        CloseActiveForm();
        _activeForm = form;
        form.TopLevel = false;
        form.FormBorderStyle = FormBorderStyle.None;
        form.Dock = DockStyle.Fill;
        FormPanel.Controls.Add(form);
        FormPanel.Tag = form;
        form.BringToFront();
        form.Show();
    }

    private void CloseActiveForm() => _activeForm?.Close();

    private void ShowSketchButton_Click(object sender, EventArgs e) => OpenForm(new SketchForm());

    private void ShowChangingRhombusButton_Click(object sender, EventArgs e) => OpenForm(new ChangingRhombusForm());

    private void ShowGraphButton_Click(object sender, EventArgs e) => OpenForm(new GraphForm());

    private void label1_DoubleClick(object sender, EventArgs e) => CloseActiveForm();

    private void Form1_ResizeEnd(object sender, EventArgs e)
    {
        if (_activeForm is not GraphForm)
        {
            return;
        }

        Size diff = new(_prevSize.Width - Size.Width, _prevSize.Height - Size.Height);
        _prevSize = Size;
        (_activeForm as GraphForm)!.GraphForm_ResizeEnd(diff, e);
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {

    }

    private void Form1_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (_activeForm is not ChangingRhombusForm)
        {
            return;
        }

        (_activeForm as ChangingRhombusForm)!.ChangingRhombusForm_KeyPress(sender, e);
    }
}