using System.Windows.Forms;
using System.Xml.Linq;
using Tyuiu.MoskalevEA.Sprint6.Task7.V27.Lib;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.MokslaevEA.Sprint6.Task7.V27
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filepath)
        {
            string filedata = File.ReadAllText(filepath);
            filedata = filedata.Replace('\n', '\r');
            string[] lines = filedata.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] array = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return array;
        }






        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void button_Save_Click(object sender, EventArgs e)
        {

            saveFileDialog1.FileName = "OutPutFileTask7.csv";
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.ShowDialog();

            string path = saveFileDialog1.FileName;



            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridView_Res.RowCount;
            int columns = dataGridView_Res.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridView_Res.Rows[i].Cells[j].Value + ";";

                    }
                    else
                    {
                        str += dataGridView_Res.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }









        }

        private void button_Imput_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;

            int[,] array = new int[rows, columns];
            array = LoadFromFileData(openFilePath);
            dataGridView_Imput.ColumnCount = columns;
            dataGridView_Imput.RowCount = rows;
            dataGridView_Res.ColumnCount = columns;
            dataGridView_Res.RowCount = rows;


            for (int i = 0; i < columns; i++)
            {
                dataGridView_Imput.Columns[i].Width = 25;
                dataGridView_Res.Columns[i].Width = 25;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView_Imput.Rows[i].Cells[j].Value = array[i, j];

                }
            }
            array = ds.GetMatrix(openFilePath);
            button_Go.Enabled = true;

        }

        private void button_Go_Click(object sender, EventArgs e)
        {
            int[,] array = new int[rows, columns];
            array = ds.GetMatrix(openFilePath);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView_Res.Rows[i].Cells[j].Value = array[i, j];
                }
            }

            button_Save.Enabled = true;

        }

        private void button_Spr_Click(object sender, EventArgs e)
        {

        }
    }
}
