using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class CheckEndGame : MonoBehaviour {

    [SerializeField]
    string creditsScene;

    [SerializeField]
    private FirstPersonController firstPersonController;

    void FixedUpdate ()
    {
        CheckDetonation();	
	}

    void CheckDetonation()
    {
        if(Door.isDetonated == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(creditsScene);
        }
    }
}
