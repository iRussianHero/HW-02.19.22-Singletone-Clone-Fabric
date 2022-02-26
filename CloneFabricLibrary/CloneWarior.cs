using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace CloneFabricLibrary
{
    public class CloneWarior
    {
        public string Name { get; set; }
        public string ClassType { get; set; }

        public CloneWarior(string name, string classType)
        {
            Name = name;
            ClassType = classType;
        }
        public CloneWarior Clone()
        {
            object clone;
            MemoryStream memoryStream = new MemoryStream();
            StreamingContext streaingContext = new StreamingContext(StreamingContextStates.Clone);

            BinaryFormatter binaryFormatter = new BinaryFormatter(null, streaingContext);
            binaryFormatter.Serialize(memoryStream, this);
            memoryStream.Seek(0, SeekOrigin.Begin);

            clone=binaryFormatter.Deserialize(memoryStream);
            return (CloneWarior)clone;
        }
        public string GetInfo()
        {
            return ($"Name: {Name}, Class - {ClassType}");
        }
    }
}