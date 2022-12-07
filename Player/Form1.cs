using Service;

namespace Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CsvServices c = new CsvServices();
            List<string> values = c.getCSVData();

            dataGridView1.DataSource = values.Select(@v => new { @v }).ToList() ;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}