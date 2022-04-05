// Decompiled with JetBrains decompiler
// Type: txtfinder.Program
// Assembly: SeedDestroyer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7669D538-908F-43E6-B6CC-4B4B04031D9D
// Assembly location: C:\Users\kacke\Downloads\btc\SeedDestroyer.exe

using dotnetstandard_bip39;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;

namespace txtfinder
{
  internal class Program
  {
    [DllImport("kernel32.dll")]
    private static extern IntPtr GetConsoleWindow();

    [DllImport("user32.dll")]
    private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    private static void Main(string[] args)
    {
      Program.GetConsoleWindow();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("\r\n ██████╗██████╗ ██╗   ██╗██████╗ ████████╗ ██████╗     ██████╗ ██████╗ ███████╗ █████╗ ██╗  ██╗███████╗██████╗ \r\n██╔════╝██╔══██╗╚██╗ ██╔╝██╔══██╗╚══██╔══╝██╔═══██╗    ██╔══██╗██╔══██╗██╔════╝██╔══██╗██║ ██╔╝██╔════╝██╔══██╗\r\n██║     ██████╔╝ ╚████╔╝ ██████╔╝   ██║   ██║   ██║    ██████╔╝██████╔╝█████╗  ███████║█████╔╝ █████╗  ██████╔╝\r\n██║     ██╔══██╗  ╚██╔╝  ██╔═══╝    ██║   ██║   ██║    ██╔══██╗██╔══██╗██╔══╝  ██╔══██║██╔═██╗ ██╔══╝  ██╔══██╗\r\n╚██████╗██║  ██║   ██║   ██║        ██║   ╚██████╔╝    ██████╔╝██║  ██║███████╗██║  ██║██║  ██╗███████╗██║  ██║\r\n ╚═════╝╚═╝  ╚═╝   ╚═╝   ╚═╝        ╚═╝    ╚═════╝     ╚═════╝ ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝\r\n                                                                                                               \r\n");
      Console.Title = "#fuckputin";
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("Fuck this tool");
      Finder.Search();
      Console.WriteLine("Fuck this tool");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Fake asf tool");

      
    }
  }
}
