using System;

namespace SweepingBlade.IO.Win32;

internal static class FileSystemInfoExtensions
{
    public static IFileSystemInfo Map(this System.IO.FileSystemInfo fileSystemInfo, IFileSystem fileSystem)
    {
        if (fileSystemInfo is null) throw new ArgumentNullException(nameof(fileSystemInfo));
        if (fileSystem is null) throw new ArgumentNullException(nameof(fileSystem));
        return fileSystemInfo switch
        {
            System.IO.DirectoryInfo directoryInfo => new DirectoryInfo(fileSystem, directoryInfo),
            System.IO.FileInfo fileInfo => new FileInfo(fileSystem, fileInfo),
            _ => throw new ArgumentOutOfRangeException(nameof(fileSystemInfo))
        };
    }
}