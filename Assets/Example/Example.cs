using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Example : MonoBehaviour
{

    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            //跳转到Example场景
            Debug.Log("跳转到Example场景");
            SceneManager.LoadScene("Example");
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
        
            go.gameObject.SetActive(true);
        }
    }
}
