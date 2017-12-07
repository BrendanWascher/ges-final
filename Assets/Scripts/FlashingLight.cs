using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingLight : MonoBehaviour {

    [SerializeField]
    float flashingDuration;

    [SerializeField]
    float intensityChange;

    [SerializeField]
    float delay;

    private float timer;
    private bool isReveresed;
    private bool isInitialDelay;

    public Light RedLight;

	// Use this for initialization
	void Start ()
    {
        timer = flashingDuration;
        timer += delay;
        CheckForDelay();
        isReveresed = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        CheckFlash();
	}

    void CheckForDelay()
    {
        if (timer > flashingDuration)
            isInitialDelay = true;
        else
            isInitialDelay = false;
    }

    void CheckFlash()
    {
        if(timer >= 0)
        {
            if(isInitialDelay)
            {
                if(timer >= flashingDuration)
                {
                    timer -= Time.deltaTime;
                }
                else
                {
                    isInitialDelay = false;
                }
            }
            else if(isReveresed == false)
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

        if(timer > flashingDuration && isInitialDelay == false)
        {
            isReveresed = false;
            timer = flashingDuration;
        }
       
    }
}
