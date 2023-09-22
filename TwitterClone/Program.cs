using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TwitterClone;
using TwitterClone.Services.Comments;
using TwitterClone.Services.Posts;
using TwitterClone.Services.Users;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IUserInterface , UserService>();
builder.Services.AddScoped<IPostInterface, PostService>();
builder.Services.AddScoped<ICommentInterface, CommentService>();    

await builder.Build().RunAsync();
