using System.IO;
using System.IO.Compression;

namespace EncodingLib.Nbt
{
    public static class StreamEx
    {
        /// <summary>
        /// Writes a Gzip Compressed NbtBlob to stream.
        /// </summary>
        /// <exception cref="NBTException">Invalid Nbt</exception>
        public static void WriteCompressedNbtBlob(this Stream stream, NbtBlob blob)
        {
            using (var compress = new GZipStream(stream, CompressionMode.Compress, true))
            {
                var writer = new PrimitiveWriter(compress);
                writer.WriteNbtBlob(blob);
            }
        }

        /// <summary>
        /// Reads a Gzip Compressed NbtBlob from stream.
        /// </summary>
        /// <exception cref="NBTException">Invalid Nbt</exception>
        public static NbtBlob ReadCompressedNbtBlob(this Stream stream)
        {
            using (var compress = new GZipStream(stream, CompressionMode.Decompress, true))
            {
                var reader = new PrimitiveReader(compress);
                return reader.ReadNbtBlob();
            }
        }
    }
}
