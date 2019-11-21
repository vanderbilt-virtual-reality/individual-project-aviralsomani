using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redTrack : MonoBehaviour
{
    public trackAll tracker;

    void OnTriggerEnter(Collider other)
    {if (other.gameObject.name == "RedSphere")
        {
            tracker.UpdateRed();
        }
        tracker.Checker();
    }
}
