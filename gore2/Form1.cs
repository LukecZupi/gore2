using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace gore2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = File.OpenText("gore.txt");
            //pripravimo tabelo nizov
            string[] tabela;
            string vrstica = sr.ReadLine();
            while (vrstica != null)
            {
                //razbijemo vrstico v tabelo
                tabela = vrstica.Split(';');
                //podatke iz tabele napolnimo v DGV
                dataGridView1.Rows.Add(tabela[0], tabela[1], tabela[2], 
                    Convert.ToBoolean(tabela[3]), Image.FromFile(tabela[0].ToLower() + ".jpg"), tabela[4]);
                //preberemo naslednjo vrstico
                vrstica = sr.ReadLine();
            }
            sr.Close();
        }
    }
}