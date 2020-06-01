using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int myInt = 5;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");

        myInt = 22;
        Debug.Log(MultiplyByTwo(myInt));
    }

    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
