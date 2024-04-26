using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHangeLayerTo : MonoBehaviour
{
    public GameObject[] platforms;
    void OnTriggerEnter2D()
    {
        for (int i = 0; i < platforms.Length; i++)
        platforms[i].SetActive(true);
    }
}
