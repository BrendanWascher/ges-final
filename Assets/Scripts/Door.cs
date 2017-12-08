using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IActivatable
{
    [SerializeField]
    string nameText;

    [Tooltip("If you set a key, the door will be locked.")]
    [SerializeField]
    InventoryObject key;

    //private Animator animator;
    private bool isLocked, isOpen;
    private List<InventoryObject> playerInventory;

    public static bool isDetonated;

    public string NameText
    {
        get
        {
            string toReturn = nameText;

            if (isOpen)
                toReturn = ""; // So it doesn't look like you can open the door anymore.
            else if (isLocked && !HasKey)
                toReturn += " (MISSING EXPLOSIVES)";
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
                //animator.SetBool("isTowerDown", true); 
                isOpen = true;
                if(key.NameText == "Explosives")
                {
                    isDetonated = true;
                }
            }
        }
    }

    // Use this for initialization
    void Start () 
	{
        //animator = GetComponent<Animator>();
        playerInventory = FindObjectOfType<InventoryMenu>().PlayerInventory;
        isLocked = key != null;
        isDetonated = false;
	}
}