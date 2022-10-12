using System.Data;
using System.Diagnostics;

namespace Task5
{
    public partial class Form1 : Form
    {
        DataTable table=new DataTable();
        List<Commodity> commodities = new List<Commodity>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Price", typeof(double));
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("Origin country", typeof(string));
            table.Columns.Add("Packaging date", typeof(string));
            dataGridView2.DataSource = table;
        }
        private void addCommodityInfo(Commodity commodity)
        {
            double price;
            commodity.Name = textBox1.Text;
            double.TryParse(textBox2.Text, out price);
            commodity.Price = price;
            commodity.Description = textBox3.Text;
            commodity.OriginCountry = textBox4.Text;
            commodity.PackagingDate = textBox5.Text;
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            double amount;
            addCommodityInfo(product);
            double.TryParse(textBox6.Text, out amount);
            product.Amount = amount;
            product.MesureUnit = textBox7.Text;
            product.ExpiryDate = textBox8.Text;
            commodities.Add(product);
            table.Rows.Add(product.Name, product.Price, product.Description,
                                        product.OriginCountry, product.PackagingDate);
            clearTextBoxes();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            int pages;
            addCommodityInfo(book);
            int.TryParse(textBox9.Text, out pages);
            book.Pages = pages; 
            book.Publisher = textBox10.Text;
            book.Authors = textBox11.Text;
            commodities.Add(book);
            table.Rows.Add(book.Name, book.Price, book.Description,
                                        book.OriginCountry, book.PackagingDate);
            clearTextBoxes();
        }
        private void clearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int index = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows.RemoveAt(index);
            clearTextBoxes();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    }
}