using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSOPrecinctEditor {
    public class CityPos {
        public int factionMask;
        public int mapId;
        public float x;
        public float y;
        public float z;

        public void read(BinaryReader reader) {
            factionMask = reader.ReadInt32();
            mapId = reader.ReadInt32();
            x = reader.ReadSingle();
            y = reader.ReadSingle();
            z = reader.ReadSingle();
        }

        public void write(BinaryWriter writer) {
            writer.Write(factionMask);
            writer.Write(mapId);
            writer.Write(x);
            writer.Write(y);
            writer.Write(z);
        }
    }
}
