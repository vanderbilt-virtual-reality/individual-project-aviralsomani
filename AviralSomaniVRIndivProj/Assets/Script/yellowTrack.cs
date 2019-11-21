using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowTrack : MonoBehaviour
{
    public trackAll tracker;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "YellowSphere")
        {
            tracker.UpdateYellow();
        }
        tracker.Checker();
    }
}
