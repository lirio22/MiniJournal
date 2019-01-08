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
    public GameObject arrow;

    //When the user clicks on a day, it gets the day's informations
    #region Start Functions

    //Get which day we are currently working on
    public void GetDayInstance(MonthDayManager currentDay)
    {
        dayInstance = currentDay;
        GetJournalEntry();
        GetHumorColor();
    }


    //Get the day that is shown at top left corner
    public void GetDayNumber(Text currentDay)
    {
        journalDayNumber.text = currentDay.text;
    }


    //Get the entry saved in the day selected
    private void GetJournalEntry()
    {
        journalEntry.text = dayInstance.JournalEntry;
    }


    //Get the humor color saved in the day selected
    private void GetHumorColor()
    {
        humorColor = dayInstance.DayBG.color;

        //Gets the humor color in hexadecimal to set the arrow position
        switch(ColorUtility.ToHtmlStringRGB(humorColor))
        {
            case "F49637":
                arrow.SetActive(true);
                arrow.transform.localPosition = new Vector3(295.0f, arrow.transform.localPosition.y, arrow.transform.localPosition.z);
                break;

            case "F7B82B":
                arrow.SetActive(true);
                arrow.transform.localPosition = new Vector3(420.0f, arrow.transform.localPosition.y, arrow.transform.localPosition.z);
                break;

            case "FAE03F":
                arrow.SetActive(true);
                arrow.transform.localPosition = new Vector3(545.0f, arrow.transform.localPosition.y, arrow.transform.localPosition.z);
                break;

            case "FF9491":
                arrow.SetActive(true);
                arrow.transform.localPosition = new Vector3(670.0f, arrow.transform.localPosition.y, arrow.transform.localPosition.z);
                break;

            case "FE6650":
                arrow.SetActive(true);
                arrow.transform.localPosition = new Vector3(785.0f, arrow.transform.localPosition.y, arrow.transform.localPosition.z);
                break;
        }
    }
    #endregion


    //Set the humor color when user presses the humor button and the arrow position acording user's humor
    public void SetHumorColor(int humorIndex)
    {
        arrow.SetActive(true);
        /*
        1: Super Happy
        2: Happy
        3: Ok
        4: Sad
        5: Super Sad
        */
        switch (humorIndex)
        {
            case 1:
                ColorUtility.TryParseHtmlString("#F49637", out humorColor);
                arrow.transform.localPosition = new Vector3(295.0f, arrow.transform.localPosition.y, arrow.transform.localPosition.z);
                break;

            case 2:
                ColorUtility.TryParseHtmlString("#F7B82B", out humorColor);
                arrow.transform.localPosition = new Vector3(420.0f, arrow.transform.localPosition.y, arrow.transform.localPosition.z);
                break;

            case 3:
                ColorUtility.TryParseHtmlString("#FAE03F", out humorColor);
                arrow.transform.localPosition = new Vector3(545.0f, arrow.transform.localPosition.y, arrow.transform.localPosition.z);
                break;

            case 4:
                ColorUtility.TryParseHtmlString("#FF9491", out humorColor);
                arrow.transform.localPosition = new Vector3(670.0f, arrow.transform.localPosition.y, arrow.transform.localPosition.z);
                break;

            case 5:
                ColorUtility.TryParseHtmlString("#FE6650", out humorColor);
                arrow.transform.localPosition = new Vector3(785.0f, arrow.transform.localPosition.y, arrow.transform.localPosition.z);
                break;
        }
    }

    private void OnDisable()
    {
        arrow.SetActive(false);
        dayInstance.SetDayEntry(humorColor, journalEntry.text);
    }
}
