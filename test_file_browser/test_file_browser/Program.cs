using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace test_file_browser
{
    internal class Program
    {
        private static string _rootPath;
        private static readonly string[] _imgExtensions = { ".jpg", ".png", ".jpeg", ".gif", ".bmp" }; // Only allow this image extensions. [string]
        static void Main(string[] args)
        {
         
           

           _rootPath = "\\\\Ndi-lap-078\\d\\Gmed\\develop\\gmed\\GCare\\Data\\341FF97D-99F4-48f9-8619-33B68D5FBCC7\\File Browser";
            var result = GetAbsolutePath("/Letters/", _rootPath);

          //  var results = GetInfo(_rootPath);
           //Console.WriteLine(results);
            Console.ReadKey();
        }
        private static string GetAbsolutePath(string relativePath, string basePath)
        {
            return basePath.StartsWith("\\")
                       ? relativePath == null ? null : GetAbsoluteFromNetworkPath(relativePath, basePath)
                       : relativePath == null ? null : Regex.Replace($"{basePath.Replace("\\", "/")}/{relativePath}", "(\\/)\\1+", "/");
        }
        private static string GetAbsoluteFromNetworkPath(string relativePath, string basePath) => ReplaceDoubleWithSingleSlash(basePath) + relativePath ?? String.Empty;
        private static string ReplaceDoubleWithSingleSlash(string path) => path.Substring(0, path.IndexOf("\\") + 1).Replace("\\", "/") + path.Substring(path.IndexOf("\\") + 1).Replace("\\", "/");
        private static string GetInfo(string path)
        {
            if (path == null)
                return "{ \"data\": [] }";

            var rootDirInfo = new DirectoryInfo(path);
            var sb = new StringBuilder();

            sb.AppendLine("{ \"data\": [");
            var i = 0;
            foreach (var dirInfo in rootDirInfo.GetDirectories())
            {

                // prevent directory traversal outside of file browser directory
                if (!dirInfo.FullName.Replace("/", "\\").StartsWith(_rootPath))
                    continue;

                if (i > 0)
                {
                    sb.Append(",");
                }
                string path1 = GetRelativePath(Path.Combine(path, dirInfo.Name).Replace('\\', '/'), _rootPath);
                sb.Append(GetDirectoryInfo(dirInfo, path1));
                i++;
            }

            foreach (var fileInfo in rootDirInfo.GetFiles())
            {
                // prevent directory traversal outside of file browser directory
                if (!fileInfo.FullName.Replace("/", "\\").StartsWith(_rootPath))
                    continue;

                if (i > 0)
                {
                    sb.Append(",");
                }
                string path1 = GetRelativePath(Path.Combine(path, fileInfo.Name).Replace('\\', '/'), _rootPath);
                sb.Append(GetFileInfo(fileInfo, path1));
                i++;
            }
            sb.AppendLine("] }");

            return sb.ToString();
        }

        private static string GetDirectoryInfo(FileSystemInfo dirInfo, string path)
        {
            var sb = new StringBuilder();

            sb.AppendLine("{");
            sb.AppendLine("\"id\": \"" + path + "/\",");
            sb.AppendLine("\"type\": \"folder\",");
            sb.AppendLine("\"attributes\": {");
            sb.AppendLine("\"name\": \"" + dirInfo.Name + "\",");
            sb.AppendLine("\"path\": \"" + path + "/\",");
            sb.AppendLine("\"readable\": 1,");
            sb.AppendLine("\"writable\": 1,");
            sb.AppendLine($"\"deletable\": {(path.Count(p => p == '/') > 1 ? "1" : "0")},");
            sb.AppendLine("\"created\": \"" + dirInfo.CreationTime + "\", ");
            sb.AppendLine("\"modified\": \"" + dirInfo.LastWriteTime + "\", ");
            sb.AppendLine("\"timestamp\": " + (int)dirInfo.CreationTime.Subtract(new DateTime(1970, 1, 1)).TotalSeconds);
            sb.Append("} }");

            return sb.ToString();
        }

        private static string GetFileInfo(FileInfo fileInfo, string path)
        {
            var sb = new StringBuilder();

            sb.AppendLine("{");
            sb.AppendLine("\"id\": \"" + path + "\",");
            sb.AppendLine("\"type\": \"file\",");
            sb.AppendLine("\"attributes\": {");
            sb.AppendLine("\"name\": \"" + fileInfo.Name + "\",");
            sb.AppendLine("\"extension\": \"" + fileInfo.Extension.Replace(".", "") + "\",");
            sb.AppendLine("\"path\": \"" + path + "\",");
            sb.AppendLine("\"readable\": 1,");
            sb.AppendLine("\"writable\": 1,");
            sb.AppendLine($"\"deletable\": {(path.Count(p => p == '/') > 1 ? "1" : "0")},");
            sb.AppendLine("\"created\": \"" + fileInfo.CreationTime + "\", ");
            sb.AppendLine("\"modified\": \"" + fileInfo.LastWriteTime + "\", ");
            sb.AppendLine("\"timestamp\": " + ((int)(fileInfo.CreationTime.Subtract(new DateTime(1970, 1, 1))).TotalSeconds) + ", ");
            if (IsImage(fileInfo))
            {
                //using (var img = System.Drawing.Image.FromFile(fileInfo.FullName))
                //{
                //    sb.AppendLine("\"height\": " + img.Height + ",");
                //    sb.AppendLine("\"width\": " + img.Width + ",");
                //}
            }
            else
            {
                sb.AppendLine("\"height\": 0,");
                sb.AppendLine("\"width\": 0,");
            }
            sb.AppendLine("\"size\": \"" + fileInfo.Length + "\"");
            sb.AppendLine("} }");

            return sb.ToString();
        }

        private static bool IsImage(FileSystemInfo fileInfo) => _imgExtensions.Any(ext => string.Equals(Path.GetExtension(fileInfo.FullName), ext, StringComparison.CurrentCultureIgnoreCase));

        private static string GetRelativePath(string path, string basePath) => path == null ? null : Regex.Replace(path, basePath.Replace("\\", "/"), string.Empty, RegexOptions.IgnoreCase);

    }
}
