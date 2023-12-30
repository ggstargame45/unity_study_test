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
        target = GameObject.FindGameObjectWithTag("Player").transform; // Ư�� ������Ʈ ã��
        SpawnRandomPosition();
    }

    void Update()
    {
        // Ư�� ������Ʈ�� ����ٴϱ�
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        }
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    �ٸ� ������Ʈ�� ������ ���� ���� ó��
    //    if (other.CompareTag("Obstacle"))
    //    {
    //        GameManager.GameOver(); // ���� ���� �Լ� ȣ��
    //    }
    //}

    void SpawnRandomPosition()
    {
        // ������ ��ġ���� Ư�� ������Ʈ ����
        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPosition = new Vector3(randomX, fixedY, Random.Range(minX, maxX));
        transform.position = spawnPosition;
    }
}
