using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float minX = -5f;
    public float maxX = 5f;
    public float fixedY = 0f;
    public float moveSpeed = 2f;

    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform; // 특정 오브젝트 찾기
        SpawnRandomPosition();
    }

    void Update()
    {
        // 특정 오브젝트를 따라다니기
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        }
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    다른 오브젝트와 닿으면 게임 오버 처리
    //    if (other.CompareTag("Obstacle"))
    //    {
    //        GameManager.GameOver(); // 게임 오버 함수 호출
    //    }
    //}

    void SpawnRandomPosition()
    {
        // 랜덤한 위치에서 특정 오브젝트 생성
        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPosition = new Vector3(randomX, fixedY, Random.Range(minX, maxX));
        transform.position = spawnPosition;
    }
}
