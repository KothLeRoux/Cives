using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagPlace : DecorScript {

    public GameObject bag;
    bool isBagOnPlace = false;

    private void Start()
    {
        bag.SetActive(false);
    }

    public override void Trigger(GameObject other, string parameter)
    {
        isBagOnPlace = !isBagOnPlace;
        bag.SetActive(isBagOnPlace);
    }

    public override void selfTrigger()
    {
        isBagOnPlace = !isBagOnPlace;
        bag.SetActive(isBagOnPlace);
    }
}
