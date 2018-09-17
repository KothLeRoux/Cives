using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorManager : MonoBehaviour
{
    public bool able = false;
    public bool hasInteract = false;
    public Decor btn;

    private void Start()
    {

    }

    private void Update()
    {
        if (able == true && hasInteract == false)
        {
            btn.Interact();
            hasInteract = true;
        }
    }
}
