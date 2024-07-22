using System;
using System.Windows.Forms;

namespace SSOPrecinctEditor {
    public partial class FMain : Form {
        private Precinct precinct;
        private string filename;
        public FMain() {
            InitializeComponent();
        }

        private void openMenu_Click(object sender, EventArgs e) {
            precinct = new Precinct();

            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.Filter = "sev files (*.sev)|*.sev";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    string filePath = openFileDialog.FileName;
                    filename = filePath;

                    loadPrecinct();
                    enableControls();
                }
            }
        }

        private void enableControls() {
            btAdd.Enabled = true;
            btRemove.Enabled = true;
            btEdit.Enabled = true;
            saveMenu.Enabled = true;
        }

        private void disableControls() {
            btAdd.Enabled = false;
            btRemove.Enabled = false;
            btEdit.Enabled = false;
            saveMenu.Enabled = false;
        }

        public void updatePrecinctData() {
            edtVersion.Text = precinct.version.ToString();
            edtZoneCount.Text = precinct.zones.Count.ToString();
            edtBuildTime.Text = Precinct.convertTimeTToString(precinct.buildTime);
            precinct.zoneCount = precinct.zones.Count;

            grid.Rows.Clear();

            lbStatus.Text = "File: " + filename;

            for (var i = 0; i < precinct.zones.Count; i++) {
                var zone = precinct.zones[i];

                grid.Rows.Add(
                   i.ToString(),
                   zone.coordinates.Count.ToString(),
                   zone.priority.ToString(),
                   zone.dstInstance.ToString(),
                   zone.srcInstance.ToString(),
                   zone.domainId.ToString()
                );
            }
        }

        private void loadPrecinct() {
            precinct = new Precinct();
            precinct.loadFromFile(filename);

            updatePrecinctData();
        }

        private void btEdit_Click(object sender, EventArgs e) {
            if (grid.SelectedRows.Count == 0) return;

            var index = grid.SelectedRows[0].Index;

            var fzone = new FZone(this, precinct.zones[index]);
            fzone.ShowDialog();

            updatePrecinctData();
        }

        private void btAdd_Click(object sender, EventArgs e) {
            var zone = Zone.template();

            var fzone = new FZone(this, zone);
            fzone.ShowDialog();

            precinct.zones.Add(zone);
            updatePrecinctData();
        }

        private void btRemove_Click(object sender, EventArgs e) {
            if (grid.SelectedRows.Count == 0) return;

            var result = MessageBox.Show("Are you sure you want to remove this item?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) {
                var index = grid.SelectedRows[0].Index;

                precinct.zones.RemoveAt(index);
                grid.Rows.RemoveAt(index);

                updatePrecinctData();
            }
        }

        private void exitMenu_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void saveMenu_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "SEV files (*.sev)|*.sev";
            saveFileDialog.Title = "Save an SEV File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                var filename = saveFileDialog.FileName;
                if (filename != "") {
                    precinct.saveToFile(filename);

                    MessageBox.Show("Precinct file saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
