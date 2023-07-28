using System;

class fileReader
{
    private string filePath;

    public fileReader(string path)
    {
        filePath = path;
    }

    public string? ReadLine()
    {
        // Implement the logic to read a line from the file
        // and return it as a string. You can use System.IO
        // classes like StreamReader or File to achieve this.
        // This method should handle reading from the file and
        // returning each line one by one.
        throw new NotImplementedException();
    }

    public void Close()
    {
        // Implement the logic to close the file
        // or any other clean-up operations if necessary.
        throw new NotImplementedException();
    }
}

class Program
{
    static void Main()
    {
        const string path = "thoughts.txt";
        fileReader reader = new fileReader(path);

        string? line = reader.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);

            line = reader.ReadLine();
        }

        reader.Close();
    }
}
