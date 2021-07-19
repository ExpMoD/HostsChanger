using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hosts_changer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            if (!IsAdministrator())
            {
                MessageBox.Show("Необходимы права администратора", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            InitializeComponent();
            

            Hosts.Instance.GetData();

            DisplayData();
        }


        public static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
                    .IsInRole(WindowsBuiltInRole.Administrator);
        }

        public void DisplayData()
        {
            int RecordCount = Hosts.Instance.HostRecords.Count;

            GridViewHosts.Rows.Clear();

            for (int i = 0; i < RecordCount; i++)
            {
                HostRecord hostRecord = Hosts.Instance.HostRecords[i];

                GridViewHosts.Rows.Add(hostRecord.Ip, hostRecord.Domain);
            }
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            Hosts.Instance.GetData();

            DisplayData();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Hosts.Instance.HostRecords.Clear();
            for (int i = 0; i < GridViewHosts.Rows.Count; i++)
            {
                DataGridViewRow selectedRow = GridViewHosts.Rows[i];
                string ipValue = Convert.ToString(selectedRow.Cells["ColumnIp"].Value);
                string domainValue = Convert.ToString(selectedRow.Cells["ColumnDomain"].Value);

                if (ipValue.Length > 0 && domainValue.Length > 0)
                    Hosts.Instance.HostRecords.Add(new HostRecord(ipValue, domainValue));
            }

            Hosts.Instance.Save();

            MessageBox.Show("Файл сохранён");
        }

        private void ButtonSortUp_Click(object sender, EventArgs e)
        {
            if (GridViewHosts.SelectedRows.Count == 1)
            {
                int currentIndex = GridViewHosts.SelectedRows[0].Index;
                
                if (currentIndex > 0)
                {
                    DataGridViewRow selectedRow = GridViewHosts.Rows[currentIndex];
                    string ipValue = Convert.ToString(selectedRow.Cells["ColumnIp"].Value);
                    string domainValue = Convert.ToString(selectedRow.Cells["ColumnDomain"].Value);

                    GridViewHosts.Rows.RemoveAt(GridViewHosts.SelectedRows[0].Index);
                    GridViewHosts.Rows.Insert(currentIndex - 1, ipValue, domainValue);

                    for (int i = 0; i < GridViewHosts.Rows.Count; i++)
                        GridViewHosts.Rows[i].Selected = false;

                    GridViewHosts.Rows[currentIndex - 1].Selected = true;
                }
            }
        }

        private void ButtonSortDown_Click(object sender, EventArgs e)
        {
            if (GridViewHosts.SelectedRows.Count == 1)
            {
                int currentIndex = GridViewHosts.SelectedRows[0].Index;

                if (currentIndex < GridViewHosts.Rows.Count - 2)
                {
                    DataGridViewRow selectedRow = GridViewHosts.Rows[currentIndex];
                    string ipValue = Convert.ToString(selectedRow.Cells["ColumnIp"].Value);
                    string domainValue = Convert.ToString(selectedRow.Cells["ColumnDomain"].Value);

                    GridViewHosts.Rows.RemoveAt(GridViewHosts.SelectedRows[0].Index);
                    GridViewHosts.Rows.Insert(currentIndex + 1, ipValue, domainValue);

                    for (int i = 0; i < GridViewHosts.Rows.Count; i++)
                        GridViewHosts.Rows[i].Selected = false;

                    GridViewHosts.Rows[currentIndex + 1].Selected = true;
                }
            }
        }
    }
}
