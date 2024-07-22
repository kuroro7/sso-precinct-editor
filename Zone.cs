using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSOPrecinctEditor {
    public class Zone {
        public int coordinatesCount;
        public int priority;
        public int dstInstance;
        public int srcInstance;
        public int domainId;

        public static int CITY_POS_COUNT = 4;

        public List<CityPos> cityPositions = new List<CityPos>();
        public List<Vector3> coordinates = new List<Vector3>();

        public static Zone template() {
            var zone = new Zone();

            for (var i = 0; i < CITY_POS_COUNT; i++)
                zone.cityPositions.Add(new CityPos());

            return zone;
        }

        public void read(BinaryReader reader) {
            coordinatesCount = reader.ReadInt32();
            priority = reader.ReadInt32();
            dstInstance = reader.ReadInt32();
            srcInstance = reader.ReadInt32();
            domainId = reader.ReadInt32();

            for (var i = 0; i < CITY_POS_COUNT; i++) {
                var cityPosition = new CityPos();
                cityPosition.read(reader);
                cityPositions.Add(cityPosition);
            }

            for (var i = 0; i < coordinatesCount; i++) {
                var coord = new Vector3();
                coord.read(reader);
                coordinates.Add(coord);
            }
        }

        public void write(BinaryWriter writer) {
            writer.Write(coordinates.Count);
            writer.Write(priority);
            writer.Write(dstInstance);
            writer.Write(srcInstance);
            writer.Write(domainId);

            foreach (var cityPosition in cityPositions)
                cityPosition.write(writer);
            
            foreach (var coord in coordinates)
                coord.write(writer);
        }
    }
}
