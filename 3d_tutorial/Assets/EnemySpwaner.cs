using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpwaner : MonoBehaviour
{
    public GameObject objectPrefab; // 생성할 오브젝트의 프리팹을 할당합니다.
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MyFunctionCoroutine());
    }

    IEnumerator MyFunctionCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(2.0f); // 2초 대기
            MyFunction(); // MyFunction 함수 실행
        }
    }

    void MyFunction()
    {
        Instantiate(objectPrefab, transform.position, transform.rotation);
    }
}
