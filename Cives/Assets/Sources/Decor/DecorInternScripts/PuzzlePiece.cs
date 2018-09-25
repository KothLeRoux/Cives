using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePiece : DecorScript
{

    public Material[] lvlsmaterials;
    public Material selectedMaterial;
    bool isSelected = false;
    int lvl;

    public bool IsSelected
    {
        get
        {
            return isSelected;
        }
    }

    private void Start()
    {
        GetComponent<Renderer>().material = lvlsmaterials[0];
    }

    public override void Trigger(GameObject other, string parameter)
    {
        if (other.GetComponent<PuzzlePiece>() != null)
        {
            if (parameter == "increase")
                ++lvl;
            else if (parameter == "decrease")
                --lvl;
            lvl = lvl % lvlsmaterials.Length;
            if (lvl < 0)
                lvl = lvlsmaterials.Length - 1;
            updateMaterial();
        }
    }

    public override void selfTrigger()
    {
        isSelected = !IsSelected;
        updateMaterial();
    }

    private void updateMaterial()
    {
        if (IsSelected == true)
            GetComponent<Renderer>().material = selectedMaterial;
        else
            GetComponent<Renderer>().material = lvlsmaterials[lvl];
    }
}
