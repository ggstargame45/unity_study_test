using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform target; // �÷��̾� ������Ʈ�� Transform

    void Update()
    {
        if (target != null)
        {
            // ī�޶� �÷��̾� ������Ʈ ��ġ�� �̵�
            transform.position = target.position;

            // ī�޶��� y ȸ���� �÷��̾� ������Ʈ�� ��ġ��ŵ�ϴ�.
            transform.rotation = Quaternion.Euler(0, target.eulerAngles.y, 0);
        }
    }
}
