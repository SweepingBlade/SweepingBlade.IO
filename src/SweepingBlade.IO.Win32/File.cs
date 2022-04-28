using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Text;

namespace SweepingBlade.IO.Win32;

public partial class File : IFile
{
    private readonly IFileSystem _fileSystem;

    public File(IFileSystem fileSystem)
    {
        _fileSystem = fileSystem ?? throw new ArgumentNullException(nameof(fileSystem));
    }

    public void AppendAllLines(string path, IEnumerable<string> contents)
    {
        System.IO.File.AppendAllLines(path, contents);
    }

    public void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding)
    {
        System.IO.File.AppendAllLines(path, contents, encoding);
    }

    public void AppendAllText(string path, string contents)
    {
        System.IO.File.AppendAllText(path, contents);
    }

    public void AppendAllText(string path, string contents, Encoding encoding)
    {
        System.IO.File.AppendAllText(path, contents, encoding);
    }

    public StreamWriter AppendText(string path)
    {
        return System.IO.File.AppendText(path);
    }

    public void Copy(string sourceFileName, string destFileName)
    {
        System.IO.File.Copy(sourceFileName, destFileName);
    }

    public void Copy(string sourceFileName, string destFileName, bool overwrite)
    {
        System.IO.File.Copy(sourceFileName, destFileName, overwrite);
    }

    public Stream Create(string path)
    {
        return System.IO.File.Create(path);
    }

    public Stream Create(string path, int bufferSize)
    {
        return System.IO.File.Create(path, bufferSize);
    }

    public Stream Create(string path, int bufferSize, FileOptions options)
    {
        return System.IO.File.Create(path, bufferSize, options);
    }

    public StreamWriter CreateText(string path)
    {
        return System.IO.File.CreateText(path);
    }

    public void Decrypt(string path)
    {
        System.IO.File.Decrypt(path);
    }

    public void Delete(string path)
    {
        System.IO.File.Delete(path);
    }

    public void Encrypt(string path)
    {
        System.IO.File.Encrypt(path);
    }

    public bool Exists(string path)
    {
        return System.IO.File.Exists(path);
    }

    public FileSecurity GetAccessControl(string path)
    {
        return new System.IO.FileInfo(path).GetAccessControl();
    }

    public FileSecurity GetAccessControl(string path, AccessControlSections includeSections)
    {
        return new System.IO.FileInfo(path).GetAccessControl(includeSections);
    }

    public FileAttributes GetAttributes(string path)
    {
        return System.IO.File.GetAttributes(path);
    }

    public DateTime GetCreationTime(string path)
    {
        return System.IO.File.GetCreationTime(path);
    }

    public DateTime GetCreationTimeUtc(string path)
    {
        return System.IO.File.GetCreationTimeUtc(path);
    }

    public DateTime GetLastAccessTime(string path)
    {
        return System.IO.File.GetLastAccessTime(path);
    }

    public DateTime GetLastAccessTimeUtc(string path)
    {
        return System.IO.File.GetLastAccessTimeUtc(path);
    }

    public DateTime GetLastWriteTime(string path)
    {
        return System.IO.File.GetLastWriteTime(path);
    }

    public DateTime GetLastWriteTimeUtc(string path)
    {
        return System.IO.File.GetLastWriteTimeUtc(path);
    }

    public void Move(string sourceFileName, string destFileName)
    {
        System.IO.File.Move(sourceFileName, destFileName);
    }

#if FEATURE_FILE_MOVE_WITH_OVERWRITE
    public void Move(string sourceFileName, string destFileName, bool overwrite)
    {
        System.IO.File.Move(sourceFileName, destFileName, overwrite);
    }
#endif

    public Stream Open(string path, FileMode mode)
    {
        return System.IO.File.Open(path, mode);
    }

    public Stream Open(string path, FileMode mode, FileAccess access)
    {
        return System.IO.File.Open(path, mode, access);
    }

    public Stream Open(string path, FileMode mode, FileAccess access, FileShare share)
    {
        return System.IO.File.Open(path, mode, access, share);
    }

    public Stream OpenRead(string path)
    {
        return System.IO.File.OpenRead(path);
    }

    public StreamReader OpenText(string path)
    {
        return System.IO.File.OpenText(path);
    }

    public Stream OpenWrite(string path)
    {
        return System.IO.File.OpenWrite(path);
    }

    public byte[] ReadAllBytes(string path)
    {
        return System.IO.File.ReadAllBytes(path);
    }

    public string[] ReadAllLines(string path)
    {
        return System.IO.File.ReadAllLines(path);
    }

    public string[] ReadAllLines(string path, Encoding encoding)
    {
        return System.IO.File.ReadAllLines(path, encoding);
    }

    public string ReadAllText(string path)
    {
        return System.IO.File.ReadAllText(path);
    }

    public string ReadAllText(string path, Encoding encoding)
    {
        return System.IO.File.ReadAllText(path, encoding);
    }

    public IEnumerable<string> ReadLines(string path)
    {
        return System.IO.File.ReadLines(path);
    }

    public IEnumerable<string> ReadLines(string path, Encoding encoding)
    {
        return System.IO.File.ReadLines(path, encoding);
    }

    public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName)
    {
        System.IO.File.Replace(sourceFileName, destinationFileName, destinationBackupFileName);
    }

    public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
    {
        System.IO.File.Replace(sourceFileName, destinationFileName, destinationBackupFileName, ignoreMetadataErrors);
    }

    public void SetAccessControl(string path, FileSecurity fileSecurity)
    {
        var fileInfo = new System.IO.FileInfo(path);
        fileInfo.SetAccessControl(fileSecurity);
    }

    public void SetAttributes(string path, FileAttributes fileAttributes)
    {
        System.IO.File.SetAttributes(path, fileAttributes);
    }

    public void SetCreationTime(string path, DateTime creationTime)
    {
        System.IO.File.SetCreationTime(path, creationTime);
    }

    public void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
    {
        System.IO.File.SetCreationTimeUtc(path, creationTimeUtc);
    }

    public void SetLastAccessTime(string path, DateTime lastAccessTime)
    {
        System.IO.File.SetLastAccessTime(path, lastAccessTime);
    }

    public void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
    {
        System.IO.File.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
    }

    public void SetLastWriteTime(string path, DateTime lastWriteTime)
    {
        System.IO.File.SetLastWriteTime(path, lastWriteTime);
    }

    public void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
    {
        System.IO.File.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
    }

    public void WriteAllBytes(string path, byte[] bytes)
    {
        System.IO.File.WriteAllBytes(path, bytes);
    }

    public void WriteAllLines(string path, IEnumerable<string> contents)
    {
        System.IO.File.WriteAllLines(path, contents);
    }

    public void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding)
    {
        System.IO.File.WriteAllLines(path, contents, encoding);
    }

    public void WriteAllLines(string path, string[] contents)
    {
        System.IO.File.WriteAllLines(path, contents);
    }

    public void WriteAllLines(string path, string[] contents, Encoding encoding)
    {
        System.IO.File.WriteAllLines(path, contents, encoding);
    }

    public void WriteAllText(string path, string contents)
    {
        System.IO.File.WriteAllText(path, contents);
    }

    public void WriteAllText(string path, string contents, Encoding encoding)
    {
        System.IO.File.WriteAllText(path, contents, encoding);
    }
}