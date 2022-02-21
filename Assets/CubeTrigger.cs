using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTrigger : MonoBehaviour
{
    public GameObject[] list = new GameObject[35];
    public GameObject[] forbidden;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /*
    void OnTriggerEnter(Collider other)
    {
        //if the object is not forbidden
        for (int i = 0; i < 6; i++)
        {
            if (other.gameObject == forbidden[i])
            {
                return;
            }
        }
        //add the object to the list, in the first available slot
        for (int i = 0; i < 35; i++)
        {
            if (list[i] == null)
            {
                list[i] = other.gameObject;
                break;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        //Debug.Log("Considering " + other.gameObject);
        //remove the object from the list
        for (int i = 0; i < 35; i++)
        {
            if (list[i] == other.gameObject)
            {
                //Debug.Log("Removing " + other.gameObject);
                list[i] = null;
                break;
            }
        }
    }
    */
}
