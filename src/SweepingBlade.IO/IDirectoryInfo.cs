using System.Collections.Generic;
using System.IO;

namespace SweepingBlade.IO;

public interface IDirectoryInfo : IFileSystemInfo
{
        public void Create();
        public IDirectoryInfo CreateSubdirectory(string path);
        void Delete(bool recursive);
        public IEnumerable<IDirectoryInfo> EnumerateDirectories();
        public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern);
        public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption);
#if FEATURE_ENUMERATION_OPTIONS
        public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, EnumerationOptions enumerationOptions);
#endif
        public IEnumerable<IFileInfo> EnumerateFiles();
        public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern);
        public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption);
#if FEATURE_ENUMERATION_OPTIONS
        public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, EnumerationOptions enumerationOptions);
#endif
        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos();
        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern);
        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption);
#if FEATURE_ENUMERATION_OPTIONS
        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions);
#endif
        public IDirectoryInfo[] GetDirectories();
        public IDirectoryInfo[] GetDirectories(string searchPattern);
        public IDirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption);
#if FEATURE_ENUMERATION_OPTIONS
        public IDirectoryInfo[] GetDirectories(string searchPattern, EnumerationOptions enumerationOptions);
#endif
        public IFileInfo[] GetFiles();
        public IFileInfo[] GetFiles(string searchPattern);
        public IFileInfo[] GetFiles(string searchPattern, SearchOption searchOption);
#if FEATURE_ENUMERATION_OPTIONS
        public IFileInfo[] GetFiles(string searchPattern, EnumerationOptions enumerationOptions);
#endif
        public IFileSystemInfo[] GetFileSystemInfos();
        public IFileSystemInfo[] GetFileSystemInfos(string searchPattern);
        public IFileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption);
#if FEATURE_ENUMERATION_OPTIONS
        public IFileSystemInfo[] GetFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions);
#endif
        public void MoveTo(string destDirName);
        public IDirectoryInfo Parent { get; }
        public IDirectoryInfo Root { get; }
}