using System;

public class Word
{
    // Attributes
    private string _text;
    private bool _isHidden;

    // Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Methods
    public void Hide()
    {
        _isHidden = true;

    }
    
    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden == false)
        {
            return _text;
        }

        string hiddenText = "";

        foreach (char character in _text)
        {
            if (char.IsLetterOrDigit(character))
            {
                hiddenText = hiddenText + "_";
            }
            else
            {
                hiddenText = hiddenText + character;
            }
        }

        return hiddenText;
    }
}