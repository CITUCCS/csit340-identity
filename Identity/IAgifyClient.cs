using Refit;

namespace Identity
{
    public interface IAgifyClient
    {
        [Get("/")]
        Task<AgeResponse> GetAge(string name);
    }
}
