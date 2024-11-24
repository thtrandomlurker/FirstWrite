using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FirstLib.FirstRead;

using FirstLib.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (XReader reader = new XReader(System.IO.File.Open(args[0], System.IO.FileMode.Open))) {
                ADCT addon = new ADCT();
                addon.Read(reader);

                foreach (var container in addon.AddonContentContainers)
                {
                    Directory.CreateDirectory(container.ContainerName);

                    foreach (var path in container.Paths)
                    {
                        Directory.CreateDirectory($"{container.ContainerName}\\{path.FilePath}");
                        try
                        {
                            if (File.Exists($"data\\{path.FileName}"))
                                if (!File.Exists($"{container.ContainerName}\\{path.FilePath}\\{path.FileName}"))
                                    File.Copy($"data\\{path.FileName}", $"{container.ContainerName}\\{path.FilePath}\\{path.FileName}");
                            else if (File.Exists($"{path.FileName}"))
                                    if (!File.Exists($"{container.ContainerName}\\{path.FilePath}\\{path.FileName}"))
                                        File.Copy($"{path.FileName}", $"{container.ContainerName}\\{path.FilePath}\\{path.FileName}");
                            else if (File.Exists($"sound\\{path.FileName}"))
                                        if (!File.Exists($"{container.ContainerName}\\{path.FilePath}\\{path.FileName}"))
                                            File.Copy($"sound\\{path.FileName}", $"{container.ContainerName}\\{path.FilePath}\\{path.FileName}");
                            else if (File.Exists($"sound\\song\\{path.FileName}"))
                                            if (!File.Exists($"{container.ContainerName}\\{path.FilePath}\\{path.FileName}"))
                                                File.Copy($"sound\\song\\{path.FileName}", $"{container.ContainerName}\\{path.FilePath}\\{path.FileName}");
                            else if (File.Exists($"sound\\bgm\\{path.FileName}"))
                                                if (!File.Exists($"{container.ContainerName}\\{path.FilePath}\\{path.FileName}"))
                                                    File.Copy($"sound\\bgm\\{path.FileName}", $"{container.ContainerName}\\{path.FilePath}\\{path.FileName}");
                            else if (File.Exists($"movie\\{path.FileName}"))
                                                    if (!File.Exists($"{container.ContainerName}\\{path.FilePath}\\{path.FileName}"))
                                                        File.Copy($"movie\\{path.FileName}", $"{container.ContainerName}\\{path.FilePath}\\{path.FileName}");
                        }
                        catch (FileNotFoundException)
                        {
                            Console.WriteLine("File not found!");
                            return;
                        }
                    }
                }
            }
        }
    }
}
