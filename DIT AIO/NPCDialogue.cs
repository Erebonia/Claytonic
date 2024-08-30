using System.Threading.Tasks;
using System;
using System.Windows.Forms;


public class NPCDialogue
{
    private string[] phrases = {
        "Hover over buttons to view their description!", 
        "For any issues with the tool please contact Bao Nguyen from DIT Helpdesk!",
        "Welcome to Claytonic. A program dedicated to helpdesk technicians :)"
    };
    private int currentPhraseIndex = -1; // Initialize to -1 to indicate no previous phrase
    private Label dialogueLabel; // Reference to the Label control

    public NPCDialogue(Label label)
    {
        dialogueLabel = label;
    }

    public async Task StartDialogue(int charDelay, int phraseDelay)
    {
        for (int i = 0; i < phrases.Length; i++)
        {
            string phrase = GetRandomPhrase();
            await ShowTextOneCharacterAtATime(phrase, charDelay);
            await Task.Delay(phraseDelay);
        }
    }

    private string GetRandomPhrase()
    {
        // Create a new instance of Random to generate random numbers
        Random random = new Random();
        int newPhraseIndex;

        do
        {
            // Assign a new random index to newPhraseIndex, which corresponds to a phrase in the phrases array
            newPhraseIndex = random.Next(phrases.Length);

            // This loop continues if the newly generated index is the same as the currentPhraseIndex
            // This ensures that the newly selected phrase is not the same as the one previously shown
        } while (newPhraseIndex == currentPhraseIndex);

        // Update currentPhraseIndex to the new index after a different phrase is selected
        currentPhraseIndex = newPhraseIndex;

        // Return the phrase at the newly selected index
        return phrases[currentPhraseIndex];
    }


    private async Task ShowTextOneCharacterAtATime(string text, int delay)
    {
        dialogueLabel.Text = ""; // Clear the Label to start the typewriter effect

        foreach (char c in text)
        {
            dialogueLabel.Text += c.ToString(); // Append text to the Label
            await Task.Delay(delay); 
        }
    }
}
