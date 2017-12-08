using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    [SerializeField]
    Button startButton;

    [SerializeField]
    Button creditsButton;

	// Use this for initialization
	void Start ()
    {
        startButton = GetComponent<Button>();
        creditsButton = GetComponent<Button>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
