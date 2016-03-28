using System.Xml;
using System.Data;
using System.Windows.Forms;
using System.Text;
namespace lab_Notebook
{
    class WorkWithDataBase
    {
              
        public void   sort(DataView dataView)
        {
            MyNotebook form = new MyNotebook();
            dataView.Sort = "Surname";
            form.dgv1.DataSource = dataView;
        }
        public void load( string filepath)
        {
           
        }

        public void find(string propertyForFind, DataView dataView)
        {
            dataView.Sort = "recordName";
            int index = dataView.Find(propertyForFind);
            if (index == -1)
            {
                MessageBox.Show("Nothing was found");
            }
            else
            {
                MyNotebook form = new MyNotebook();
             //  form.dgv1.ClearSelection();
               //form.dgv1.Rows[index].Selected = true;
                MessageBox.Show(dataView[index]["recordName"].ToString() + " " + dataView[index]["Surname"].ToString() + " " + dataView[index]["City"].ToString() + " " + dataView[index]["PhoneNumber"].ToString());
            }
        }

        public void deleterow(DataView dataView, int currentRow)
        {
            string textofcurrentRow = dataView[currentRow]["recordName"].ToString();
            if (MessageBox.Show("Would you like to delete person " + textofcurrentRow, "form closing", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataView.Delete(currentRow);
                MyNotebook form = new MyNotebook();
                form.dgv1.DataSource = dataView;
            }
        }
        public void filter(DataView dataView, string finding)
        {
            MyNotebook form = new MyNotebook();
          
            
            //dataView.RowFilter = "Surname like '%" + form.textBox2.Text + "%'";
            form.dgv1.Dispose();
            dataView.RowFilter = "Surname like '" + form.textBox2.Text + "%'";
            form.dgv1.DataSource = dataView;           
                form.dgv1.DataSource= dataView;        
            
         }
        public void addSave(DataView dataView, string fileName)
        {
            XmlWriter xmlFileW;
            xmlFileW = XmlWriter.Create(fileName);
            dataView.ToTable("notebook");
            MyNotebook form = new MyNotebook();
            form.AuthorsDataSet.WriteXml(xmlFileW);
            xmlFileW.Close();
        }
    }
}
