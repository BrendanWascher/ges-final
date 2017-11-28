using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLookedAtObjects : MonoBehaviour {

    [SerializeField]
    private float maxActivateDistance = 4.0f;
	
	// Update is called once per frame
	void Update ()
    {
        Debug.DrawRay(transform.position, transform.forward * maxActivateDistance);
        RaycastHit raycastHit;
        if(Physics.Raycast(transform.position, 
            transform.forward, out raycastHit, maxActivateDistance))
        {
            //Debug.Log(raycastHit.transform.name + " was hit.");

            IActivatable objectLookedAt = raycastHit.transform.GetComponent<IActivatable>();

            if(objectLookedAt != null && Input.GetButtonDown("Activate"))
            {
                objectLookedAt.DoActivate();
            }
        }
	}
}
