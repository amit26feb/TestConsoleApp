namespace TestConsoleApp
{
    public class Rootobject1
    {
        public Rootobject rootobject { get; set; }
    }
    public class Rootobject
    {
        public Class1[] Property1 { get; set; }
    }

    public class Class1
    {
        public Translation[] Translations { get; set; }
        public string Id { get; set; }
        public string BaseListId { get; set; }
    }

    public class Translation
    {
        public string HostCode { get; set; }
        public object Description { get; set; }
        public string Text { get; set; }
        public string Src { get; set; }
    }

}
