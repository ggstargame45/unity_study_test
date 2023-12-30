using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject objectToSpawn; // ������ ������Ʈ ������
    public float spawnInterval = 0.4f; // ���� ����(��)
    private float nextSpawnTime = 0.0f; // ���� ���� �ð�

    void Update()
    {
        // ���� �ð��� ���� ���� �ð����� ũ�ų� ������ ������Ʈ�� �����մϴ�.
        if (Time.time >= nextSpawnTime)
        {
            SpawnObject();
            nextSpawnTime = Time.time + spawnInterval; // ���� ���� �ð� ����
        }
    }

    void SpawnObject()
    {
        // objectToSpawn �������� �ν��Ͻ�ȭ�Ͽ� ���ϴ� ��ġ�� �����մϴ�.
        Instantiate(objectToSpawn, transform.position + transform.forward, transform.rotation);
    }
}
