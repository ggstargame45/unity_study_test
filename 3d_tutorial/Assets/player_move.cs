using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float _moveSpeed2 = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");//a,ȭ��ǥ �� = -1, d,ȭ��ǥ ������ = 1 
        float verticalInput = Input.GetAxis("Vertical");//w,ȭ��ǥ �� = 1, s,ȭ��ǥ �Ʒ� = -1 

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime;
        //Vector3(1/-1 * 5.0 * 0.0332,0,1/-1 * 5.0 * 0.0332)
        transform.Translate(movement);

    }
}
