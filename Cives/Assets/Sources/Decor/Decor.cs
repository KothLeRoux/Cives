using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decor : MonoBehaviour
{
    public int decorId;
    public DecorScript[] triggers;

    public void Interact()
    {
        foreach (DecorScript elem in triggers)
            elem.Trigger(gameObject, "nothing");
        DecorScript[] scripts = GetComponents<DecorScript>();
        foreach (DecorScript script in scripts)
            script.selfTrigger();
    }

    // temporary, need Cives interaction to be deleted
    private void OnMouseUpAsButton()
    {
        Interact();
    }
}
