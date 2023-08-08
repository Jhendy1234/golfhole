using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class putt : MonoBehaviour
{
    // Start is called before the first frame update
    void OnMouseDown()
    {
     GetComponent<Rigidbody>().AddForce(-transform.forward * 1, ForceMode.Impulse);
     GetComponent<Rigidbody>().useGravity = true;
    }

}
