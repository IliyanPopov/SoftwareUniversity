public class Song
{
    private const int MinArtistNameLenght = 3;
    private const int MaxArtistNameLenght = 20;
    private const int MinSongNameLenght = 3;
    private const int MaxSongNameLenght = 20;
    private const int MinSongLenghtMinutes = 0;
    private const int MaxSongLenghtMinutes = 14;
    private const int MinSongLenghtSeconds = 0;
    private const int MaxSongLenghtSeconds = 59;

    private string _artistName;

    private int _minutes;

    private int _seconds;

    private string _songName;

    public Song(string artistName, string songName, int minutes, int seconds)
    {
        this.ArtistName = artistName;
        this.SongName = songName;
        this.Minutes = minutes;
        this.Seconds = seconds;
    }

    public string ArtistName
    {
        get { return this._artistName; }
        private set
        {
            if (value.Length < MinArtistNameLenght || value.Length > MaxArtistNameLenght)
            {
                throw new InvalidArtistNameException(
                    $"Artist name should be between {MinArtistNameLenght} and {MaxArtistNameLenght} symbols.");
            }

            this._artistName = value;
        }
    }

    public string SongName
    {
        get { return this._songName; }
        private set
        {
            if (value.Length < MinSongNameLenght || value.Length > MaxSongNameLenght)
            {
                throw new InvalidSongNameException(
                    $"Song name should be between {MinSongNameLenght} and {MaxSongNameLenght} symbols.");
            }

            this._songName = value;
        }
    }

    public int Minutes
    {
        get { return this._minutes; }
        private set
        {
            if (value < MinSongLenghtMinutes || value > MaxSongLenghtMinutes)
            {
                throw new InvalidSongMinutesException(
                    $"Song minutes should be between {MinSongLenghtMinutes} and {MaxSongLenghtMinutes}.");
            }
            this._minutes = value;
        }
    }

    public int Seconds
    {
        get { return this._seconds; }
        private set
        {
            if (value < MinSongLenghtSeconds || value > MaxSongLenghtSeconds)
            {
                throw new InvalidSongSecondsException(
                    $"Song seconds should be between {MinSongLenghtSeconds} and {MaxSongLenghtSeconds}.");
            }

            this._seconds = value;
        }
    }

    public int Duaration
    {
        get { return (this.Minutes * 60) + this.Seconds; }
    }
}