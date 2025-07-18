using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    // Constructor takes a Reference and a string of scripture text
    public Scripture(Reference reference, string scriptureText)
    {
        this.reference = reference;
        words = new List<Word>();

        // Split scriptureText into words and create Word objects
        string[] splitWords = scriptureText.Split(' ');
        foreach (string word in splitWords)
        {
            words.Add(new Word(word));
        }
    }

    public void Display()
    {
        // Clear console and print reference + scripture with hidden words shown as underscores
        Console.Clear();
        Console.WriteLine(reference.ToString());
        Console.WriteLine();

        // Display all words separated by spaces
        foreach (Word w in words)
        {
            Console.Write(w.ToString() + " ");
        }
        Console.WriteLine();
    }

    public bool HideRandomWords(int count)
    {
        // Hide 'count' random words
        // For core, you can pick random words even if already hidden
        // Return true if all words are now hidden, else false

        Random random = new Random();
        int wordsHiddenThisRound = 0;

        for (int i = 0; i < count; i++)
        {
            int index = random.Next(words.Count);
            if (!words[index].IsHidden())
            {
                words[index].Hide();
                wordsHiddenThisRound++;
            }
        }

        // Check if all words hidden
        foreach (Word w in words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
