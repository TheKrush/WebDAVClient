using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using WebDAVClient;
using WebDAVClient.Model;

namespace TestWebDAVClient
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Basic authentication required
            Client c = new Client(new NetworkCredential {UserName = "USERNAME", Password = "PASSWORD"}) {Server = "https://webdav.4shared.com", BasePath = "/"};

            IEnumerable<Item> files = c.List("/").Result;
            Item folder = files.FirstOrDefault(f => f.Href.EndsWith("/Test/"));
            if (folder != null)
            {
                Item folderReloaded = c.Get(folder.Href).Result;
            }

            IEnumerable<Item> folderFiles = c.List(folder.Href).Result;
            Item folderFile = folderFiles.FirstOrDefault(f => f.IsCollection == false);

            if (folderFile != null)
            {
                Stream x = c.Download(folderFile.Href).Result;
            }

            string tempName = Path.GetRandomFileName();
            bool fileUploaded = c.Upload(folder.Href, File.OpenRead(@"C:\Users\itay.TZUNAMI\Desktop\Untitled.png"), tempName).Result;

            tempName = Path.GetRandomFileName();
            bool folderCreated = c.CreateDir(folder.Href, tempName).Result;
        }
    }
}
