using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueTrack : MonoBehaviour
{
    public trackAll tracker;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "BlueSphere")
        {
            tracker.UpdateBlue();
        }
        tracker.Checker();
    }
}
