using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform target; // 플레이어 오브젝트의 Transform

    void Update()
    {
        if (target != null)
        {
            // 카메라를 플레이어 오브젝트 위치로 이동
            transform.position = target.position;

            // 카메라의 y 회전을 플레이어 오브젝트와 일치시킵니다.
            transform.rotation = Quaternion.Euler(0, target.eulerAngles.y, 0);
        }
    }
}
