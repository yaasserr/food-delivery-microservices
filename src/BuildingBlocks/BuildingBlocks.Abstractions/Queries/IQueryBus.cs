namespace BuildingBlocks.Abstractions.Queries;

public interface IQueryBus
{
    Task<TResponse> SendAsync<TResponse>(IQuery<TResponse> query, CancellationToken cancellationToken = default)
        where TResponse : notnull;

    IAsyncEnumerable<TResponse> SendAsync<TResponse>(
        IStreamQuery<TResponse> query,
        CancellationToken cancellationToken = default
    )
        where TResponse : notnull;
}