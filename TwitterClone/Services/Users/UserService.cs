using Newtonsoft.Json;
using System.Net.Http;
using TwitterClone.Models;

namespace TwitterClone.Services.Users
{
    public class UserService : IUserInterface
    {
        private readonly HttpClient _httpClient = new HttpClient();
        public UserService()
        {
            _httpClient = new HttpClient();
        }
        public Task<UserDto> GetUserById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserDto>> GetUsersAsync()
        {
            try
            {
                // Replace 'your-user-data-api-endpoint' with the actual API endpoint or JSON file URL
                var response = await _httpClient.GetAsync("https://jsonplaceholder.typicode.com/users");


                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var users = JsonConvert.DeserializeObject<List<UserDto>>(content);
                    return users;
                }
                else
                {

                    throw new Exception("Failed to fetch user data.");
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                throw ex;
            }
        }
    }
}
    

