using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace lab_Notebook
{
    
    public partial class MyNotebook : Form
    {
        public MyNotebook()
        {
            InitializeComponent();
        }

        public DataView dataView;
        public int currentRow;
      
        private void Form1_Load(object sender, EventArgs e)
        {
            // load database 
            string filepath = "notebook.xml";

            AuthorsDataSet.ReadXml(filepath);
           dgv1.DataSource = AuthorsDataSet;
            dgv1.DataMember = "notebook";         
            dgv1.AutoResizeColumns();
                              
           
           
            //add record


        }

        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sort on surname
            WorkWithDataBase notebook = new WorkWithDataBase();
            dataView = new DataView(AuthorsDataSet.Tables["notebook"]);
            notebook.sort(dataView);            
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //find on name
            WorkWithDataBase notebook = new WorkWithDataBase();
            dataView = new DataView(AuthorsDataSet.Tables["notebook"]);
            string propertyForFind;
            propertyForFind = textBox1.Text;
            notebook.find(propertyForFind, dataView);
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //delete row
            dataView = new DataView(AuthorsDataSet.Tables["notebook"]);
            WorkWithDataBase notebook = new WorkWithDataBase();
            notebook.deleterow(dataView, currentRow);
        }

        private void dgv1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            currentRow = e.RowIndex;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataView = new DataView(AuthorsDataSet.Tables["notebook"]);
            //WorkWithDataBase notebook = new WorkWithDataBase();
            //string finding = textBox2.Text;
            //notebook.filter(dataView, finding);
            listBox1.Visible = true;
            listBox1.Items.Clear();
            dataView.RowFilter = "Surname like '" + textBox2.Text + "%'";
        for (int i = 0; i<= dataView.Count - 1; i++)
        { listBox1.Items.Add(dataView[i]["Surname"]); }
       
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataView = new DataView(AuthorsDataSet.Tables["notebook"]);
            WorkWithDataBase notebook = new WorkWithDataBase();
            string finding = textBox2.Text;
            notebook.filter(dataView, finding);
        }

        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv1.ReadOnly = false;
            MessageBox.Show("Чтобы добавить запись необходимо ввести желаемые значения в таблицу и нажать на Save");

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataView = new DataView(AuthorsDataSet.Tables["notebook"]);
            WorkWithDataBase notebook = new WorkWithDataBase();
            string fileName = "notebook.xml";
            notebook.addSave(dataView, fileName);
        }

       
    }
}
