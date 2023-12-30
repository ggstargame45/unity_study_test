using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // ������Ʈ �̵� �ӵ�
    public float lifespan = 5.0f; // ������Ʈ ���� (��)

    private float startTime;


    void Start()
    {
        startTime = Time.time; // ������Ʈ ���� �ð� ����
    }

    void Update()
    {
        // ���� �ð����� ������Ʈ�� ������ �̵�
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // ���� �ð� ���Ŀ� ������Ʈ�� ����
        if (Time.time - startTime >= lifespan)
        {
            Destroy(gameObject);
        }
    }

    async void OnTriggerStay(Collider other)
    {
        // Ư�� ������Ʈ�� ������ ���� ������Ʈ�� �Բ� ����
        if (other.gameObject.tag == "Enemy")
        {
            GameObject.Find("SoundMaker").GetComponent<AudioSource>().Play();
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }

}
