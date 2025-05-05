namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] nums = new int[5];
            Random rnd = new Random();

            for (int i = 0; i < nums.Length; i++)
                nums[i] = rnd.Next(1, 201);

            Array.Sort(nums);
            lblMin.Text = string.Join(", ", nums);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

        }
    }
}
