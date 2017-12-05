using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorActivator : MonoBehaviour, IActivatable {

    public GameObject leftDoor;
    public GameObject rightDoor;
    public GameObject thisLight;

    Animator leftAnimator;
    Animator rightAnimator;
    Light activateLight;

    [SerializeField]
    private string nameText;

    public string NameText
    {
        get
        {
            return nameText;
        }
    }

    public void DoActivate()
    {
        leftAnimator.SetBool("Open", true);
        rightAnimator.SetBool("Open", true);
        Debug.Log("Doors Opened");
        activateLight.color = Color.green;
    }

    private void Awake()
    {
        leftAnimator = leftDoor.GetComponent<Animator>();
        rightAnimator = rightDoor.GetComponent<Animator>();
        activateLight = thisLight.GetComponent<Light>();
    }

    
}
