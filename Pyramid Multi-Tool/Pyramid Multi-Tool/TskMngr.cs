using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pyramid_Multi_Tool
{
    public partial class TskMngr : Form
    {
        public TskMngr()
        {
            InitializeComponent();
            // get a list of proccesses
            UpdateProcessList();
        }

        private void UpdateProcessList()

        {

            // clear the existing list of any items

            Process_List.Items.Clear();

            // loop through the running processes and add

            //each to the list

            foreach (System.Diagnostics.Process p in

            System.Diagnostics.Process.GetProcesses())

            {

                Process_List.Items.Add(p.ProcessName + " - " + p.Id);

            }

            // display the number of running processes in

            // a status message at the bottom of the page

            ProcessRunningNumber.Text = "Processes running: " +

            Process_List.Items.Count.ToString();

        }

        private void Update_Process_List_Button_Click(object sender, EventArgs e)
        {
            UpdateProcessList();
        }

        private void killToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // loop through the running processes looking for a match

            // by comparing process name to the name selected in the listbox

            foreach (System.Diagnostics.Process p in

            System.Diagnostics.Process.GetProcesses())

            {

                string[] arr = Process_List.SelectedItem.ToString().Split('-');

                string sProcess = arr[0].Trim();

                int iId = Convert.ToInt32(arr[1].Trim());

                if (p.ProcessName == sProcess && p.Id == iId)

                {

                    p.Kill();

                }

            }

            UpdateProcessList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Main().Show();
        }
    }
}
