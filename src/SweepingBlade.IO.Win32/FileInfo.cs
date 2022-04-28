using System;
using System.IO;

namespace SweepingBlade.IO.Win32;

public class FileInfo : FileSystemInfo, IFileInfo
{
    private readonly System.IO.FileInfo _fileInfo;

    public FileInfo(IFileSystem fileSystem, System.IO.FileInfo fileInfo)
        : base(fileSystem, fileInfo)
    {
        _fileInfo = fileInfo ?? throw new ArgumentNullException(nameof(fileInfo));
    }

    public IDirectoryInfo Directory => _fileInfo.Directory is not null ? new DirectoryInfo(FileSystem, _fileInfo.Directory) : null;

    public string DirectoryName => _fileInfo.DirectoryName;

    public bool IsReadOnly
    {
        get => _fileInfo.IsReadOnly;
        set => _fileInfo.IsReadOnly = value;
    }

    public long Length => _fileInfo.Length;

    public StreamWriter AppendText()
    {
        return _fileInfo.AppendText();
    }

    public IFileInfo CopyTo(string destFileName)
    {
        return new FileInfo(FileSystem, _fileInfo.CopyTo(destFileName));
    }

    public IFileInfo CopyTo(string destFileName, bool overwrite)
    {
        return new FileInfo(FileSystem, _fileInfo.CopyTo(destFileName, overwrite));
    }

    public FileStream Create()
    {
        return _fileInfo.Create();
    }

    public StreamWriter CreateText()
    {
        return _fileInfo.CreateText();
    }

    public void MoveTo(string destFileName)
    {
        _fileInfo.MoveTo(destFileName);
    }

#if FEATURE_FILE_MOVE_WITH_OVERWRITE
    public void MoveTo(string destFileName, bool overwrite)
    {
        _fileInfo.MoveTo(destFileName, overwrite);
    }
#endif

    public FileStream Open(FileMode mode)
    {
        return _fileInfo.Open(mode);
    }

    public FileStream Open(FileMode mode, FileAccess access)
    {
        return _fileInfo.Open(mode, access);
    }

    public FileStream Open(FileMode mode, FileAccess access, FileShare share)
    {
        return _fileInfo.Open(mode, access, share);
    }

    public FileStream OpenRead()
    {
        return _fileInfo.OpenRead();
    }

    public StreamReader OpenText()
    {
        return _fileInfo.OpenText();
    }

    public FileStream OpenWrite()
    {
        return _fileInfo.OpenWrite();
    }

    public IFileInfo Replace(string destinationFileName, string destinationBackupFileName)
    {
        return new FileInfo(FileSystem, _fileInfo.Replace(destinationFileName, destinationBackupFileName));
    }

    public IFileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
    {
        return new FileInfo(FileSystem, _fileInfo.Replace(destinationFileName, destinationBackupFileName, ignoreMetadataErrors));
    }
}