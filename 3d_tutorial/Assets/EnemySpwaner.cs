using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpwaner : MonoBehaviour
{
    public GameObject objectPrefab; // ������ ������Ʈ�� �������� �Ҵ��մϴ�.
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MyFunctionCoroutine());
    }

    IEnumerator MyFunctionCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(2.0f); // 2�� ���
            MyFunction(); // MyFunction �Լ� ����
        }
    }

    void MyFunction()
    {
        Instantiate(objectPrefab, transform.position, transform.rotation);
    }
}
