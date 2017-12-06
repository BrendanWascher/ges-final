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

    [Tooltip("If you set a key, the door will be locked.")]
    [SerializeField]
    InventoryObject key;

    private bool isLocked, isOpen;
    private List<InventoryObject> playerInventory;

    public string NameText
    {
        get
        {
            string toReturn = nameText;

            if (isOpen)
                toReturn = ""; // So it doesn't look like you can open the door anymore.
            else if (isLocked && !HasKey)
                toReturn += " (LOCKED)";
            else if (isLocked && HasKey)
                toReturn += string.Format(" (use {0})", key.NameText);

            return toReturn;
        }
    }

    private bool HasKey
    {
        get
        {
            return playerInventory.Contains(key);
        }
    }

    public void DoActivate()
    {
        if (!isOpen)
        {
            if (!isLocked || HasKey)
            {
                leftAnimator.SetBool("Open", true);
                rightAnimator.SetBool("Open", true);
                //Debug.Log("Doors Opened");
                activateLight.color = Color.green;
                isOpen = true;
            }
        }
    }

    private void Start()
    {
        leftAnimator = leftDoor.GetComponent<Animator>();
        rightAnimator = rightDoor.GetComponent<Animator>();
        activateLight = thisLight.GetComponent<Light>();
        playerInventory = FindObjectOfType<InventoryMenu>().PlayerInventory;
        isLocked = key != null;
    }

    
}
