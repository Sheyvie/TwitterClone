using Newtonsoft.Json;
using System.Net.Http;
using TwitterClone.Models;

namespace TwitterClone.Services.Comments
{
    public class CommentService : ICommentInterface
    {
        private readonly HttpClient _httpClient;
        public CommentService()
        {
            _httpClient = new HttpClient();
        }
        public Task<CommentDto> GetCommentById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async  Task<List<CommentDto>> GetCommentsAsync()
        {
            try
            {
                // json url
                var response = await _httpClient.GetAsync("https://jsonplaceholder.typicode.com/comments");


                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var comments = JsonConvert.DeserializeObject<List<CommentDto>>(content);
                    return comments;
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
