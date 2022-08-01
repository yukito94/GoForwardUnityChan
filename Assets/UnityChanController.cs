using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour
{
    //�A�j���[�V�������邽�߂̃R���|�[�l���g������
    Animator animator;

    //Unity�������ړ�������R���|�[�l���g������i�ǉ��j
    Rigidbody2D rigid2D;

    // �n�ʂ̈ʒu
    private float groundLevel = -3.0f;

    // �W�����v�̑��x�̌����i�ǉ��j
    private float dump = 0.8f;

    // �W�����v�̑��x�i�ǉ��j
    float jumpVelocity = 20;

    // Use this for initialization
    void Start()
    {
        // �A�j���[�^�̃R���|�[�l���g���擾����
        this.animator = GetComponent<Animator>();
        // Rigidbody2D�̃R���|�[�l���g���擾����i�ǉ��j
        this.rigid2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        // ����A�j���[�V�������Đ����邽�߂ɁAAnimator�̃p�����[�^�𒲐߂���
        this.animator.SetFloat("Horizontal", 1);

        // ���n���Ă��邩�ǂ����𒲂ׂ�
        bool isGround = (transform.position.y > this.groundLevel) ? false : true;
        this.animator.SetBool("isGround", isGround);

        // ���n��ԂŃN���b�N���ꂽ�ꍇ�i�ǉ��j
        if (Input.GetMouseButtonDown(0) && isGround)
        {
            // ������̗͂�������i�ǉ��j
            this.rigid2D.velocity = new Vector2(0, this.jumpVelocity);
        }

        // �N���b�N����߂��������ւ̑��x����������i�ǉ��j
        if (Input.GetMouseButton(0) == false)
        {
            if (this.rigid2D.velocity.y > 0)
            {
                this.rigid2D.velocity *= this.dump;
            }
        }
    }
}