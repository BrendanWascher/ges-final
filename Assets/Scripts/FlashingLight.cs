using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingLight : MonoBehaviour {

    [SerializeField]
    float flashingDuration;

    [SerializeField]
    float intensityChange;

    private float timer;
    private bool isReveresed;

    public Light RedLight;

	// Use this for initialization
	void Start ()
    {
        timer = flashingDuration;
        isReveresed = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        CheckFlash();
	}

    void CheckFlash()
    {
        if(timer >= 0)
        {
            if(isReveresed == false)
            {
                RedLight.intensity -= intensityChange;
                timer -= Time.deltaTime;
            }
            else
            {
                RedLight.intensity += intensityChange;
                timer += Time.deltaTime;
            }
        }
        else
        {
            isReveresed = true;
            timer = 0;
        }

        if(timer > flashingDuration)
        {
            isReveresed = false;
            timer = flashingDuration;
        }
    }
}
