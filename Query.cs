using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace File_System_Monitor
{
    public partial class Query : Form
    {
        //Member variables
        SQLiteDataReader sqlite_datareader;
        
        public Query()
        {
            InitializeComponent();
        }

        private void maskExtension_TextChanged(object sender, EventArgs e)
        {
            if (maskExtension.Text == "*.*")
                maskExtension.Mask = "*.&";
            else
                maskExtension.Mask = "*.&??";
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if(maskExtension.Text == "*.")
            {
                MessageBox.Show("Valid extension required","Invalid Extension");
                return;
            }
            if(maskExtension.Text == "*.*")
            {
                // First lets build a SQL-Query again:
               // this.sqlite_cmd.CommandText = "SELECT * FROM test";
            }

            // Now the SQLiteCommand object can give us a DataReader-Object:
            //this.sqlite_datareader=sqlite_cmd.ExecuteReader();

            // The SQLiteDataReader allows us to run through the result lines:
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                // Print out the content of the text field:
                System.Console.WriteLine( sqlite_datareader["text"] );
            }
        }

        private void maskExtension_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lvQuery_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblExtension_Click(object sender, EventArgs e)
        {

        }
    }
}
