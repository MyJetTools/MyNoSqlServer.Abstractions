
namespace MyNoSqlServer.Abstractions
{
    public interface ITransactionsBuilder<T> : IAsyncDisposable where T : IMyNoSqlDbEntity, new()
    {
        ITransactionsBuilder<T> CleanTable();
        ITransactionsBuilder<T> DeletePartitions(string[] partitions);
        ITransactionsBuilder<T> DeletePartition(string partition);
        ITransactionsBuilder<T> DeleteRows(string partitionKey, string[] rowKeys);
        ITransactionsBuilder<T> InsertOrReplace(T entity);
        ITransactionsBuilder<T> InsertOrReplace(IEnumerable<T> entities);
        ValueTask<ITransactionsBuilder<T>> PostAsync();
        ValueTask CommitAsync();
    }
}