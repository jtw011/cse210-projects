public class UserRecord 
{
    private int _totalPoints;
    private string _files;
    
    List<string> _goalList;

    public UserRecord(int totalPoints, string file)
    {
        _totalPoints = totalPoints;
        _files = file;
    }

    public void makeList()
    {
        _goalList = new List<string>();
    }

    public void createFile()
    {
        string fileName = "myFile.txt";

        System.IO.File.Create(fileName);

    }

    public void loadFile()
    {
        using (System.IO.StreamReader file = new System.IO.StreamReader(_files))
        {
            string line;
            while((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }

    public void Display()
    {
        foreach (string goal in _goalList)
        {
            Console.WriteLine(goal);
        }
    }
}