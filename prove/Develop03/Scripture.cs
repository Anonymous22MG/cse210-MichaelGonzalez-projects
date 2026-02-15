using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] parts = text.Split(' ');

        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();

        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        string scriptureText = string.Join(" ", displayWords);

        return $"{referenceText} - {scriptureText}";
    }

public void HideRandomWords(int numberToHide)
{
    //Only hide words that are not already hidden
    List<int> visibleIndexes = new List<int>();

    for (int i = 0; i < _words.Count; i++)
    {
        if (!_words[i].IsHidden())
        {
            visibleIndexes.Add(i);
        }
    }

    int toHide = Math.Min(numberToHide, visibleIndexes.Count);

    for (int i = 0; i < toHide; i++)
    {
        int randomPick = _random.Next(visibleIndexes.Count);
        int wordIndex = visibleIndexes[randomPick];

        _words[wordIndex].Hide();

        // Avoid to pick the same word twice in this round
        visibleIndexes.RemoveAt(randomPick);
    }
}

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}
