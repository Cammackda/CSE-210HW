public class Word
{
    private string text;
    private bool isHidden;

    public Word(string text)
    {
        this.text = text;
        this.isHidden = false;
    }

    public void Hide()
    {
        isHidden = true;
    }

    public bool IsHidden()
    {
        return isHidden;
    }

    public override string ToString()
    {
        if (isHidden)
        {
            // Return underscores or some placeholder for hidden words
            return new string('_', text.Length);
        }
        else
        {
            return text;
        }
    }
}
