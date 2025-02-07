namespace prakt12
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

        private void button1_Click(object sender, EventArgs e)
        {
            List<Flower> flowers = new List<Flower>();
            string name = textBox1.Text;
            string type = textBox2.Text;
            string shade = textBox3.Text;
            string country = textBox4.Text;
            decimal price = decimal.Parse(textBox5.Text);
            int Length = int.Parse(textBox6.Text);
            Flower flower = new Flower(name, type, shade, country, price, Length);
            listbox1.Items.Add("=== Информация о цветке ===");
            listbox1.Items.Add(flower.GetInfo());
            listbox1.Items.Add(flower.Cost(5)); // Пример для 5 цветов
            listbox1.Items.Add(flower.IsExpensive());
            listbox1.Items.Add(""); // Пустая строка для разделения

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

        }

        private void listbox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
