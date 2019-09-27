using CalamariBlog.Models.CMS;
using CalamariBlog.Models.CMS.Pages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CalamariBlog.Services.CMS.Contracts
{
    public interface ICMSService
    {
        Task<List<BlogPost>> GetBlogPosts();

        Task<BlogPost> GetBlogPost(string slug);

        Task<Global> GetGlobal();

        Task<List<Project>> GetProjects();

        Task<Project> GetProject(string slug);


        Task<PageAbout> GetPage_About();

        Task<PageContact> GetPage_Contact();

        Task<PageIndex> GetPage_Index();

        Task<PageProjects> GetPage_Projects();
    }
}
