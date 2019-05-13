using System;
using System.Net;
using System.IO;
using FileDownloader;
using Newtonsoft.Json;

namespace FileDownloader
{
    class CachObject
    {
        public string URI { get; set; }
        public string PATH { get; set; }
        public string[] HEADERS { get; set; }
    }

    class Base64
    {
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }

    class Cache : IDownloadCache
    {
        string filepath
        {
            get {
                if(Directory.Exists(System.IO.Path.GetFullPath("./") + @"\cache"))
                    return System.IO.Path.GetFullPath("./") + @"\cache\";
                else
                {
                    Directory.CreateDirectory(System.IO.Path.GetFullPath("./") + @"\cache");
                    return System.IO.Path.GetFullPath("./") + @"\cache\";
                }
            }
        }
        void IDownloadCache.Add(Uri uri, string path, WebHeaderCollection headers)
        {
            CachObject cach = new CachObject() { URI = uri.AbsoluteUri, PATH = path, HEADERS = headers.AllKeys };
            string jsonData = JsonConvert.SerializeObject(cach);
            string Path = Base64.Base64Encode(uri.AbsolutePath).Replace("\\", "");
            File.WriteAllText(filepath + Path, jsonData);
        }

        string IDownloadCache.Get(Uri uri, WebHeaderCollection headers)
        {
            string Path = Base64.Base64Encode(uri.AbsolutePath).Replace("\\", "");
            string PATH = filepath + Path;
            if (File.Exists(PATH))
            {
                var JsonEncoded = File.ReadAllText(PATH);
                CachObject account = JsonConvert.DeserializeObject<CachObject>(JsonEncoded);
                return account.PATH;
            }
            else
                return null;
        }

        void IDownloadCache.Invalidate(Uri uri)
        {
            string Path = Base64.Base64Encode(uri.AbsolutePath).Replace("\\", "");
            string PATH = filepath + Path;
            if (File.Exists(PATH))
                File.Delete(PATH);
        }
    }
}