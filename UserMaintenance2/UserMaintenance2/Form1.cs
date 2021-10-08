using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace UserMaintenance2
{
    public partial class Form1 : Form
    {
        RealEstateEntities context = new RealEstateEntities();
        List<Flat> Flats;

        public Form1()
        {
            InitializeComponent();
            LoadData(); 
        }

        private void LoadData()
        {
            Flats = context.Flat.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
