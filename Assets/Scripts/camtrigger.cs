using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camtrigger : MonoBehaviour
{
    public Camera newcam;
    public Camera normalcam;
    public NewPlayerMovementlvl5 newmove;

    private void Start()
    {
        
    }
    void OnTriggerEnter()
    {
        
        newmove.SlowSpeed();
        newcam.enabled = true;
        normalcam.enabled = false;


    }
}
