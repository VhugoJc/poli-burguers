using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket : MonoBehaviour
{
    public GameObject child;
    public GameObject parent;
    public GameObject meal;
    public GameObject cheese;
    public GameObject lettuce;
    public GameObject tomato;
    public GameObject onion;
    public GameObject onion_2;
    public GameObject bread_top;
    public GameObject tomato_2;

    private void Start()
    {
        Reset();

    }
    public void Reset()
    {
        meal.SetActive(false);
        cheese.SetActive(false);
        lettuce.SetActive(false);
        tomato.SetActive(false);
        onion.SetActive(false);
        bread_top.SetActive(false);
        onion_2.SetActive(false);
        tomato_2.SetActive(false);
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag=="ingredient")
        {
            //collision.gameObject.transform.SetParent(parent.transform);
            //collision.gameObject.transform.position = child.transform.position;
            Debug.Log(collision.gameObject.name);
            switch (collision.gameObject.name)
            {
                case "meal":
                    if (!meal.activeSelf)
                    {
                        meal.SetActive(true);
                        Destroy(collision.gameObject);
                    }
                    break;
                case "cheese":
                    if (!cheese.activeSelf)
                    {
                        cheese.SetActive(true);
                        Destroy(collision.gameObject);
                    }
                    break;
                case "lettuce":
                    if (!lettuce.activeSelf)
                    {
                        lettuce.SetActive(true);
                        Destroy(collision.gameObject);
                    }
                    break;
                case "tomato":
                    if (!tomato.activeSelf)
                    {
                        tomato.SetActive(true);
                        Destroy(collision.gameObject);
                    }
                    else
                    {
                        if (!tomato_2.activeSelf)
                        {
                            tomato_2.SetActive(true);
                            Destroy(collision.gameObject);
                        }
                    }
                    break;
                case "onion":
                    if (!onion.activeSelf)
                    {
                        onion.SetActive(true);
                        Destroy(collision.gameObject);
                    }
                    else
                    {
                        if (!onion_2.activeSelf)
                        {
                            onion_2.SetActive(true);
                            Destroy(collision.gameObject);
                        }
                    }
                    break;
                case "bread_top":
                    if (!bread_top.activeSelf)
                    {
                        bread_top.SetActive(true);
                        Destroy(collision.gameObject);
                    }
                    break;
                default:
                    break;
            }

            

            //collision.gameObject.transform.rotation = parent.transform.rotation;
        }
    }
}
