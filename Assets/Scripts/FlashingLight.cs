using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingLight : MonoBehaviour {

    [SerializeField]
    float flashingDuration;

    private float timer;

    public Light RedLight;

	// Use this for initialization
	void Start ()
    {
        timer = flashingDuration;
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;
        CheckFlash();
	}

    void CheckFlash()
    {
        if(timer > 0)
        {
            // RedLight.light.intensity
        }

        if(timer <= 0)
        {

            
        }
        else
        {

        }
    }
}
