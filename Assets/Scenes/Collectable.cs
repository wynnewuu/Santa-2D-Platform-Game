using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;

public class Collectable : MonoBehaviour


{ 
    public GameObject Ob;
    void OnTriggerEnter(Collider other) 
    {
        Destroy(Ob);



    }

    void Update() {




}
}
