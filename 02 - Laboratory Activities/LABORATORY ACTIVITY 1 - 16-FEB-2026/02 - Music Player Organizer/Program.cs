void Main(){

    int numOfSongs;
    double totalDuration = 0.0;
    double averageDuration = 0.0;

    Console.Write("Songs to add: ");
    numOfSongs = int.Parse(Console.ReadLine());

    Song[] playlist = new Song[numOfSongs];

    for(int i = 0; i < numOfSongs; i++){
        Console.WriteLine();
        Console.WriteLine($"Song #{i+1}:");
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Artist: ");
        string artist = Console.ReadLine();
        Console.Write("Duration (in minutes): ");
        double duration = double.Parse(Console.ReadLine());

        totalDuration += duration;

        playlist[i] = new Song(title, artist, duration);
    }

    averageDuration = totalDuration / numOfSongs;

    Console.WriteLine();
    Console.WriteLine("=== || MY PLAYLIST || ===");
    Console.WriteLine($"{"Title",-20}{"Artist",-15}{"Time",-15}");
    Console.WriteLine(new string('-', 45));

    for(int i = 0; i < numOfSongs; i++){
        playlist[i].DisplaySong(playlist);
    }

    Console.WriteLine();
    Console.WriteLine($"Total Duration: {totalDuration} mins");
    Console.WriteLine($"Average Duration: {averageDuration:F2} mins");
}

Main();


class Song{
    
    private string title;
    private string artist;
    private double duration;

    //Default constructor
    public Song() : this("Unknown", "Unknown", 0.0) {}

    //Overloaded constructor
    public Song(string title, string artist) : this(title, artist, 0.0){}

    //Parametarized constructor
    public Song(string title, string artist, double duration){
        this.title = title;
        this.artist = artist;
        this.duration = duration;
    }

    //Methods 
    public void DisplaySong(Song[] playlist){
        Console.Write($"{title,-20}");
        Console.Write($"{artist,-15}");
        Console.WriteLine($"{duration,-15:F2}");
    }


}
