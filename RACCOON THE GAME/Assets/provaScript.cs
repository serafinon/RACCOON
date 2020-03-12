using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class provaScript : MonoBehaviour
{

    [SerializeField]
    GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("prova");
        Instantiate(cube);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
