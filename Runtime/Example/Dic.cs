using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dic : MonoBehaviour
{
    public string gh;
    public DictionarySerializable<string ,GameObject> keys = new DictionarySerializable<string ,GameObject>();
    public string hh;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in keys)
        {
            Debug.Log(item);
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
