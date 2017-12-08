using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckEndGame : MonoBehaviour {

    [SerializeField]
    string creditsScene;

	void FixedUpdate ()
    {
        CheckDetonation();	
	}

    void CheckDetonation()
    {
        if(Door.isDetonated == true)
        {
            SceneManager.LoadScene(creditsScene);
        }
    }
}
