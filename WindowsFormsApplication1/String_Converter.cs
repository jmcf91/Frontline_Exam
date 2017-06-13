using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class String_Converter : Form
    {
        //using list so I don't have to declare set number of elements
        private List<string> formatList = new List<string>();

        public String_Converter()
        {
            InitializeComponent();
        }

        //button click from Form
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //original string
            string strVariable = "(id,created,employee(id,firstname,employeeType(id), lastname),location)";

            //removes parens and commas
            string tempString = strVariable.Replace('(', ' ').Replace(')', ' ').Replace(',',' ');

            //puts string items into list and removes blank spaces
            formatList = tempString.Split(' ').Where(l => l != "").ToList();

            //for loop to format and print string values
            for (int i = 0; i < formatList.Count(); i++)
            {
                //first three list records and last
                if (i < 3 || i == 8)
                {
                    lstBxResults.Items.Add(formatList[i]);
                }
                //for double dash record
                else if (i == 6)
                {
                    lstBxResults.Items.Add("-- " + formatList[i]);
                }
                //for single dash records
                else
                {
                    lstBxResults.Items.Add("- " + formatList[i]);
                }
            }
            //OUTPUTS
            //id
            //created
            //employee
            //- id
            //- firstname
            //- employeeType
            //-- id
            //- lastname
            //location
        }
    }
}
