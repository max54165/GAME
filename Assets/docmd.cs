using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class docmd : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
 // Update is called once per frame
	void Update () {
		
	}
    public void doPlay()
    {
        Debug.Log("doPlay");
        SceneManager.LoadScene("ball");
    }
    public void doExit()
    {
        Debug.Log("doExit");
        Application.Quit();
    }
}
