using System;

// 13 Behold, I am a disciple of Jesus Christ, the Son of God.
// I have been called of him to declare his word among his people,
// that they might have everlasting life.

public class Verse
{
    // attributes
    private List<Word> words;
    private Random random;
    
    
    // adds words to the scripture
    public Verse()
    {
    random = new Random();
    words = new List<Word>
    {
        new Word("Behold,"), new Word("I"), new Word("am"), new Word("a"), new Word("disciple"),
        new Word("of"), new Word("Jesus"), new Word("Christ,"), new Word("the"), new Word("Son"),
        new Word("of"), new Word("God."), new Word("I"), new Word("have"), new Word("been"),
        new Word("called"), new Word("of"), new Word("him"), new Word("to"), new Word("declare"),
        new Word("his"), new Word("word"), new Word("among"), new Word("his"), new Word("people,"),
        new Word("that"), new Word("they"), new Word("might"), new Word("have"), new Word("everlasting"),
        new Word("life.")
    };
    }

    //makes it so i can access the words list in scripture.cs
    public List<Word> GetWords()
        {
            return words;
        }


    //chooses a random word and hides it
    public void ChooseRandomWord() {
        if (words.All(word => word.IsHide())) return; // Stop if all words are hidden

        int index;
        do
        {
            index = random.Next(words.Count); // Pick a random index
        } while (words[index].IsHide()); // Repeat if the word is already hidden

        words[index].Erase(); // Hide the selected word
    }

    //method to check if all words are hidden
    public bool IsFinished(){
        return words.All(word => word.IsFinished());
    }
         
}