using static System.Runtime.InteropServices.JavaScript.JSType;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    int arrMin(int[] data) => data.Min();
    int arrMax(int[] data) => data.Max();

    private void btnCalc_Click(object sender, EventArgs e)
    {
        int[] data = new int[6];
        TextBox[] boxes = { txt1, txt2, txt3, txt4, txt5, txt6 };
        for (int i = 0; i < data.Length; i++)
            data[i] = int.Parse(boxes[i].Text);

        lblMin.Text = $"最小值：{arrMin(data)}";
        lblMax.Text = $"最大值：{arrMax(data)}";
    }
}