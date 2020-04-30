using System;
using System.IO;

public class FileWatcher
{
    public static void Main(string[] args)
    {
        // If a directory is not specified, exit program.

        try
        {
            Console.WriteLine("Enter Folder to watch");
            string path = Console.ReadLine();

            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            // Create a new FileSystemWatcher and set its properties.
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = path;

            // Watch both files and subdirectories.
            watcher.IncludeSubdirectories = true;

            // Watch for all changes specified in the NotifyFilters
            //enumeration.
            watcher.NotifyFilter = NotifyFilters.Attributes |
            NotifyFilters.CreationTime |
            NotifyFilters.DirectoryName |
            NotifyFilters.FileName |
            NotifyFilters.LastAccess |
            NotifyFilters.LastWrite |
            NotifyFilters.Security |
            NotifyFilters.Size;

            // Watch all files.
            string[] filters = { };
            watcher.Filter = "*.*";


            // Add event handlers.
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnCreated);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            //Start monitoring.
            watcher.EnableRaisingEvents = true;

            //    //Do some changes now to the directory.
            //    //Create a DirectoryInfo object.
            //    DirectoryInfo d1 = new DirectoryInfo(args[0]);

            //    //Create a new subdirectory.
            //    d1.CreateSubdirectory("mydir");

            //    //Create some subdirectories.

            //    d1.CreateSubdirectory("mydir1\\mydir2\\mydir3");

            //    //Move the subdirectory "mydir3 " to "mydir\mydir3"
            //    Directory.Move(d1.FullName + "file://mydir1//mydir2//mydir3",
            //d1.FullName + "\\mydir\\mydir3");

            //    //Check if subdirectory "mydir1" exists.
            //    if (Directory.Exists(d1.FullName + "\\mydir1"))
            //    {
            //        //Delete the directory "mydir1"
            //        //I have also passed 'true' to allow recursive deletion of
            //        //any subdirectories or files in the directory "mydir1"
            //        Directory.Delete(d1.FullName + "\\mydir1", true);
            //    }

            //    //Get an array of all directories in the given path.
            //    DirectoryInfo[] d2 = d1.GetDirectories();

            //    //Iterate over all directories in the d2 array.
            //    foreach (DirectoryInfo d in d2)
            //    {
            //        if (d.Name == "mydir")
            //        {
            //            //If "mydir" directory is found then delete it recursively.
            //            Directory.Delete(d.FullName, true);
            //        }
            //    }

            // Wait for user to quit program.
            Console.WriteLine("Press \'q\' to quit the sample.");
            Console.WriteLine();

            //Make an infinite loop till 'q' is pressed.
            while (Console.Read() != 'q')
            {
                if (Console.Read() == 'c')
                {
                    Console.Clear();
                }
                //unImplemented
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("A Exception Occurred :" + e);
        }

        catch (Exception oe)
        {
            Console.WriteLine("An Exception Occurred :" + oe);
        }
    }

    private static void OnCreated(object sender, FileSystemEventArgs e)
    {
        if (e.FullPath.EndsWith(".DAT") || e.FullPath.EndsWith(".tmp"))
        {
            return;
        }

        Console.WriteLine("{0}, with path {1} has been {2}", e.Name, e.FullPath, e.ChangeType);
    }

    // Define the event handlers.
    public static void OnChanged(object source, FileSystemEventArgs e)
    {
        // Specify what is done when a file is changed.
        if (e.FullPath.EndsWith(".DAT") || e.FullPath.EndsWith(".tmp"))
        {
            return;
        }

        Console.WriteLine("{0}, with path {1} has been {2}", e.Name, e.FullPath, e.ChangeType);
    }

    public static void OnRenamed(object source, RenamedEventArgs e)
    {
        if (e.FullPath.EndsWith(".DAT") || e.FullPath.EndsWith(".tmp"))
        {
            return;
        }
        // Specify what is done when a file is renamed.
        Console.WriteLine(" {0} renamed to {1}", e.OldFullPath, e.FullPath);
    }
}