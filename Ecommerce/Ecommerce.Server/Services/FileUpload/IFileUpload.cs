using Microsoft.AspNetCore.Components.Forms;
using System.Threading.Tasks;

namespace Ecommerce.Server.Services.FileUpload
{
    public interface IFileUpload
    {
        Task<string> UploadFile(IBrowserFile file);

        bool DeleteFile(string fileName);
    }
}
