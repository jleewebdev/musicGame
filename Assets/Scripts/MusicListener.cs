using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class MusicListener : MonoBehaviour {


    bool canHit = false;
	// Use this for initialization
	void Start () {
        //Koreographer.Instance.RegisterForEventsWithTime("SlipEvent", Pulse);
	}
	
	// Update is called once per frame
	void Update () {
		if (canHit && Input.GetKeyDown(KeyCode.Space)) {
            print("point");
        }
	}

    void Pulse(KoreographyEvent evt, int sampleTime, int sampleDelta, DeltaSlice deltaSlice) {
        if (evt.StartSample >= sampleTime - sampleDelta) {
            print("start event");
            canHit = true;
            GetComponent<Renderer>().material.color = Color.blue;
        }

        if (evt.EndSample <= sampleTime) {
            print("end event");
            canHit = false;
            GetComponent<Renderer>().material.color = Color.red;
        }
    }

    void TurnOn() {

        //GetComponent<Renderer>().material.color = Color.blue;
    }

    void TurnOff() {
        //GetComponent<Renderer>().material.color = Color.red;
    }
}
