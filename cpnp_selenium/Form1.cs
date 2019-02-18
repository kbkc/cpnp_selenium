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


using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Reflection;
using NHibernate;
using ExcelDataReader; // how to: https://github.com/ExcelDataReader/ExcelDataReader
using NHibernate.SqlCommand;






namespace cpnp_selenium
{
    public partial class Form1 : Form
    {
        TextWriter _writer = null;

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Open cpnp - site wits label alert on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_to_cpnp_click(object sender, EventArgs e)
        {
            this.TopMost = true;
            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;
            this.txtConsole.Text += "\r\ncpnp is opens now, wait, please.....";
            

            ProcClasses.login_to_cpnp();

            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;
            this.txtConsole.Text += "\r\ncpnp site is opened.\r\n";
            this.TopMost = false;
            this.label4.Visible = false;
            this.dgvCpnpList.Visible = true;


            // place task file to DataGridView
            task_to_grid(tb_task_fname.Text, dgv_task);
        }
        //

        private void on_close(object sender, FormClosingEventArgs e)
        {
            if (ProcClasses.brw != null)
            {
                ProcClasses.brw.Quit();
                ProcClasses.brw = null;
            }
        }

        private void product_open(object sender, EventArgs e)
        {

            if (ProcClasses.brw != null)
            {
                this.txtConsole.AppendText(ProcClasses.open_product(ProcClasses.brw, "2288818")); //ReformA Gelpolish Tenerife BEF28D26D853D0CDC564821B9BE2B8D8 2288818
            }
            else MessageBox.Show("login to cpnp, please");

        }


        /// <summary>

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Load(object sender, EventArgs e)
        {
            Table_to_GridView();
            /// ---------------------------------------------------
            ///              Redirect console output
            /// ---------------------------------------------------
            _writer = new TextBoxStreamWriter(txtConsole);
            Console.SetOut(_writer);
            //Console.WriteLine("Now redirecting output to the text box");
            /// ---------------------------------------------------
        }

        // --------------   console redirect output example   ----------------
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hi there!");
        }

        private void Table_to_GridView()
        {
            Cpnp CpnpAlias = null;
            CpnpProd1s CpnpProd1SAlias = null;

            ISession session = Models.NHibernateHelper.OpenSession();
            dgvCpnpList.DataSource = session.QueryOver<Cpnp>(() => CpnpAlias).List();
            dgvCpnp1sList.DataSource = session.QueryOver<CpnpProd1s>(() => CpnpProd1SAlias).List();

        }

        private void GetCpnpData(object sender, DataGridViewCellMouseEventArgs e)
        {
           if (ProcClasses.brw != null)
            {
               // if (e.ColumnIndex == 1)
                    ProcClasses.open_product(
                    ProcClasses.brw,
                    dgvCpnpList[1, e.RowIndex].Value.ToString());
                this.btDouble.Enabled = true;


                txtConsole.AppendText("\r\nopen "+ dgvCpnpList[1, e.RowIndex].Value.ToString());

            }
            else MessageBox.Show("login to cpnp, please");
        }

        private void product_dublicate(object sender, EventArgs e)
        {
            if (ProcClasses.brw != null)
            {
               
                ProcClasses.dublicate_product(ProcClasses.brw);
                txtConsole.AppendText("\r\nopen dublicated product ");


            }

        }

        /// <summary>
        ///  Read from Excell to list list string  // how to: https://github.com/ExcelDataReader/ExcelDataReader
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xls_to_gridview_Click(object sender, EventArgs e)
        {
            task_to_grid(tb_task_fname.Text, dgv_task);
          
        }

        private void task_to_grid(string fname, DataGridView dgv)
        {
            using (var stream = File.Open(fname, FileMode.Open, FileAccess.Read))
            {
                txtConsole.AppendText("\r\n" + "open file : " + tb_task_fname.Text);

                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx)
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {

                    // Choose one of either 1 or 2:

                    //// var 1 is working
                    //// 1. Use the reader methods
                    //List<List<string>> task = new List<List<string>>();
                    //do
                    //{
                    //    while (reader.Read())
                    //    {
                    //        List<string> s = new List<string>();
                    //        for (int i = 0; i < reader.FieldCount; i++) s.Add(reader.GetValue(i).ToString());
                    //        // txtConsole.Text+="\r\n"+  reader...GetString(3);//.GetDouble(0);
                    //        task.Add(s);
                    //    }
                    //} while (reader.NextResult());
                    //foreach(List<string> s in task) txtConsole.Text += "\r\n" + String.Join("\t", s.ToArray());

                    // var 2 is working
                    // 2. Use the AsDataSet extension method
                    var result = reader.AsDataSet();
                    var dataTable = result.Tables[0];
                    // The result of each spreadsheet is in result.Tables

                    dgv.AutoGenerateColumns = true;
                    dgv.DataSource = dataTable;

                    // if first row = field name:
                    for (int i = 0; i < dgv.ColumnCount; i++) dgv.Columns[i].HeaderText = dgv[i, 0].Value.ToString();
                    dgv.Rows.Remove(dgv.Rows[0]);
                    // end var 2

                }


            }




        }



        /// <summary>
        /// main cycle for adding product from task list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_product_click(object sender, EventArgs e)
        {
            try
            {
                int i = 0; // 0,1,2

                for (i =Convert.ToInt32(tb_from.Text); i <= Convert.ToInt32(tb_to.Text); i++)
                {

                    // open dublicated product
                    System.Threading.Thread.Sleep(2000);
                    ProcClasses.open_product(ProcClasses.brw, tb_cpnp_num.Text);    //"2288818");
                    System.Threading.Thread.Sleep(2000);

                    // dublicate
                    ProcClasses.dublicate_product(ProcClasses.brw);
                    System.Threading.Thread.Sleep(2000);
                    txtConsole.AppendText("\r\nopen dublicated product ");



                    List<string> task_list = new List<string>();
                    foreach (DataGridViewCell s in dgv_task.Rows[i].Cells)
                    {
                        task_list.Add(s.Value.ToString());
                        txtConsole.AppendText("\r\n" + s.ColumnIndex.ToString() + "\t" + s.Value.ToString());//.GetDouble(0);
                    }
                    cpnp_rules.edit_dublicated_product_rules(ProcClasses.brw, task_list);






                }








            }
            catch(Exception ex)
            {
                txtConsole.AppendText("\r\n" + ex.ToString());

            }

        }
    }
}
