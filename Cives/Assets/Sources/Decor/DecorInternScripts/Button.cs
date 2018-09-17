using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : DecorScript
{
    bool isButtonPress;
    int step = 50;
    Dictionary<int, Vector3> stepStateDecal;
    Vector3 originPos;
    int lastDecalKey;

    // Use this for initialization
    void Start () {
        Transform trans = GetComponent<Transform>();
        originPos = trans.position;
        stepStateDecal = new Dictionary<int, Vector3>();
        stepStateDecal.Add(0, new Vector3(0, 0, 0));
        stepStateDecal.Add(15, new Vector3(-0.5f, 0, 0));
        stepStateDecal.Add(35, new Vector3(-0.5f, 0, 0));
        stepStateDecal.Add(50, new Vector3(0, 0, 0));
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (step < 50)
        {
            foreach (KeyValuePair<int, Vector3> elem in stepStateDecal)
            {
                if (step == elem.Key)
                {
                    lastDecalKey = elem.Key;
                    Transform trans = GetComponent<Transform>();
                    trans.position = new Vector3(originPos.x + elem.Value.x, originPos.y + elem.Value.y, originPos.z + elem.Value.z);
                }
                else if (step < elem.Key)
                {
                    Transform trans = GetComponent<Transform>();
                    trans.position = new Vector3(trans.position.x + ((elem.Value.x - stepStateDecal[lastDecalKey].x) / (elem.Key - lastDecalKey))
                        , trans.position.y + ((elem.Value.y - stepStateDecal[lastDecalKey].y) / (elem.Key - lastDecalKey))
                        , trans.position.z + ((elem.Value.z - stepStateDecal[lastDecalKey].z) / (elem.Key - lastDecalKey)));
                    ++step;
                    return;
                }
            }
        }
    }

    public override void Trigger(GameObject other, string parameter)
    {
    }

    public override void selfTrigger()
    {
        lastDecalKey = -1;
        step = 0;
    }
}
