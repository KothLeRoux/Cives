using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DecorFactory : MonoBehaviour
{

    GameObject[] _rawPrefabs;
    Dictionary<int, GameObject> _prefabs;

	// Use this for initialization
	public void initialize()
    {
        Debug.Log("init");
        _rawPrefabs = Resources.LoadAll<GameObject>("Prefabs/Gettable");
        _prefabs = new Dictionary<int, GameObject>();
        foreach (GameObject go in _rawPrefabs)
        {
            Debug.Log("new input");
            Decor decor = go.GetComponent<Decor>();
            _prefabs.Add(decor.decorId, go);
        }
        foreach(KeyValuePair<int, GameObject> elem in _prefabs)
        {
            Debug.Log(elem.Key + " : " + elem.Value.name);
        }
	}

    public GameObject LoadItem(int type, Vector3 position, Quaternion rotation, Transform parent)
    {
        GameObject newgo = Instantiate(_prefabs[type], position, rotation, parent);

        return (newgo);
    }
}
