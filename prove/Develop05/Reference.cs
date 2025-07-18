public class Reference
{
    private string book;
    private int chapter;
    private int verseStart;
    private int verseEnd;  // for ranges like 5-6

    // Constructor for single verse (e.g., John 3:16)
    public Reference(string book, int chapter, int verseStart)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.verseEnd = verseStart;  // same as start verse
    }

    // Constructor for verse range (e.g., Proverbs 3:5-6)
    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.verseEnd = verseEnd;
    }

    public override string ToString()
    {
        // Return a string like "John 3:16" or "Proverbs 3:5-6"
        if (verseStart == verseEnd)
        {
            return $"{book} {chapter}:{verseStart}";
        }
        else
        {
            return $"{book} {chapter}:{verseStart}-{verseEnd}";
        }
    }
}
