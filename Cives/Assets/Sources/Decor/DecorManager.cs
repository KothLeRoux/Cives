using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorManager : MonoBehaviour
{
    public DecorFactory factory;

    private void Start()
    {
        factory.initialize();
    }

    private void Update()
    {
    }
}
