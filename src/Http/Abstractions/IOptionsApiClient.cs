namespace artbit.API.Client.Http.Abstractions
{
    using Implementations;

    public interface IOptionsApiClient
    {        
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Options> OptionsAsync();
    }
}
