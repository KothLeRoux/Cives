using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gettable : DecorScript {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    public override void Trigger(GameObject other, string parameter)
    {
    }

    public override void selfTrigger()
    {
        enabled = false;
        Destroy(this.gameObject);
    }
}
