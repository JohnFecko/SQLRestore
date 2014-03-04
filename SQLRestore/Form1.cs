using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace SQLRestore
{
    public partial class c : Form
    {
        public c()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
            //var sqlRestore = GetSqlRestore(fileDialog.FileName);
            //var header = sqlRestore.ReadBackupHeader(GetServer());

            txtPath.Text = fileDialog.FileName;
            string file = fileDialog.FileName;
            if (file.Contains('\\'))
            {
                file = file.Substring(file.LastIndexOf('\\') + 1);
            }
            if (file.Contains(".bak"))
            {
                file = file.Replace(".bak", "");
            }
            txtDatabaseName.Text = file;
        }



        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtPath.Text))
                {
                    MessageBox.Show("No File Selected");
                    return;
                }
                else if (!File.Exists(txtPath.Text))
                {
                    MessageBox.Show("File Not Found");
                    return;
                }
                if (String.IsNullOrEmpty(txtDatabaseName.Text))
                {
                    MessageBox.Show("No Database Name Entered");
                    return;
                }
                string path = txtPath.Text;
                string name = txtDatabaseName.Text;

                Restore sqlRestore = new Restore { Database = name };
                Server sqlServer = GetServer();

                if (sqlServer.Databases[name] != null)
                {
                    if (
                        MessageBox.Show("Delete existing database?", "Confirm Delete", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        sqlServer.Databases[name].Drop();
                    }
                    else
                    {
                        return;
                    }
                }

                Database db = new Database (sqlServer, name);
                db.Create();

                BackupDeviceItem backupDevice = new BackupDeviceItem(path, DeviceType.File);

                sqlRestore.Action = RestoreActionType.Database;
                sqlRestore.Devices.Add(backupDevice);
                String dataFileLocation = db.FileGroups[0].Files[0].FileName;
                String logFileLocation = db.LogFiles[0].FileName;
                db = sqlServer.Databases[name];
                sqlServer.ConnectionContext.Disconnect();

                RelocateFile rf = new RelocateFile(sqlRestore.ReadFileList(sqlServer).Rows[0]["LogicalName"].ToString(), dataFileLocation);
                RelocateFile lf = new RelocateFile(sqlRestore.ReadFileList(sqlServer).Rows[1]["LogicalName"].ToString(), logFileLocation);

                sqlRestore.RelocateFiles.Add(rf);
                sqlRestore.RelocateFiles.Add(lf);

                ;

                sqlRestore.ReplaceDatabase = true;
                //sqlRestore.Complete += new ServerMessageEventHandler(sqlRestore_Complete);
                sqlRestore.SqlRestore(sqlServer);
                db = sqlServer.Databases[name];
                db.SetOnline();
                sqlServer.Refresh();
                MessageBox.Show("Restore Completed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Server GetServer()
        {
            SqlConnection dataConnection = new SqlConnection();

            ServerConnection connection = new ServerConnection(dataConnection);
            Server results = new Server(connection);
            return results;
        }

        private Restore GetSqlRestore(string file)
        {
            Restore sqlRestore = new Restore();

            BackupDeviceItem deviceItem = new BackupDeviceItem(file, DeviceType.File);
            sqlRestore.Devices.Add(deviceItem);
            return sqlRestore;
        }

    }
}
