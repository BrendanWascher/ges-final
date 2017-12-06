using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObjectBasic : MonoBehaviour, IActivatable
{
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
        Debug.Log(this.gameObject.name + " was activated.");
    }

}
