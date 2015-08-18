using UnityEngine;
using System.Collections;

public class FlashLight : MonoBehaviour {

    Light dirLight;

    public bool lightEnabled;


	// Use this for initialization
	void Start () {

        dirLight = Light.GetLights(LightType.Spot, 0)[0];

        dirLight.enabled = lightEnabled;


	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.F))
        {
            lightEnabled = !lightEnabled;
            dirLight.enabled = lightEnabled;


        }
        
	
	}
}
