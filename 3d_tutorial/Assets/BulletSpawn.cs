using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject objectToSpawn; // 생성할 오브젝트 프리팹
    public float spawnInterval = 0.4f; // 생성 간격(초)
    private float nextSpawnTime = 0.0f; // 다음 생성 시간

    void Update()
    {
        // 현재 시간이 다음 생성 시간보다 크거나 같으면 오브젝트를 생성합니다.
        if (Time.time >= nextSpawnTime)
        {
            SpawnObject();
            nextSpawnTime = Time.time + spawnInterval; // 다음 생성 시간 설정
        }
    }

    void SpawnObject()
    {
        // objectToSpawn 프리팹을 인스턴스화하여 원하는 위치에 생성합니다.
        Instantiate(objectToSpawn, transform.position + transform.forward, transform.rotation);
    }
}
