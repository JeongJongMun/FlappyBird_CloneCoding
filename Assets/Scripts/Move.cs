using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    void Update()
    {
        // Pipe의 x값 변화시키기
        // transform은 기본적으로 가지고 있어서 불러오지 않아도 됨
        // x,y,z 를 가지고 있으니 vector3 사용

        // deltaTime을 곱해주어 다른 환경의 컴퓨터에서 동일 성능을 낼 수 있게함
        transform.position += Vector3.left * Time.deltaTime * speed; // (-1,0,0)
    }
}
