// import : 외부 모듈이나 필요한 거 가져오기
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour // MonoBehaviour 클래스 상속 받음
{
    // Rigidbody2D 라는 클래스 자료형을 가진 rb 변수
    Rigidbody2D rb;
    public float jumpPower;

    void Start()
    {
        // Rigidbody2D 라는 컴포넌트를 가져오겠다
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 마우스 왼쪽 버튼(0)을 눌렀을때 (= 터치했을때)
        if (Input.GetMouseButtonDown(0)) {
            // Vector2.up : (0,1)
            // velocity : 속도 (rigidbody2d 안에 있는 속성)
            rb.velocity = Vector2.up * jumpPower; // y좌표 + 3 
            GetComponent<AudioSource>().Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if (Score.score > Score.bestScore) {
            Score.bestScore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene");
    }
}
