using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Song> songs = new List<Song>();

        int songCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < songCount; i++)
        {
            var data = Console.ReadLine().Split(';');
            string artistName = data[0];
            string songName = data[1];
            var minutesAndSeconds = data[2].Split(':');

            int songMinutes = 0;
            int songSeconds = 0;

            try
            {
                songMinutes = int.Parse(minutesAndSeconds[0]);
                songSeconds = int.Parse(minutesAndSeconds[1]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            try
            {
                Song song = new Song(artistName, songName, songMinutes, songSeconds);
                songs.Add(song);
                Console.WriteLine("Song added.");
            }
            catch (InvalidArtistNameException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidSongNameException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidSongMinutesException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidSongSecondsException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        int playlistLenght = 0;

        foreach (var song in songs)
        {
            playlistLenght += song.Duaration;
        }
        TimeSpan playlistTimeSpan = TimeSpan.FromSeconds(playlistLenght);

        Console.WriteLine($"Songs added: {songs.Count}");
        Console.WriteLine(
            $"Playlist length: {playlistTimeSpan.Hours}h {playlistTimeSpan.Minutes}m {playlistTimeSpan.Seconds}s");
    }
}