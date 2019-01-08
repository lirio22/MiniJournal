using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Journal{
    public int DayIndex { get; set; }
    public int Year { get; set; }
    public string Month { get; set; }
    public int Day { get; set; }
    
    public Color HumorColor { get; set; }
    public string JournalEntry { get; set; }
    public bool IsActive { get; set; }

    public Journal(int dayIndex, int year, string month, int day, Color humorColor, string journalEntry, bool isActive)
    {
        DayIndex = dayIndex;
        Year = year;
        Month = month;
        Day = day;
        HumorColor = humorColor;
        JournalEntry = journalEntry;
        IsActive = isActive;
    }
}
