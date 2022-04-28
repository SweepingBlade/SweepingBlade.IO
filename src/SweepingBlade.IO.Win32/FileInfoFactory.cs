using System;

namespace SweepingBlade.IO.Win32;

public class FileInfoFactory : IFileInfoFactory
{
    private readonly IFileSystem _fileSystem;

    public FileInfoFactory(IFileSystem fileSystem)
    {
        _fileSystem = fileSystem ?? throw new ArgumentNullException(nameof(fileSystem));
    }

    public IFileInfo FromFileName(string fileName)
    {
        var fileInfo = new System.IO.FileInfo(fileName);
        return new FileInfo(_fileSystem, fileInfo);
    }
}