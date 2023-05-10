using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{

    //https://chat.openai.com/c/82b90109-152b-4d5a-97bd-008081cccd65

    public TMP_Text txtGold;
    public int goldInVault;

    public float totalPromissoryNotesIssued;
    public int promissoryNoteRatio = 2;

    public int promissoryNoteRatioMax; //need to implement this into the logic
    public int promissoryNoteRatioMin; //need to implement this into the logic

    //temp
    public int maxPromissoryNotes;
    private void Start()
    {
        totalPromissoryNotesIssued = 0;
    }

    public void UpdateUi()
    {
        txtGold.text = goldInVault.ToString();
    }

    public void IssuePromissoryNote()
    {
        // Calculate the maximum number of promissory notes the player can issue based on the chosen ratio
        //int maxPromissoryNotes = goldInVault * promissoryNoteRatio;
        maxPromissoryNotes = goldInVault * promissoryNoteRatio;

        // Check if the player has reached their maximum number of promissory notes
        if (totalPromissoryNotesIssued < maxPromissoryNotes)
        {
            // Increment the total number of promissory notes issued by the player
            totalPromissoryNotesIssued++;

            // Display a message to the player indicating that they have issued a promissory note
            Debug.Log("You have issued a promissory note..");

            // Deduct the appropriate amount of gold from the player's vault
            //goldInVault--;
        }
        else
        {
            // Display a message to the player indicating that they cannot issue any more promissory notes
            Debug.Log("You cannot issue any more promissory notes..");
        }
    }
}
