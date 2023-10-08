public class Prompt
{
//attributes
    private List<string> _PromptList = new List<string>()
    {
    "How has your day been?", 
    "What time did you wake up this morning?",
    "What are you grateful for today?",
    "How have you seen God's hand in your life today?",
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"

    };

//constructor


// methods
    public string RandomPrompt()
    {
        Random randPrompt = new Random();
        int randPromptIndex = randPrompt.Next(_PromptList.Count);
        string promptGet = _PromptList[randPromptIndex];
        return promptGet;
    }

}