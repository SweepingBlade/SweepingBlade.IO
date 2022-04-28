namespace SweepingBlade.IO;

public interface IFileInfoFactory
{
    IFileInfo FromFileName(string fileName);
}