using Microsoft.Win32;
using System;
using System.IO;

namespace WallChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0 && Uri.TryCreate(args[0], UriKind.RelativeOrAbsolute, out Uri u))
            {
                Wallpaper.Set(u, Style.Stretched);
            }
            else
            {
                Console.WriteLine("Usage: wallchanger [Wallpaper]");
                Console.WriteLine("   where Wallpaper is the wallpaper you want to set to.");
            }
        }
    }
}
