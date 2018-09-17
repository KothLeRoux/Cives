using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiner : DecorScript {

    bool isSpinAble = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (isSpinAble)
        {
            Transform trans = GetComponent<Transform>();
            trans.Rotate(new Vector3(0, 15, 0));
        }
	}

    public override void Trigger(GameObject other, string parameter)
    {
        isSpinAble = !isSpinAble;
    }

    public override void selfTrigger()
    {
    }
}
