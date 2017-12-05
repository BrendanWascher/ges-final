using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObject : MonoBehaviour, IActivatable {

    [SerializeField]
    private string nameText;

    [SerializeField]
    private string descriptonText;

    private MeshRenderer meshRenderer;

    private Collider thisCollider;

    private List<InventoryObject> playerInventory;

    public string NameText
    {
        get
        {
            return nameText;
        }
    }

    public void DoActivate()
    {
        playerInventory.Add(this);
        meshRenderer.enabled = false;
        thisCollider.enabled = false;
    }

    // Use this for initialization
    void Start ()
    {
        playerInventory = FindObjectOfType<InventoryMenu>().PlayerInventory;
        thisCollider = GetComponent<Collider>();
        meshRenderer = GetComponent<MeshRenderer>();
	}

}
