using System.Collections.Generic;
using mvc_training.Domain;

namespace MvcTraining.Services
{
    public class Database
    {
        public static List<Artist> Artists;
        public static List<Album> Albums;
        public static List<Song> Songs;

          
        static Database()
        {
            var beatles = new Artist {Id = 1, Name = "The Beetles"};
            var aerosmith = new Artist {Id = 2, Name = "AeroSmith"};
            var yellow_submarine = new Album {Id = 1, Artist = beatles, Name = "Yellow Submarine"};
            var abbey_road = new Album {Id = 1, Artist = beatles, Name = "Abbey Road"};
            var s1 = new Song {Id = 1,Artist=beatles, Album = yellow_submarine, Name = "Yellow Submarine"};
            var s2 = new Song {Id = 1, Artist = beatles, Album = yellow_submarine, Name = "Only a Northern Song"};
            var s3 = new Song {Id = 1, Artist = beatles, Album = yellow_submarine, Name = "All Together Now"};
            var s4 = new Song {Id = 1, Artist = beatles, Album = yellow_submarine, Name = "Hey Bulldog"};
            var s5 = new Song {Id = 1, Artist = beatles, Album = yellow_submarine, Name = "It's All Too Much"};
            var s6 = new Song {Id = 1, Artist = beatles, Album = yellow_submarine, Name = "All You Need Is Love"};
            yellow_submarine.Songs = new List<Song> {s1, s2, s3, s4, s5, s6};

            
            var s7 = new Song {Id = 1, Artist = beatles, Album =  abbey_road, Name = "Something"};
            var s8 = new Song {Id = 1, Artist = beatles, Album =  abbey_road, Name = "Maxwell's Silver Hammer"};
            var s9 = new Song {Id = 1, Artist = beatles, Album =  abbey_road, Name = "Oh! Darling"};
            var s10 = new Song {Id = 1, Artist = beatles, Album = abbey_road, Name = "Octopus's Garden"};
            var s11 = new Song {Id = 1, Artist = beatles, Album = abbey_road, Name = "I Want You (She's So Heavy)"};
            var s12 = new Song {Id = 1, Artist = beatles, Album = abbey_road, Name = "Here Comes the Sun"};
            var s13 = new Song {Id = 1, Artist = beatles, Album = abbey_road, Name = "Because"};
            var s14 = new Song {Id = 1, Artist = beatles, Album = abbey_road, Name = "Medley"};
            var s15 = new Song {Id = 1, Artist = beatles, Album = abbey_road, Name = "Her Majesty"};
            abbey_road.Songs = new List<Song> {s7, s8, s9, s10, s10, s11, s12, s13, s14, s15};


        } 
    }
}