using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonthDayManager : MonoBehaviour {
    public Image DayBG { get; set; } 
    public string JournalEntry { get; set; }

    private void Awake()
    {
        DayBG = GetComponent<Image>();
        JournalEntry = "";
    }

    public void SetDayEntry(Color humorColor, string newEntry)
    {
        DayBG.color = humorColor;
        JournalEntry = newEntry;
    }
}
