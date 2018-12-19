using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonthDayManager : MonoBehaviour {
    public Image box;
    public string journal = "";

    public void Awake()
    {
        box = GetComponent<Image>();
    }

    public void SetDay(Color newColor, string newEntry)
    {
        box.color = newColor;
        journal = newEntry;
    }
}
