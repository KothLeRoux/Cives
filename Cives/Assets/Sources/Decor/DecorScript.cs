using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorScript : MonoBehaviour
{
    // can be call when a other GO than iself and if a other script have this purpose
    public virtual void Trigger(GameObject other, string parameter) { }

    // will be call when his own DecorGo is trigger
    public virtual void selfTrigger() { }
}
