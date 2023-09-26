namespace XlActions
{
    public class ConnectionData
    {
        public string ServerName { get; set; }
        public string DbName { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        //version is needed for XL Connection
        public int Version { get; set; }
    }
}
