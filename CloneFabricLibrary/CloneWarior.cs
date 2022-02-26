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
            return new CloneWarior(Name, ClassType);
        }
        public string GetInfo()
        {
            return ($"Name: {Name}, Class - {ClassType}");
        }
    }
}