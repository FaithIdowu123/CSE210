using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(" ");
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        List<int> hidden = new List<int>();
        Random ran = new Random();
        int hiddenCount = 0;
        while (hiddenCount < numberToHide)
        {
            int index = ran.Next(_words.Count);
            if (_words[index].IsHidden())
            {
                while (_words[index].IsHidden())
                {
                    index = ran.Next(_words.Count);
                }     
            }

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hidden.Add(index);
            }
           hiddenCount++; 
        }
    }

    public string GetDisplayText()
    {
        string Scripture = _reference.DisplayText() + " - ";
        foreach (Word word in _words)
        {
            Scripture += word.GetDisplayText() + " ";
        }
        return Scripture.Trim();
    }

    public bool IsCompletelyHidden()
    {
        int number = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                number++;
            }
        }
        if (number >= _words.Count())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}