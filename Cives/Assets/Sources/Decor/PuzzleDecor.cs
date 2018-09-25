using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleDecor : Decor
{

    public override void Interact()
    {
        DecorScript[] scripts = GetComponents<DecorScript>();
        foreach (DecorScript script in scripts)
            script.selfTrigger();

        string parameter = (GetComponent<PuzzlePiece>().IsSelected == true) ? "increase" : "decrease";

        foreach (DecorScript elem in triggers)
            elem.Trigger(gameObject, parameter);
    }
}
