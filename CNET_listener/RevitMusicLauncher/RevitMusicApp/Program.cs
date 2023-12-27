// Import necessary namespaces
using System;
using System.Diagnostics;
using System.IO;
using System.Timers;
using NAudio.Wave;

// Define the main program class
class Program
{
    // Entry point of the program
    static void Main()
    {
        // Prompt the user to enter the path of the application to monitor
        Console.WriteLine("Enter the path of the application to monitor:");

        // Specify the path of the application to monitor (Revit in this case)
        string applicationPath = @"C:\Program Files\Autodesk\Revit 2024\Revit.exe";

        // Specify the music file to play
        var cd = Directory.GetCurrentDirectory();
        string musicFilePath = (cd + @"\Local Forecast - Elevator.mp3");

        // Start monitoring the application
        MonitorApplication(applicationPath, musicFilePath);

        // Display a message and wait for user input before exiting
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    // Method to monitor the application and play music
    static void MonitorApplication(string applicationPath, string musicFilePath)
    {
        // Create a ProcessWatcher and an AudioPlayer
        using (var watcher = new ProcessWatcher(applicationPath))
        using (var audioPlayer = new AudioPlayer(musicFilePath))
        {
            // Subscribe to the ProcessStarted event to play music when the monitored application starts
            watcher.ProcessStarted += (sender, e) => audioPlayer.Play();

            // Start the process watcher
            watcher.Start();

            // Display information about the music file and the application being monitored
            Console.WriteLine($"The Music that will play is {musicFilePath}");
            Console.WriteLine($"Monitoring {Path.GetFileName(applicationPath)} for launch. Press any key to stop.");

            // Wait for user input to stop monitoring
            Console.ReadKey();

            // Stop the process watcher
            watcher.Stop();
        }
    }
}

// Class to watch for the launch of a process
class ProcessWatcher : IDisposable
{
    private readonly string _processName;
    private System.Timers.Timer _timer;

    public event EventHandler ProcessStarted;

    // Constructor
    public ProcessWatcher(string processName)
    {
        _processName = Path.GetFileNameWithoutExtension(processName);

        // Create a timer to periodically check if the process is running
        _timer = new System.Timers.Timer(1000); // Check every second
        _timer.Elapsed += CheckProcess;
    }

    // Start the process watcher
    public void Start()
    {
        _timer.Start();
    }

    // Event handler for the timer elapsed event
    private void CheckProcess(object sender, ElapsedEventArgs e)
    {
        // Get processes with the specified name
        Process[] processes = Process.GetProcessesByName(_processName);

        // If the process is running, trigger the ProcessStarted event
        if (processes.Length > 0)
        {
            // Process is running
            Console.WriteLine("Playing music");
            ProcessStarted?.Invoke(this, EventArgs.Empty);

            // Stop the timer to prevent multiple triggers
            _timer.Stop();
        }
    }

    // Stop the process watcher
    public void Stop()
    {
        _timer.Stop();
    }

    // Dispose method to clean up resources
    public void Dispose()
    {
        _timer.Dispose();
    }
}

// Class to play audio
class AudioPlayer : IDisposable
{
    private readonly string _audioFilePath;
    private IWavePlayer _wavePlayer;
    private AudioFileReader _audioFileReader;

    // Constructor
    public AudioPlayer(string audioFilePath)
    {
        _audioFilePath = audioFilePath;
    }

    // Play audio
    public void Play()
    {
        // Stop any ongoing playback
        Stop();

        // Create a WaveOutEvent and an AudioFileReader
        _wavePlayer = new WaveOutEvent();
        _audioFileReader = new AudioFileReader(_audioFilePath);

        // Initialize and play the audio
        _wavePlayer.Init(_audioFileReader);
        _wavePlayer.Play();
    }

    // Stop audio playback
    public void Stop()
    {
        // Stop the wave player and dispose of the audio file reader
        _wavePlayer?.Stop();
        _audioFileReader?.Dispose();
    }

    // Dispose method to clean up resources
    public void Dispose()
    {
        // Dispose of the wave player and the audio file reader
        _wavePlayer?.Dispose();
        _audioFileReader?.Dispose();
    }
}
