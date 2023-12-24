using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class Camera : MonoBehaviour
{

    // zwoływanie różnych rzeczy
    public Transform Player_Position;
    Transform Tr;
    void Start(){
        Tr = GetComponent<Transform>();
    }

    // zmiana pozycji
    void Update()
    {   
        float x = Player_Position.position.x;
        float y = Player_Position.position.y;

        Tr.position.Set(x,y,-17);

    }
}
