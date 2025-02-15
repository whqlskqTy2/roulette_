using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0f; // 회전 속도 
    private bool isClicked = false; // 추가 실행 방지 변수
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isClicked) // 한 번만 실행되도록 제한
        {
            Debug.Log("화면을 클릭 했다.");
            rotSpeed = Random.Range(1f, 10f);
            isClicked = true; // 추가 실행 차단
        }
        transform.Rotate(0,0,rotSpeed);
        rotSpeed *= 0.998f;
        if (rotSpeed < 0.01f)
        {
            rotSpeed = 0f;
            isClicked = false; // 다시 클릭 가능하게 변경
        }
    }
}
