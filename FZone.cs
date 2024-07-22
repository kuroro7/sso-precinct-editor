using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSOPrecinctEditor {
    public partial class FZone : Form {
        FMain fmain;
        Zone zone;
        public FZone(FMain fmain, Zone zone) {
            this.fmain = fmain;
            this.zone = zone;

            InitializeComponent();

            updateZoneData();
        }

        private void updateZoneData() {
            edtCoordsCount.Text = zone.coordinates.Count.ToString();
            edtPriority.Value = zone.priority;
            edtDstInstance.Value = zone.dstInstance;
            edtSrcInstance.Value = zone.srcInstance;
            edtDomainId.Value = zone.domainId;

            foreach (var cityPos in zone.cityPositions)
                gridCityPos.Rows.Add(
                    cityPos.factionMask.ToString(),
                    cityPos.mapId.ToString(),
                    cityPos.x.ToString(),
                    cityPos.y.ToString(),
                    cityPos.z.ToString()
                );

            foreach (var coord in zone.coordinates)
                gridCoordinates.Rows.Add(
                    coord.x.ToString(),
                    coord.y.ToString(),
                    coord.z.ToString()
                );
        }

        private void btSave_Click(object sender, EventArgs e) {
            zone.coordinatesCount = zone.coordinates.Count;
            zone.priority = (int)edtPriority.Value;
            zone.dstInstance = (int)edtDstInstance.Value;
            zone.srcInstance = (int)edtSrcInstance.Value;
            zone.domainId = (int)edtDomainId.Value;

            for (var i = 0; i < Zone.CITY_POS_COUNT; i++) {
                var row = gridCityPos.Rows[i];
                var cityPos = zone.cityPositions[i];

                cityPos.factionMask = Convert.ToInt32(row.Cells[0].Value);
                cityPos.mapId = Convert.ToInt32(row.Cells[1].Value);
                cityPos.x = Convert.ToSingle(row.Cells[2].Value);
                cityPos.y = Convert.ToSingle(row.Cells[3].Value);
                cityPos.z = Convert.ToSingle(row.Cells[4].Value);
            }

            for (var i = 0; i < zone.coordinates.Count; i++) {
                var row = gridCoordinates.Rows[i];
                var coord = zone.coordinates[i];

                coord.x = Convert.ToSingle(row.Cells[0].Value);
                coord.y = Convert.ToSingle(row.Cells[1].Value);
                coord.z = Convert.ToSingle(row.Cells[2].Value);
            }

            Close();
        }

        private void btRemoveCoord_Click(object sender, EventArgs e) {
            if (gridCoordinates.SelectedCells.Count == 0) return;

            int index = gridCoordinates.SelectedCells[0].RowIndex;

            zone.coordinates.RemoveAt(index);
            gridCoordinates.Rows.RemoveAt(index);
        }

        private void btAddCoord_Click(object sender, EventArgs e) {
            var coordinate = new Vector3();
            zone.coordinates.Add(coordinate);
            gridCoordinates.Rows.Add(
                coordinate.x.ToString(),
                coordinate.y.ToString(),
                coordinate.z.ToString()
            );
        }
    }
}
