using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0f; // 회전 속도 
    void Start()
    {

    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("화면을 클릭 했다.");
            rotSpeed = 5f;
        }
        transform.Rotate(0, 0, rotSpeed);
    }
}
