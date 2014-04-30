using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PathManager
{
    public partial class Form1 : Form
    {
        private string _userPathVar;
        private string _systemPathVar;
        private BindingList<PathRow> _userRows;
        private BindingList<PathRow> _systemRows; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cellLinkStyle = new DataGridViewCellStyle
                                {
                                    ForeColor = Color.DodgerBlue, // RHCP
                                    Font = new Font(dgvSystem.Font, FontStyle.Underline)
                                };

            dgvUser.AutoGenerateColumns = false;
            dgvUser.ColumnHeadersVisible = false;
            dgvUser.RowHeadersVisible = false;
            dgvUser.AllowUserToResizeRows = false;
            dgvUser.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Path", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvUser.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Open", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, DefaultCellStyle = cellLinkStyle });
            dgvUser.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Edit", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, DefaultCellStyle = cellLinkStyle });
            dgvUser.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Remove", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, DefaultCellStyle = cellLinkStyle });
            
            dgvSystem.AutoGenerateColumns = false;
            dgvSystem.ColumnHeadersVisible = false;
            dgvSystem.RowHeadersVisible = false;
            dgvSystem.AllowUserToResizeRows = false;
            dgvSystem.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Path", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvSystem.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Open", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, DefaultCellStyle = cellLinkStyle });
            dgvSystem.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Edit", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, DefaultCellStyle = cellLinkStyle });
            dgvSystem.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Remove", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, DefaultCellStyle = cellLinkStyle });
            

            _userPathVar = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User);
            _systemPathVar = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Machine);

            if (_userPathVar == null)
                _userPathVar = "";
            if (_systemPathVar == null)
                _systemPathVar = "";

            var pathSplitter = new char[] {';'};
            var userPaths = _userPathVar.Split(pathSplitter, StringSplitOptions.RemoveEmptyEntries);
            var systemPaths = _systemPathVar.Split(pathSplitter, StringSplitOptions.RemoveEmptyEntries);

            updateGrids(userPaths, systemPaths);
        }

        private void updateGrids(string[] userPaths, string[] systemPaths)
        {
            updateUserGrid(userPaths);
            updateSystemGrid(systemPaths);
        }

        private void updateUserGrid(string[] userPaths)
        {
            _userRows = new BindingList<PathRow>();

            foreach (var userPath in userPaths)
            {
                var newRow = new PathRow {Path = userPath};
                _userRows.Add(newRow);
            }

            dgvUser.DataSource = _userRows;
        }

        private void updateSystemGrid(string[] systemPaths)
        {
            _systemRows = new BindingList<PathRow>();

            foreach (var systemPath in systemPaths)
            {
                var newRow = new PathRow {Path = systemPath};
                _systemRows.Add(newRow);
            }

            dgvSystem.DataSource = _systemRows;
        }

        private void dgvUser_MouseEnter(object sender, EventArgs e)
        {
            dgvUser.Focus();
        }

        private void dgvSystem_MouseEnter(object sender, EventArgs e)
        {
            dgvSystem.Focus();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            handleCellClick(dgvUser, e);
        }

        private void dgvSystem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            handleCellClick(dgvSystem, e);
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtUser.Text))
            {
                MessageBox.Show("Invalid Directory Path!");
                return;
            }
            var newRow = new PathRow {Path = txtUser.Text};
            _userRows.Add(newRow);

            txtUser.Text = "";
        }

        private void btnSystemAdd_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtSystem.Text))
            {
                MessageBox.Show("Invalid Directory Path!");
                return;
            }
            var newRow = new PathRow {Path = txtSystem.Text};
            _systemRows.Add(newRow);

            txtSystem.Text = "";
        }

        private void btnUserSave_Click(object sender, EventArgs e)
        {
            var newPathVar = generateNewPathVar(dgvUser);
            var fileName = Path.GetTempPath() + Guid.NewGuid() + ".txt";

            using (var writer = File.CreateText(fileName))
            {
                writer.WriteLine("Original User PATH variable:");
                writer.WriteLine(_userPathVar);
                writer.WriteLine("");
                writer.WriteLine("Proposed User PATH variable:");
                writer.WriteLine(newPathVar);
                writer.WriteLine("");
                writer.WriteLine("");
                writer.WriteLine("Close this file to proceed. You will have the chance to cancel.");
            }

            var p = new Process {StartInfo = {FileName = fileName}};
            p.Start();
            p.WaitForExit();

            var mbRes = MessageBox.Show("Your User PATH variable will be modified. Do you wish to proceed?", "Notice!",
                MessageBoxButtons.YesNo);
            if (mbRes != DialogResult.Yes)
            {
                return;
            }

            Environment.SetEnvironmentVariable("PATH", newPathVar, EnvironmentVariableTarget.User);

            MessageBox.Show("User PATH Variable modified successfully!", "Notice!");
        }

        private void btnSystemSave_Click(object sender, EventArgs e)
        {
            var newPathVar = generateNewPathVar(dgvSystem);
            var fileName = Path.GetTempPath() + Guid.NewGuid() + ".txt";

            using (var writer = File.CreateText(fileName))
            {
                writer.WriteLine("Original System PATH variable:");
                writer.WriteLine(_systemPathVar);
                writer.WriteLine("");
                writer.WriteLine("Proposed System PATH variable:");
                writer.WriteLine(newPathVar);
                writer.WriteLine("");
                writer.WriteLine("");
                writer.WriteLine("Close this file to proceed. You will have the chance to cancel.");
            }

            var p = new Process { StartInfo = { FileName = fileName } };
            p.Start();
            p.WaitForExit();

            var mbRes = MessageBox.Show("Your System PATH variable will be modified. Do you wish to proceed?", "Notice!",
                MessageBoxButtons.YesNo);
            if (mbRes != DialogResult.Yes)
            {
                return;
            }

            Environment.SetEnvironmentVariable("PATH", newPathVar, EnvironmentVariableTarget.Machine);

            MessageBox.Show("System PATH Variable modified successfully!", "Notice!");
        }

        private string generateNewPathVar(DataGridView dgv)
        {
            var ret = "";
            foreach (DataGridViewRow row in dgv.Rows)
            {
                ret += row.Cells[0].Value + ";";
            }
            return ret;
        }

        private void handleCellClick(DataGridView dgv, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:
                    openFolder(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                    break;
                case 2:
                    editItem(dgv, e.RowIndex);
                    break;
                case 3:
                    removeItem(dgv, e.RowIndex);
                    break;
            }
        }

        private void openFolder(string folderPath)
        {
            var prc = new Process
                      {
                          StartInfo = {FileName = folderPath}
                      };
            prc.Start();
        }

        private void editItem(DataGridView dgv, int row)
        {
            var mbResult = MessageBox.Show("This item will be deleted and placed into the 'Add' field.", "Notice",
                MessageBoxButtons.OKCancel);

            if (mbResult == DialogResult.Cancel)
                return;

            if (dgv.Name == "dgvUser")
            {
                txtUser.Text = dgv.Rows[row].Cells[0].Value.ToString();
            }
            else
            {
                txtSystem.Text = dgv.Rows[row].Cells[0].Value.ToString();
            }

            removeItem(dgv, row);
        }

        private void removeItem(DataGridView dgv, int row)
        {
            dgv.Rows.Remove(dgv.Rows[row]);
        }

        private void userDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop, false) ? DragDropEffects.All : DragDropEffects.None;
        }

        private void userDragDrop(object sender, DragEventArgs e)
        {
            var paths = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
            if (paths.Length > 0)
            {
                if (File.GetAttributes(paths[0]).HasFlag(FileAttributes.Directory))
                {
                    txtUser.Text = paths[0];
                }
            }
        }

        private void systemDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop, false) ? DragDropEffects.All : DragDropEffects.None;
        }

        private void systemDragDrop(object sender, DragEventArgs e)
        {
            var paths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (paths.Length > 0)
            {
                if (File.GetAttributes(paths[0]).HasFlag(FileAttributes.Directory))
                {
                    txtSystem.Text = paths[0];
                }
            }
        }
    }

    public class PathRow
    {
        public string Path { get; set; }
        public string Open { get; set; }
        public string Edit { get; set; }
        public string Remove { get; set; }

        public PathRow()
        {
            Path = "path";
            Open = "open";
            Edit = "edit";
            Remove = "remove";
        }
    }
}

// TODO on dgv update, highlight nonexistent paths and add tooltip explanation