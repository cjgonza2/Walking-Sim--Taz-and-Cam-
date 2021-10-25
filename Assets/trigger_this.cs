using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_this : MonoBehaviour
{
    public AudioSource mySoundSource;
    public float audioClipTime;

    public int timesEntered;

    public Transform warpPoint;
    public GameObject firstPerson;
    
    void OnTriggerEnter()
    {
        //print("whats up dawg?");
        //firstPerson.transform.position = warpPoint.transform.position;
        //mySoundSource.Play();
        firstPerson.transform.position = warpPoint.transform.position;
    }

    //void OnTriggerExit()
    //{
        //mySoundSource.Pause();

        //print("I wish for death");
    //}

    void update()
    {
        //audioClipTime = mySoundSource.time;
    }
}
