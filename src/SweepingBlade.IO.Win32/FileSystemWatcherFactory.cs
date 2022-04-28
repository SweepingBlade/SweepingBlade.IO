using System;

namespace SweepingBlade.IO.Win32;

public class FileSystemWatcherFactory : IFileSystemWatcherFactory
{
    private readonly IFileSystem _fileSystem;

    public FileSystemWatcherFactory(IFileSystem fileSystem)
    {
        _fileSystem = fileSystem ?? throw new ArgumentNullException(nameof(fileSystem));
    }

    public IFileSystemWatcher CreateNew()
    {
        return new FileSystemWatcher();
    }

    public IFileSystemWatcher CreateNew(string path)
    {
        return new FileSystemWatcher(path);
    }

    public IFileSystemWatcher CreateNew(string path, string filter)
    {
        return new FileSystemWatcher(path, filter);
    }
}