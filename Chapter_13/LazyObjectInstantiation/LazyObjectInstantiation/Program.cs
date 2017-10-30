using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyObjectInstantiation
{
    #region Classes for illustration of lazy instantiation
    // Represents a single song. 
    class Song
    {
        public string Artist { get; set; }
        public string TrackName { get; set; }
        public double TrackLength { get; set; }
    }

    // Represents all songs on a player.
    class AllTracks
    {
        // Our media player can have a maximum
        // of 10,000 songs.
        private Song[] allSongs = new Song[10000];

        public AllTracks()
        {
            // Assume we fill up the array
            // of Song objects here.
            Console.WriteLine("Filling up the songs!");
        }
    }

    // The MediaPlayer has-a AllTracks object.
    class MediaPlayer
    {
        // Assume these methods do something useful.
        public void Play() { /* Play a song */ }
        public void Pause() { /* Pause the song */ }
        public void Stop() { /* Stop playback */ }

        // Use a lambda expression to add additional code
        // when the AllTracks object is made.
        private Lazy<AllTracks> allSongs = new Lazy<AllTracks>(() =>
            {
                Console.WriteLine("Creating AllTracks object!");
                return new AllTracks();
            }
        );

        public AllTracks GetAllTracks()
        {
            // Return all of the songs.
            return allSongs.Value;
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Lazy Instantiation *****\n");

            // No allocation of AllTracks object here!
            MediaPlayer myPlayer = new MediaPlayer();
            myPlayer.Play();

            // Allocation of AllTracks happens when you call GetAllTracks().
            MediaPlayer yourPlayer = new MediaPlayer();
            AllTracks yourMusic = yourPlayer.GetAllTracks();

            Console.ReadLine();
        }
    }
}
