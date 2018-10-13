using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {
    UnityEngine.UI.Button btn;

	// Use this for initialization
	void Start () {
        btn = GetComponent<UnityEngine.UI.Button>();
        btn.onClick.AddListener(restart);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void restart() {
        Debug.Log("Restarting!");
        gameObject.SetActive(false);
        GameObject.Find("FirstSquare").GetComponent<FirstSquareScript>().score = 0;
        GameObject.Find("FirstSquare").SetActive(true);
    }
}
