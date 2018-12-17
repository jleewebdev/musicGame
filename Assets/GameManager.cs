using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance;

    public int points;

	// Use this for initialization
	void Start () {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(this);

        StartGame();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void StartGame() {
        points = 0;
    }
}
