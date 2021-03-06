using System.IO;

namespace SweepingBlade.IO;

public interface IDriveInfo
{
    long AvailableFreeSpace { get; }
    string DriveFormat { get; }
    DriveType DriveType { get; }
    bool IsReady { get; }
    string Name { get; }
    IDirectoryInfo RootDirectory { get; }
    long TotalFreeSpace { get; }
    long TotalSize { get; }
    string VolumeLabel { get; set; }
}