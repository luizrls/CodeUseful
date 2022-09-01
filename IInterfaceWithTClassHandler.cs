public interface IInterfaceWithTClassHandler<in TRequest, TResponse>
{
    Task<TResponse> HandleAsync(TRequest request);
}
