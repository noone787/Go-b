using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHangeLayerTo : MonoBehaviour
{
    public GameObject platforms;
    public GameObject Shadow;
    void OnTriggerEnter2D()
    {
        platforms.SetActive(true);
        Shadow.SetActive(false);
    }
}
