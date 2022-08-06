using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    // �L���[�u�̈ړ����x
    private float speed = -12;

    // ���ňʒu
    private float deadLine = -10;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // �L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // ��ʊO�ɏo����j������
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }
    

    // �Ԃ��������ɉ���炷�i���n���j
    void OnCollisionEnter2D(Collision2D other)
    {         
         if (other.gameObject.tag == "UnityChanTag")
         {
                //Unity����񂪐ڐG���Ă������ɂ��������炱���͖��L�ڂɂ���
         } else
         {
                GetComponent<AudioSource>().Play();        //�I�[�f�B�I�N���b�v�̉����o�͂���R�[�h
         }
    }
}
