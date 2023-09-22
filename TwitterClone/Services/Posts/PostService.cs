using Newtonsoft.Json;
using System.Net.Http;
using TwitterClone.Models;

namespace TwitterClone.Services.Posts
{
    public class PostService : IPostInterface
    {
        private readonly HttpClient _httpClient;
        public PostService()
        {
            _httpClient = new HttpClient();
        }
        public Task<PostDto> GetPostById(Guid id)
        {
            throw new NotImplementedException();
        }

 
       public async Task<List<PostDto>> GetPostsAsync()
       {
                try
                {
                    // json url
                    var response = await _httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts");


                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var posts = JsonConvert.DeserializeObject<List<PostDto>>(content);
                        return posts;
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
