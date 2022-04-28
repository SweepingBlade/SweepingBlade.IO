using System;

namespace SweepingBlade.IO.Win32;

public abstract class FileSystemInfo : IFileSystemInfo
{
    private readonly System.IO.FileSystemInfo _fileSystemInfo;

    protected IFileSystem FileSystem { get; }

    protected FileSystemInfo(IFileSystem fileSystem, System.IO.FileSystemInfo fileSystemInfo)
    {
        FileSystem = fileSystem ?? throw new ArgumentNullException(nameof(fileSystem));
        _fileSystemInfo = fileSystemInfo ?? throw new ArgumentNullException(nameof(fileSystemInfo));
    }

    public DateTime CreationTime
    {
        get => _fileSystemInfo.CreationTime;
        set => _fileSystemInfo.CreationTime = value;
    }

    public DateTime CreationTimeUtc
    {
        get => _fileSystemInfo.CreationTimeUtc;
        set => _fileSystemInfo.CreationTimeUtc = value;
    }

    public bool Exists => _fileSystemInfo.Exists;

    public string Extension => _fileSystemInfo.Extension;

    public string FullName => _fileSystemInfo.FullName;

    public DateTime LastAccessTime
    {
        get => _fileSystemInfo.LastAccessTime;
        set => _fileSystemInfo.LastAccessTime = value;
    }

    public DateTime LastAccessTimeUtc
    {
        get => _fileSystemInfo.LastAccessTimeUtc;
        set => _fileSystemInfo.LastAccessTimeUtc = value;
    }

    public DateTime LastWriteTime
    {
        get => _fileSystemInfo.LastWriteTime;
        set => _fileSystemInfo.LastWriteTime = value;
    }

    public DateTime LastWriteTimeUtc
    {
        get => _fileSystemInfo.LastAccessTimeUtc;
        set => _fileSystemInfo.LastWriteTimeUtc = value;
    }

    public string Name => _fileSystemInfo.Name;

    public void Delete()
    {
        _fileSystemInfo.Delete();
    }

    public override string ToString()
    {
        return _fileSystemInfo.ToString();
    }
}