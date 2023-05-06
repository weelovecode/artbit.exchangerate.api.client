namespace artbit.API.Client.Http.Abstractions
{
    using Exceptions;
    using Models;

    public interface IOptionsApiClient
    {
        public string BaseUrl { get; }

        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Options> GetOptionsAsync();

        Task<Options> GetOptionsAsync(CancellationToken cancellationToken);
    }
}
