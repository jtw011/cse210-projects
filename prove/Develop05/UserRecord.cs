public class UserRecord 
{
    private int _totalPoints;
    private string _files;
    
    List<Goal> _goalList;

    public UserRecord(int totalPoints, string file)
    {
        _totalPoints = totalPoints;
        _files = file;
    }

    public void makeList()
    {
        _goalList = new List<Goal>();
    }

    public void createFile()
    {

        System.IO.File.Create(_files);

    }

    public void SaveGoals()
    {
        using (StreamWriter file = new StreamWriter(_files))
        {
            foreach (Goal goal in _goalList)
            {
                file.WriteLine(goal.ToString());
            }
        }
    }

    public void loadGoals()
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

    public void CreateGoal(Goal goal)
    {
        _goalList.Add(goal);
    }



    public void Display()
    {
        foreach (Goal goal in _goalList)
        {
            goal.Display();
        }
    }
}