using System.IO;

namespace SweepingBlade.IO;

public interface IFileInfo : IFileSystemInfo
{
    public StreamWriter AppendText();
    public IFileInfo CopyTo(string destFileName);
    public IFileInfo CopyTo(string destFileName, bool overwrite);
    public FileStream Create();
    public StreamWriter CreateText();
    public void MoveTo(string destFileName);
#if FEATURE_FILE_MOVE_WITH_OVERWRITE
    public void MoveTo(string destFileName, bool overwrite);
#endif
    public FileStream Open(FileMode mode);
    public FileStream Open(FileMode mode, FileAccess access);
    public FileStream Open(FileMode mode, FileAccess access, FileShare share);
    public FileStream OpenRead();
    public StreamReader OpenText();
    public FileStream OpenWrite();
    public IFileInfo Replace(string destinationFileName, string destinationBackupFileName);
    public IFileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors);
    public IDirectoryInfo Directory { get; }
    public string DirectoryName { get; }
    public bool IsReadOnly { get; set; }
    public long Length { get; }
}