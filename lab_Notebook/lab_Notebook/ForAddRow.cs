using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab_Notebook
{ 

    public partial class ForAddRow : Form
    {
        public DataView dataView;
        public ForAddRow()
        {
            InitializeComponent();
        }

        private void ForAddRow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkWithDataBase notebook = new WorkWithDataBase();
            MyNotebook form = new MyNotebook();
            
              dataView = new DataView(form.AuthorsDataSet.Tables["notebook"]);
            string fileName = "notebook.xml";

            notebook.AddNewDataRowView(dataView);
        }
    }
}
