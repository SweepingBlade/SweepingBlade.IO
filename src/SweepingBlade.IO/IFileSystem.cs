namespace SweepingBlade.IO;

public interface IFileSystem
{
    IDirectory Directory { get; }
    IDirectoryInfoFactory DirectoryInfo { get; }
    IDriveInfoFactory DriveInfo { get; }
    IFile File { get; }
    IFileInfoFactory FileInfo { get; }
    IFileSystemWatcherFactory FileSystemWatcher { get; }
    IPath Path { get; }
}