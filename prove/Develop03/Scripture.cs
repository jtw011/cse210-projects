class Scripture{

private List<Word>words;
public bool AllWordsHidden => words.All(w => w.IsHidden);
public Reference Reference {get;} 
public Scripture(string reference, string text)
{
    Reference = new Reference(reference);
    words = text.Split(' ').Select(word => new Word(word)).ToList();
}
public void displayWithHiddenWords()
{
    Console.WriteLine($"{Reference} - {GetVisibleText()}");
}

private string GetVisibleText()
{
    return string.Join(" ", words.Select(word => word.IsHidden ? "_____" : word.Text));
}
public void HideRandomWord()
{
    var visibleWords = words.Where(w => !w.IsHidden).ToList();
    if (visibleWords.Count > 0)
    {
        var random = new Random();
        int index = random.Next(visibleWords.Count);
        visibleWords[index].IsHidden = true;
    }
}


}