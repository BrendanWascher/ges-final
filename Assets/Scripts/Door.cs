using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IActivatable {

    private Animator thisDoor;

    public void DoActivate()
    {
        StartThisDoor();
        thisDoor.SetBool("Open", true);
    }
	
	// Update is called once per frame
	void StartThisDoor ()
    {
        thisDoor = GetComponent<Animator>();
        Debug.Log("Called startdoor");
	}
}
