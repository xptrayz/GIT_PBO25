using System;
using System.IO;

class GIT_FANA
{
	static void Main()
	{
		Console.WriteLine("\r\n██████╗ ██████╗  ██████╗     ██████╗ ███████╗     ██████╗ ██╗████████╗\r\n██╔══██╗██╔══██╗██╔═══██╗    ╚════██╗██╔════╝    ██╔════╝ ██║╚══██╔══╝\r\n██████╔╝██████╔╝██║   ██║     █████╔╝███████╗    ██║  ███╗██║   ██║   \r\n██╔═══╝ ██╔══██╗██║   ██║    ██╔═══╝ ╚════██║    ██║   ██║██║   ██║   \r\n██║     ██████╔╝╚██████╔╝    ███████╗███████║    ╚██████╔╝██║   ██║   \r\n╚═╝     ╚═════╝  ╚═════╝     ╚══════╝╚══════╝     ╚═════╝ ╚═╝   ╚═╝   \r\n                                                                      \r\n");
		Console.WriteLine("Halo, ini merupakan project sederhana yang menglist semua file txt di directory [./nama_pelaku]\n");
		Console.WriteLine("1. Buat File dengan NIM-mu.txt ex: 242410103000, kemudian isi kata kata :v");
		Console.WriteLine("2. Push perubahan ke Github mu");
		Console.WriteLine("3. Lakukan pull request :)\n");
		Handler.ListPelaku();
	}
}

static class Handler
{
	public static void ListPelaku()
	{
		string Dir = @"..\..\..\nama_pelaku";
		string[] files = Directory.GetFiles(Dir, "*.txt");
		Console.WriteLine("┌─List Para Pelaku [ PBO 25 ] dan Kata Katanya XD");
		Console.WriteLine("│");

		foreach (string file in files)
		{
			Console.WriteLine($"├{Path.GetFileName(file)}");
			Console.Write($"├─{File.ReadAllText(file)}\n");
		}
		Console.WriteLine("│");
		Console.WriteLine("└─O");
	}
}
