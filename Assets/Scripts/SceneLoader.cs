using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    [SerializeField]
    string StartButtonScene;

    [SerializeField]
    string CreditsButtonScene;
	
	public void OnStartButtonPress ()
    {
        SceneManager.LoadScene(StartButtonScene);
	}

    public void OnCreditsButtonPress()
    {
        SceneManager.LoadScene(CreditsButtonScene);
    }

    //TODO: Add a scene and music fade into darkness
    // add explosion clip to play at the end
    // then load scene

}
