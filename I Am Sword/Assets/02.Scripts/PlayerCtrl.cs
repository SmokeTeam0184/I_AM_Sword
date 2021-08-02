using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public float speed = 10; // ĳ���� �ӵ�

    public int health = 30; //�⺻ ü��
    public int shield = 20; //�⺻ ����

    public int[] MaxHealth = { 30, 40, 50 }; //�ִ�ü��
    public int[] MaxShield = { 20, 30, 40 }; //�ִ뽯��

    float hAxis; //�¿� 
    float vAxis; //���� ����

    Animator anim;

    Rigidbody playerRb;

    Vector3 moveVec;

    void Awake()
    {
        playerRb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        GetInput();
        Move();
        Turn();
    }

    void GetInput()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");
    }

    void Move()
    {
        transform.position += moveVec = new Vector3(hAxis, 0, vAxis).normalized * speed * Time.deltaTime;

        anim.SetBool("isMove", moveVec != Vector3.zero);
    }


    void Turn()
    {
        transform.LookAt(transform.position + moveVec);

    }

}
