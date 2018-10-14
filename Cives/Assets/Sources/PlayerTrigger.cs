using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    Dictionary<int, Decor> DecorInCollision = new Dictionary<int, Decor>();

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("item enter");
        if (other.gameObject.CompareTag("Interactable") == true)
        {
            Decor enterdecor = (Decor)other.gameObject.GetComponent(typeof(Decor));
            Debug.Log(other.name + " enter " + enterdecor.GetInstanceID());
            if (enterdecor != null)
                DecorInCollision.Add(other.gameObject.GetInstanceID(), enterdecor);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("item exit");
        if (other.gameObject.CompareTag("Interactable") == true)
        {
            Decor exitdecor = (Decor) other.gameObject.GetComponent( typeof(Decor) );
            Debug.Log(other.name + " exit " + exitdecor.GetInstanceID());
            if (DecorInCollision.ContainsKey(other.gameObject.GetInstanceID()) == true)
            {
                Debug.Log(other.name + " remove " + exitdecor.GetInstanceID());
                DecorInCollision.Remove(other.gameObject.GetInstanceID());
            }
        }
    }

    private void cleanCollisions()
    {
        List<int> goToDelete = new List<int>();

        foreach (KeyValuePair<int, Decor> elem in DecorInCollision)
            if (elem.Value == null)
                goToDelete.Add(elem.Key);
        foreach (int key in goToDelete)
            DecorInCollision.Remove(key);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cleanCollisions();
            foreach (KeyValuePair<int, Decor> elem in DecorInCollision)
            {
                DecorInCollision[elem.Key].Interact();
                break;
            }
        }
    }
}
