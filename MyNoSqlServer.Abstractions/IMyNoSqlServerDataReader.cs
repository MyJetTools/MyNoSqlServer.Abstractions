

namespace MyNoSqlServer.Abstractions
{

    public interface IMyNoSqlServerDataReader<out TDbRow> where TDbRow : IMyNoSqlEntity
    {
        Task IsInitialized();
        IReadOnlyList<TDbRow> Get(Func<TDbRow, bool>? condition = null);
        TDbRow? Get(string partitionKey, string rowKey);
        IReadOnlyList<TDbRow> Get(string partitionKey);
        IReadOnlyList<TDbRow> Get(string partitionKey, Func<TDbRow, bool> condition);
        IReadOnlyList<TDbRow> Get(string partitionKey, int skip, int take);
        IReadOnlyList<TDbRow> Get(string partitionKey, int skip, int take, Func<TDbRow, bool> condition);
        int Count();
        int Count(string partitionKey);
        int Count(string partitionKey, Func<TDbRow, bool> condition);
        IMyNoSqlServerDataReader<TDbRow> SubscribeToUpdateEvents(Action<IReadOnlyList<TDbRow>> updateSubscriber, Action<IReadOnlyList<TDbRow>> deleteSubscriber);
    }

}