using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JournalDayManager : MonoBehaviour {
    [Header("Variables to Start Functions")]
    public Text journalDayNumber;
    private MonthDayManager dayInstance;

    [Header("User Inputs")]
    public InputField journalEntry;
    private Color humorColor;

    #region Start Functions
    //Set which day we are currently working on
    public void SetDayInstance(MonthDayManager currentDay)
    {
        dayInstance = currentDay;
        SetJournalEntry();
        SetHumorColor();
    }

    //Set the day that is shown at top left corner
    public void SetJournalDay(Text currentDay)
    {
        journalDayNumber.text = currentDay.text;
    }

    //Set the entry saved in the day selected
    private void SetJournalEntry()
    {
        journalEntry.text = dayInstance.journal;
    }

    //Set the humor color saved in the day selected
    private void SetHumorColor()
    {
        humorColor = dayInstance.box.color;
    }
    #endregion

    //Set the humor color when user presses the humor button
    public void SetHumorColor(int humorIndex)
    {
        /*
        1: Super Happy
        2: Happy
        3: Ok
        4: Sad
        5: Super Sad
        */
        switch(humorIndex)
        {
            case 1:
                ColorUtility.TryParseHtmlString("#F49637", out humorColor);
                break;

            case 2:
                ColorUtility.TryParseHtmlString("#F7B82B", out humorColor);
                break;

            case 3:
                ColorUtility.TryParseHtmlString("#FAE03F", out humorColor);
                break;

            case 4:
                ColorUtility.TryParseHtmlString("#FF9491", out humorColor);
                break;

            case 5:
                ColorUtility.TryParseHtmlString("#FE6650", out humorColor);
                break;
        }
    }

    private void OnDisable()
    {
        dayInstance.SetDay(humorColor, journalEntry.text);
    }
}
