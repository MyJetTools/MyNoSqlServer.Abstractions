using System;

namespace MyNoSqlServer.Abstractions
{
    public interface IMyNoSqlDbEntity
    {
        string PartitionKey { get; set; }
        string RowKey { get; set; }
        DateTime? TimeStamp { get; set; }
        DateTime? Expires { get; set; }
    }

    public interface IMyNoSqlEntity:IMyNoSqlDbEntity
    {
        
    }


    public class MyNoSqlDbEntity : IMyNoSqlDbEntity
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTime? TimeStamp { get; set; }
        public DateTime? Expires { get; set; }
    }
    
    public class MyNoSqlEntity : IMyNoSqlEntity
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTime? TimeStamp { get; set; }
        public DateTime? Expires { get; set; }
    }
}