using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decor : MonoBehaviour
{
    public DecorScript[] triggers;

    public void Interact()
    {
        foreach (DecorScript elem in triggers)
            elem.Trigger(gameObject, "nothing");
        DecorScript[] scripts = GetComponents<DecorScript>();
        foreach (DecorScript script in scripts)
            script.selfTrigger();
    }
}
