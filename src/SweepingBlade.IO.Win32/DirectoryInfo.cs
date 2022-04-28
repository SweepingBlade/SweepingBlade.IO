using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SweepingBlade.IO.Win32;

public class DirectoryInfo : FileSystemInfo, IDirectoryInfo
{
    private readonly System.IO.DirectoryInfo _directoryInfo;

    public DirectoryInfo(IFileSystem fileSystem, System.IO.DirectoryInfo directoryInfo)
        : base(fileSystem, directoryInfo)
    {
        _directoryInfo = directoryInfo ?? throw new ArgumentNullException(nameof(directoryInfo));
    }

    public IDirectoryInfo Parent => _directoryInfo.Parent is not null ? new DirectoryInfo(FileSystem, _directoryInfo.Parent) : null;

    public IDirectoryInfo Root => new DirectoryInfo(FileSystem, _directoryInfo.Root);

    public void Create()
    {
        _directoryInfo.Create();
    }

    public IDirectoryInfo CreateSubdirectory(string path)
    {
        return new DirectoryInfo(FileSystem, _directoryInfo.CreateSubdirectory(path));
    }

    public void Delete(bool recursive)
    {
        _directoryInfo.Delete(recursive);
    }

    public IEnumerable<IDirectoryInfo> EnumerateDirectories()
    {
        return _directoryInfo.EnumerateDirectories().Select(directoryInfo => new DirectoryInfo(FileSystem, directoryInfo));
    }

    public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern)
    {
        return _directoryInfo.EnumerateDirectories(searchPattern).Select(directoryInfo => new DirectoryInfo(FileSystem, directoryInfo));
    }

    public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption)
    {
        return _directoryInfo.EnumerateDirectories(searchPattern, searchOption).Select(directoryInfo => new DirectoryInfo(FileSystem, directoryInfo));
    }

#if FEATURE_ENUMERATION_OPTIONS
    public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, EnumerationOptions enumerationOptions)
    {
        return _directoryInfo.EnumerateDirectories(searchPattern, enumerationOptions).Select(directoryInfo => new DirectoryInfo(FileSystem, directoryInfo));
    }
#endif

    public IEnumerable<IFileInfo> EnumerateFiles()
    {
        return _directoryInfo.EnumerateFiles().Select(fileInfo => new FileInfo(FileSystem, fileInfo));
    }

    public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern)
    {
        return _directoryInfo.EnumerateFiles(searchPattern).Select(fileInfo => new FileInfo(FileSystem, fileInfo));
    }

    public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption)
    {
        return _directoryInfo.EnumerateFiles(searchPattern, searchOption).Select(fileInfo => new FileInfo(FileSystem, fileInfo));
    }

#if FEATURE_ENUMERATION_OPTIONS
    public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, EnumerationOptions enumerationOptions)
    {
        return _directoryInfo.EnumerateFiles(searchPattern, enumerationOptions).Select(fileInfo => new FileInfo(FileSystem, fileInfo));
    }
#endif

    public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos()
    {
        return _directoryInfo.EnumerateFileSystemInfos().Select(fileSystemInfo => fileSystemInfo.Map(FileSystem));
    }

    public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern)
    {
        return _directoryInfo.EnumerateFileSystemInfos(searchPattern).Select(fileSystemInfo => fileSystemInfo.Map(FileSystem));
    }

    public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption)
    {
        return _directoryInfo.EnumerateFileSystemInfos(searchPattern, searchOption).Select(fileSystemInfo => fileSystemInfo.Map(FileSystem));
    }

#if FEATURE_ENUMERATION_OPTIONS
    public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions)
    {
        return _directoryInfo.EnumerateFileSystemInfos(searchPattern, enumerationOptions).Select(fileSystemInfo => fileSystemInfo.Map(FileSystem));
    }
#endif

    public IDirectoryInfo[] GetDirectories()
    {
        return _directoryInfo.GetDirectories().Select(directoryInfo => new DirectoryInfo(FileSystem, directoryInfo)).ToArray<IDirectoryInfo>();
    }

    public IDirectoryInfo[] GetDirectories(string searchPattern)
    {
        return _directoryInfo.GetDirectories(searchPattern).Select(directoryInfo => new DirectoryInfo(FileSystem, directoryInfo)).ToArray<IDirectoryInfo>();
    }

    public IDirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption)
    {
        return _directoryInfo.GetDirectories(searchPattern, searchOption).Select(directoryInfo => new DirectoryInfo(FileSystem, directoryInfo)).ToArray<IDirectoryInfo>();
    }

#if FEATURE_ENUMERATION_OPTIONS
    public IDirectoryInfo[] GetDirectories(string searchPattern, EnumerationOptions enumerationOptions)
    {
        return _directoryInfo.GetDirectories(searchPattern, enumerationOptions).Select(directoryInfo => new DirectoryInfo(FileSystem, directoryInfo)).ToArray<IDirectoryInfo>();
    }
#endif

    public IFileInfo[] GetFiles()
    {
        return _directoryInfo.GetFiles().Select(fileInfo => new FileInfo(FileSystem, fileInfo)).ToArray<IFileInfo>();
    }

    public IFileInfo[] GetFiles(string searchPattern)
    {
        return _directoryInfo.GetFiles(searchPattern).Select(fileInfo => new FileInfo(FileSystem, fileInfo)).ToArray<IFileInfo>();
    }

    public IFileInfo[] GetFiles(string searchPattern, SearchOption searchOption)
    {
        return _directoryInfo.GetFiles(searchPattern, searchOption).Select(fileInfo => new FileInfo(FileSystem, fileInfo)).ToArray<IFileInfo>();
    }

#if FEATURE_ENUMERATION_OPTIONS
    public IFileInfo[] GetFiles(string searchPattern, EnumerationOptions enumerationOptions)
    {
        return _directoryInfo.GetFiles(searchPattern, enumerationOptions).Select(fileInfo => new FileInfo(FileSystem, fileInfo)).ToArray<IFileInfo>();
    }
#endif

    public IFileSystemInfo[] GetFileSystemInfos()
    {
        return _directoryInfo.GetFileSystemInfos().Select(fileSystemInfo => fileSystemInfo.Map(FileSystem)).ToArray();
    }

    public IFileSystemInfo[] GetFileSystemInfos(string searchPattern)
    {
        return _directoryInfo.GetFileSystemInfos(searchPattern).Select(fileSystemInfo => fileSystemInfo.Map(FileSystem)).ToArray();
    }

    public IFileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption)
    {
        return _directoryInfo.GetFileSystemInfos(searchPattern, searchOption).Select(fileSystemInfo => fileSystemInfo.Map(FileSystem)).ToArray();
    }

#if FEATURE_ENUMERATION_OPTIONS
    public IFileSystemInfo[] GetFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions)
    {
        return _directoryInfo.GetFileSystemInfos(searchPattern, enumerationOptions).Select(fileSystemInfo => fileSystemInfo.Map(FileSystem)).ToArray();
    }
#endif

    public void MoveTo(string destDirName)
    {
        _directoryInfo.MoveTo(destDirName);
    }
}