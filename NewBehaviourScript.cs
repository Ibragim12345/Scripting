using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        print("AAA");
    }
 
    void FixedUpdate()
    {
        print("AAA " + Time.deltaTime);
    }
}
