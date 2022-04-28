using System;

namespace SweepingBlade.IO;

public interface IFileSystemInfo
{
    void Delete();
    DateTime CreationTime { get; set; }
    DateTime CreationTimeUtc { get; set; }
    bool Exists { get; }
    public string Extension { get; }
    public string FullName { get; }
    DateTime LastAccessTime { get; set; }
    DateTime LastAccessTimeUtc { get; set; }
    DateTime LastWriteTime { get; set; }
    DateTime LastWriteTimeUtc { get; set; }
    public string Name { get; }
}