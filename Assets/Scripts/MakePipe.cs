using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe; // GameObject 자료형을 가진 변수 안에 프리팹 넣어줌
    float timer = 0;
    public float timeDiff;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff) {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(5, Random.Range(-3.0f,5.0f), 0); // 특정 위치 값을 지정해주려면 new
            // -3 ~ 5
            timer = 0;

            Destroy(newpipe, 8.0f);
        }
    }
}
