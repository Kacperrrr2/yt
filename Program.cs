
namespace ConsoleApp3
{
    class Realsed
    {
        string artist;
        string album;
        int songsNumber;
        int yearOfedidtion;
        int downloadNumber;

        public Realsed(string artist,
        string album,
        int songsNumber,
        int yearOfedidtion,
        int downloadNumber)
        {
            this.artist = artist;
            this.album = album;
            this.songsNumber = songsNumber;
            this.yearOfedidtion = yearOfedidtion;
            this.downloadNumber = downloadNumber;
        }
        public void Show()
        {
            Console.WriteLine(artist);
            Console.WriteLine(album);
            Console.WriteLine(songsNumber);
            Console.WriteLine(yearOfedidtion);
            Console.WriteLine(downloadNumber);
            Console.WriteLine();
        }
    }


    
    internal class Program
    {
        private static void ShowAlbums(List<Realsed> albums)
        {
            foreach (var album in albums)
            {
                album.Show();
            }
        }

        static void Main(string[] args)
        {


            string filePath = Path.Combine(AppContext.BaseDirectory, "Data.txt");
            string[] lines = File.ReadAllLines(filePath);
            List<Realsed> albums = new List<Realsed>();
            for (int i = 0; i < lines.Length; i += 6)
            {

                Realsed album = new Realsed(lines[i], lines[i + 1], int.Parse(lines[i + 2])
                    , int.Parse(lines[i + 3]), int.Parse(lines[i + 4]));

                albums.Add(album);

            }
            ShowAlbums(albums);




        }
         
    }
}