using System.IO.Enumeration;

class Word{

private String _text;
private Boolean _isVisible;
private List<Word> _hiddenList = new List<Word>();

public Word(String text, Boolean isVisible)
{
    text = _text;
    isVisible = _isVisible;
}

public void readScriptureFile()
{
    string fileName = "scripture.txt";
    string content = File.ReadAllText(fileName);
    Console.WriteLine(content);
}

public void hideWord()
{
    
}

public void hiddenWords()
{

}

public void displayAltScripture()
{


}

}