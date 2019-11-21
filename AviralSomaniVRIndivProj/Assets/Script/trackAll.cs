using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trackAll : MonoBehaviour
{
    private bool yFlag = false;
    private bool rFlag = false;
    private bool bFlag = false;

    public Text guidance;

    public void UpdateYellow()
    {
        yFlag = true;
    }
    
    public void UpdateRed()
    {
        rFlag = true;
    }

    public void UpdateBlue()
    {
        bFlag = true;
    }

    public void Checker()
    {
        bool flag = false;
        string newGuidance = "";
        if (!yFlag)
        {
            flag = true;
            newGuidance += "You must still return the yellow marker!\n";
        }
        if (!bFlag)
        {
            flag = true;
            newGuidance += "You must still return the blue marker!\n";
        }
        if (!rFlag)
        {
            flag = true;
            newGuidance += "You must still return the red marker!\n";
        }
        if (!flag)
        {
            newGuidance += "You have successfully returned all the markers!";
        }
        guidance.text = newGuidance;
    }
    
    void Start()
    {
        guidance.text = "Welcome to Virtual Geocaching! Find all of the markers and return them to their respctive bins for a full tour of the terrain!";
    }

    // Update is called once per frame
    void Update()
    {
        Checker();
    }
}
