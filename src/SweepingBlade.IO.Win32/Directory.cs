using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;

namespace SweepingBlade.IO.Win32;

public class Directory : IDirectory
{
    private readonly IFileSystem _fileSystem;

    public Directory(IFileSystem fileSystem)
    {
        _fileSystem = fileSystem ?? throw new ArgumentNullException(nameof(fileSystem));
    }

    public IDirectoryInfo CreateDirectory(string path)
    {
        return new DirectoryInfo(_fileSystem, System.IO.Directory.CreateDirectory(path));
    }

    public IDirectoryInfo CreateDirectory(string path, DirectorySecurity directorySecurity)
    {
        var directoryInfo = new System.IO.DirectoryInfo(path);
        directoryInfo.Create(directorySecurity);
        return new DirectoryInfo(_fileSystem, directoryInfo);
    }

    public void Delete(string path)
    {
        System.IO.Directory.Delete(path);
    }

    public void Delete(string path, bool recursive)
    {
        System.IO.Directory.Delete(path, recursive);
    }

    public IEnumerable<string> EnumerateDirectories(string path)
    {
        return System.IO.Directory.EnumerateDirectories(path);
    }

    public IEnumerable<string> EnumerateDirectories(string path, string searchPattern)
    {
        return System.IO.Directory.EnumerateDirectories(path, searchPattern);
    }

    public IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption)
    {
        return System.IO.Directory.EnumerateDirectories(path, searchPattern, searchOption);
    }

#if FEATURE_ENUMERATION_OPTIONS
    public IEnumerable<string> EnumerateDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions)
    {
        return System.IO.Directory.EnumerateDirectories(path, searchPattern, enumerationOptions);
    }
#endif

    public IEnumerable<string> EnumerateFiles(string path)
    {
        return System.IO.Directory.EnumerateFiles(path);
    }

    public IEnumerable<string> EnumerateFiles(string path, string searchPattern)
    {
        return System.IO.Directory.EnumerateFiles(path, searchPattern);
    }

    public IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption)
    {
        return System.IO.Directory.EnumerateFiles(path, searchPattern, searchOption);
    }

#if FEATURE_ENUMERATION_OPTIONS
    public IEnumerable<string> EnumerateFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
    {
        return System.IO.Directory.EnumerateFiles(path, searchPattern, enumerationOptions);
    }
#endif

    public IEnumerable<string> EnumerateFileSystemEntries(string path)
    {
        return System.IO.Directory.EnumerateFileSystemEntries(path);
    }

    public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern)
    {
        return System.IO.Directory.EnumerateFileSystemEntries(path, searchPattern);
    }

    public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
    {
        return System.IO.Directory.EnumerateFileSystemEntries(path, searchPattern, searchOption);
    }

#if FEATURE_ENUMERATION_OPTIONS
    public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions)
    {
        return System.IO.Directory.EnumerateFileSystemEntries(path, searchPattern, enumerationOptions);
    }
#endif

    public bool Exists(string path)
    {
        return System.IO.Directory.Exists(path);
    }

    public DirectorySecurity GetAccessControl(string path)
    {
        var directoryInfo = new System.IO.DirectoryInfo(path);
        return directoryInfo.GetAccessControl();
    }

    public DirectorySecurity GetAccessControl(string path, AccessControlSections includeSections)
    {
        var directoryInfo = new System.IO.DirectoryInfo(path);
        return directoryInfo.GetAccessControl(includeSections);
    }

    public DateTime GetCreationTime(string path)
    {
        return System.IO.Directory.GetCreationTime(path);
    }

    public DateTime GetCreationTimeUtc(string path)
    {
        return System.IO.Directory.GetCreationTimeUtc(path);
    }

    public string GetCurrentDirectory()
    {
        return System.IO.Directory.GetCurrentDirectory();
    }

    public string[] GetDirectories(string path)
    {
        return System.IO.Directory.GetDirectories(path);
    }

    public string[] GetDirectories(string path, string searchPattern)
    {
        return System.IO.Directory.GetDirectories(path, searchPattern);
    }

    public string[] GetDirectories(string path, string searchPattern, SearchOption searchOption)
    {
        return System.IO.Directory.GetDirectories(path, searchPattern, searchOption);
    }

#if FEATURE_ENUMERATION_OPTIONS
    public string[] GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions)
    {
        return System.IO.Directory.GetDirectories(path, searchPattern, enumerationOptions);
    }
#endif

    public string GetDirectoryRoot(string path)
    {
        return System.IO.Directory.GetDirectoryRoot(path);
    }

    public string[] GetFiles(string path)
    {
        return System.IO.Directory.GetFiles(path);
    }

    public string[] GetFiles(string path, string searchPattern)
    {
        return System.IO.Directory.GetFiles(path, searchPattern);
    }

    public string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
    {
        return System.IO.Directory.GetFiles(path, searchPattern, searchOption);
    }

#if FEATURE_ENUMERATION_OPTIONS
    public string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
    {
        return System.IO.Directory.GetFiles(path, searchPattern, enumerationOptions);
    }
#endif

    public string[] GetFileSystemEntries(string path)
    {
        return System.IO.Directory.GetFileSystemEntries(path);
    }

    public string[] GetFileSystemEntries(string path, string searchPattern)
    {
        return System.IO.Directory.GetFileSystemEntries(path, searchPattern);
    }

    public DateTime GetLastAccessTime(string path)
    {
        return System.IO.Directory.GetLastAccessTime(path);
    }

    public DateTime GetLastAccessTimeUtc(string path)
    {
        return System.IO.Directory.GetLastAccessTimeUtc(path);
    }

    public DateTime GetLastWriteTime(string path)
    {
        return System.IO.Directory.GetLastWriteTime(path);
    }

    public DateTime GetLastWriteTimeUtc(string path)
    {
        return System.IO.Directory.GetLastWriteTimeUtc(path);
    }

    public string[] GetLogicalDrives()
    {
        return System.IO.Directory.GetLogicalDrives();
    }

    public IDirectoryInfo GetParent(string path)
    {
        var directoryInfo = System.IO.Directory.GetParent(path);
        return directoryInfo is not null ? new DirectoryInfo(_fileSystem, directoryInfo) : null;
    }

    public void Move(string sourceDirName, string destDirName)
    {
        System.IO.Directory.Move(sourceDirName, destDirName);
    }

    public void SetAccessControl(string path, DirectorySecurity directorySecurity)
    {
        var directoryInfo = new System.IO.DirectoryInfo(path);
        directoryInfo.SetAccessControl(directorySecurity);
    }

    public void SetCreationTime(string path, DateTime creationTime)
    {
        System.IO.Directory.SetCreationTime(path, creationTime);
    }

    public void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
    {
        System.IO.Directory.SetCreationTimeUtc(path, creationTimeUtc);
    }

    public void SetCurrentDirectory(string path)
    {
        System.IO.Directory.SetCurrentDirectory(path);
    }

    public void SetLastAccessTime(string path, DateTime lastAccessTime)
    {
        System.IO.Directory.SetLastAccessTime(path, lastAccessTime);
    }

    public void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
    {
        System.IO.Directory.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
    }

    public void SetLastWriteTime(string path, DateTime lastWriteTime)
    {
        System.IO.Directory.SetLastWriteTime(path, lastWriteTime);
    }

    public void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
    {
        System.IO.Directory.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
    }
}