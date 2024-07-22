using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSOPrecinctEditor {
    public class Precinct {
        public int version;
        public int zoneCount;
        public int buildTime;
        public List<Zone> zones = new List<Zone>();

        public string fileName = "";

        public void loadFromFile(string fileName) {
            this.fileName = fileName;

            var file = File.Open(fileName, FileMode.Open);
            var reader = new BinaryReader(file);
            
            read(reader);

            reader.Close();
            file.Close();
        }

        public void saveToFile(string fileName) {
            var file = File.Open(fileName, FileMode.Create);
            var writer = new BinaryWriter(file);

            write(writer);

            writer.Close();
            file.Close();
        }

        public void read(BinaryReader reader) {
            version = reader.ReadInt32();
            zoneCount = reader.ReadInt32();
            buildTime = reader.ReadInt32();

            for (var i = 0; i < zoneCount; i++) {
                var zone = new Zone();
                zone.read(reader);
                zones.Add(zone);
            }
        }

        public void write(BinaryWriter writer) {
            writer.Write(version);
            writer.Write(zones.Count);
            writer.Write(buildTime);

            foreach (var zone in zones)
                zone.write(writer);
        }

        public static string convertTimeTToString(int time_t) {
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime date = epoch.AddSeconds(time_t);

            string formattedDate = date.ToString("yyyy-MM-dd HH:mm:ss");
            return formattedDate;
        }
    }
}
