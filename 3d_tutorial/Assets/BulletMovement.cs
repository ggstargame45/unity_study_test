using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // 오브젝트 이동 속도
    public float lifespan = 5.0f; // 오브젝트 수명 (초)

    private float startTime;


    void Start()
    {
        startTime = Time.time; // 오브젝트 생성 시간 저장
    }

    void Update()
    {
        // 일정 시간마다 오브젝트를 앞으로 이동
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // 일정 시간 이후에 오브젝트를 삭제
        if (Time.time - startTime >= lifespan)
        {
            Destroy(gameObject);
        }
    }

    async void OnTriggerStay(Collider other)
    {
        // 특정 오브젝트와 닿으면 닿은 오브젝트와 함께 삭제
        if (other.gameObject.tag == "Enemy")
        {
            GameObject.Find("SoundMaker").GetComponent<AudioSource>().Play();
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }

}
