#if FEATURE_ASYNC_FILE
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SweepingBlade.IO
{
    public partial interface IFile
    {
        Task AppendAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken = default);
        Task AppendAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken = default);
        Task AppendAllTextAsync(string path, string contents, CancellationToken cancellationToken = default);
        Task AppendAllTextAsync(string path, string contents, Encoding encoding, CancellationToken cancellationToken = default);
        Task<byte[]> ReadAllBytesAsync(string path, CancellationToken cancellationToken = default);
        Task<string[]> ReadAllLinesAsync(string path, CancellationToken cancellationToken = default);
        Task<string[]> ReadAllLinesAsync(string path, Encoding encoding, CancellationToken cancellationToken = default);
        Task<string> ReadAllTextAsync(string path, CancellationToken cancellationToken = default);
        Task<string> ReadAllTextAsync(string path, Encoding encoding, CancellationToken cancellationToken = default);
        Task WriteAllBytesAsync(string path, byte[] bytes, CancellationToken cancellationToken = default);
        Task WriteAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken = default);
        Task WriteAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken = default);
        Task WriteAllLinesAsync(string path, string[] contents, CancellationToken cancellationToken = default);
        Task WriteAllLinesAsync(string path, string[] contents, Encoding encoding, CancellationToken cancellationToken = default);
        Task WriteAllTextAsync(string path, string contents, CancellationToken cancellationToken = default);
        Task WriteAllTextAsync(string path, string contents, Encoding encoding, CancellationToken cancellationToken = default);
    }
}
#endif