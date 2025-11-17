namespace Marketplace.Domain.Interface
{
    public interface IFileService
    {
        void SaveFile(string path, Stream fileStream);
    }
}
