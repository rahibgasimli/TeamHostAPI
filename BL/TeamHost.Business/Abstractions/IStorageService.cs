using Microsoft.AspNetCore.Http;
using TeamHost.Business.Dtos;

namespace TeamHost.Business.Abstractions
{
    public interface IStorageService
    {
        Task DeleteFileAsync(string dirPath, string fileName);
        bool HasFile(string dirPath, string fileName);
        Task<UploadFileDto> UploadFileAsync(string dirPath, IFormFile file);
        Task<List<UploadFileDto>> UploadFilesAsync(string dirPath, IFormFileCollection files);
    }
}
