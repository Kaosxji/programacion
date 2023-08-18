using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Canciones
{
    class Program
    {
        private static int MetalProgresivo;
        private static int seventytwoSeasons;

        private static  int StrollDownTheRabbitHole;
        private static  int Swagger;
        private static int WarnerMusicGroup;
        public static int HeavyMetal;
        public static int WindupRecords;
        public static int Fallen;
        public static int RockAlternativo;
        public static int GuillotineGrooves;
        private static readonly int Frederhythm3;
        private static readonly int JRock;

        static void Main(string[] args)
        {
            Cancion GoingUnder = new Cancion();
            GoingUnder.Duracion = 3;
            GoingUnder.album = new Album();
            GoingUnder.album.NombreDelAlbum = Fallen;
            GoingUnder.album.AñoDePublicacion = 203;
            GoingUnder.artista = new Artista();
            GoingUnder.artista.Evanecence =
            GoingUnder.album.Genero = RockAlternativo;
            GoingUnder.album.Discografica = WindupRecords;


            Cancion Inamorata = new Cancion();
            Inamorata.Duracion = 11;
            Inamorata.album = new Album();
            Inamorata.album.NombreDelAlbum = seventytwoSeasons;
            Inamorata.album.AñoDePublicacion = 2023;
            Inamorata.album.Genero = HeavyMetal;
            Inamorata.album.Discografica = WarnerMusicGroup;
            Inamorata.artista = new Artista();
            Inamorata.artista.Metalica =0;

            Cancion CelebremosLoInevitable = new Cancion();
            CelebremosLoInevitable.Duracion = 5;
            CelebremosLoInevitable.album = new Album();
            CelebremosLoInevitable.album.NombreDelAlbum = Swagger&StrollDownTheRabbitHole;
            CelebremosLoInevitable.album.AñoDePublicacion = 2021;
            CelebremosLoInevitable.album.Genero = MetalProgresivo;
            CelebremosLoInevitable.album.Discografica = GuillotineGrooves;
            CelebremosLoInevitable.artista = new Artista();
            CelebremosLoInevitable.artista.DiabloSwingOrchetra = 0;

            Cancion Junkie = new Cancion();
            Junkie.Duracion = 3;
            Junkie.album = new Album();
            Junkie.album.NombreDelAlbum = Frederhythm3;
            Junkie.album.AñoDePublicacion = 2022;
            Junkie.album.Genero = JRock;
            Junkie.album.Discografica = WarnerMusicGroup;
            Junkie.artista = new Artista();
            Junkie.artista.Frederic = 0;













        }
    }
}
