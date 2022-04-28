using System;

namespace SweepingBlade.IO.Win32;

public class DirectoryInfoFactory : IDirectoryInfoFactory
{
    private readonly IFileSystem _fileSystem;

    public DirectoryInfoFactory(IFileSystem fileSystem)
    {
        _fileSystem = fileSystem ?? throw new ArgumentNullException(nameof(fileSystem));
    }

    public IDirectoryInfo FromDirectoryName(string directoryName)
    {
        var directoryInfo = new System.IO.DirectoryInfo(directoryName);
        return new DirectoryInfo(_fileSystem, directoryInfo);
    }
}