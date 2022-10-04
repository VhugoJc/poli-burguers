using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket : MonoBehaviour
{
    public GameObject child;
    public GameObject parent;

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag=="ingredient")
        {
            collision.gameObject.transform.SetParent(parent.transform);
            collision.gameObject.transform.position = child.transform.position;
            //collision.gameObject.transform.rotation = parent.transform.rotation;
        }
    }
}
