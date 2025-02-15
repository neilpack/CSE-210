using System;
public class Word
{
    // attributes
    private string _text;
    private bool _isHidden;

    // constructor
    public Word(string text) {
        _text = text;
        _isHidden = false; //By Default, the word is visible
    }

    // gets text
    public string GetText(){
        return _isHidden ? new string('_', _text.Length) : _text;
    }


    //method to hide word
    //method to return either underscores or the word based on _isHidden
    public string Erase() {
        _isHidden = true;
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text; }
    }

    // so my other classes can sense this
    public bool IsHide() {
        return _isHidden;
    }

    //method to check if finished
    public bool IsFinished()
    {
        return _isHidden; 
    }
}
