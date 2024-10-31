

using System.Security.Cryptography.X509Certificates;

namespace MauiApp3
{
    class Realsed
    {
        public string Artist { get; set; }
        public string Album { get; set; }
        public int SongsNumber { get; set; }
        public int YearOfedidtion { get; set; }
        public int DownloadNumber { get; set; }

    

        public Realsed(string artist,
        string album,
        int songsNumber,
        int yearOfedidtion,
        int downloadNumber)
        {
            Artist = artist;
            Album = album;
            SongsNumber = songsNumber;
            YearOfedidtion = yearOfedidtion;
            DownloadNumber = downloadNumber;
        }
        public void Show()
        {
            Console.WriteLine(Artist);
            Console.WriteLine(Album);
            Console.WriteLine(SongsNumber);
            Console.WriteLine(YearOfedidtion);
            Console.WriteLine(DownloadNumber);
            Console.WriteLine();
        }
    }
    public partial class MainPage : ContentPage
    {

        public int index = 0;
        private List<Realsed> albums;
        public MainPage()
        {

            string filePath = Path.Combine(AppContext.BaseDirectory, "Data.txt");
            string[] lines = File.ReadAllLines(filePath);
            albums = new List<Realsed>();
            for (int i = 0; i < lines.Length; i += 6)
            {

                Realsed album = new Realsed(lines[i], lines[i + 1], int.Parse(lines[i + 2])
                    , int.Parse(lines[i + 3]), int.Parse(lines[i + 4]));

                albums.Add(album);

            }
            InitializeComponent();


            labelArtist.Text = albums[index].Artist;
            labelAlbum.Text = albums[index].Album;
            labelSongsNumber.Text = albums[index].SongsNumber.ToString()+ " utworów";
            labelYearOfedidtion.Text = albums[index].YearOfedidtion.ToString();
            labelDownloadNumber.Text = albums[index].DownloadNumber.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (index == albums.Count - 1)
            {
                index = 0;
                labelArtist.Text = albums[index].Artist;
                labelAlbum.Text = albums[index].Album;
                labelSongsNumber.Text = albums[index].SongsNumber.ToString() + " utworów";
                labelYearOfedidtion.Text = albums[index].YearOfedidtion.ToString();
                labelDownloadNumber.Text = albums[index].DownloadNumber.ToString();
                return;
            }
            index += 1;
            labelArtist.Text = albums[index].Artist;
            labelAlbum.Text = albums[index].Album;
            labelSongsNumber.Text = albums[index].SongsNumber.ToString() + " utworów";
            labelYearOfedidtion.Text = albums[index].YearOfedidtion.ToString();
            labelDownloadNumber.Text = albums[index].DownloadNumber.ToString();
            return;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (index == 0)
            {
                index = albums.Count - 1;

            }
            else
            {
                index -= 1;
            }
            labelArtist.Text = albums[index].Artist;
            labelAlbum.Text = albums[index].Album;
            labelSongsNumber.Text = albums[index].SongsNumber.ToString() + " utworów";
            labelYearOfedidtion.Text = albums[index].YearOfedidtion.ToString();
            labelDownloadNumber.Text = albums[index].DownloadNumber.ToString();



        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            albums[index].DownloadNumber += 1;
            labelDownloadNumber.Text=albums[index].DownloadNumber.ToString(); 
        }
    }
    
}
