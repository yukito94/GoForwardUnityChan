using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }
    

    // ぶつかった時に音を鳴らす（着地音）
    void OnCollisionEnter2D(Collision2D other)
    {         
         if (other.gameObject.tag == "UnityChanTag")
         {
                //Unityちゃんが接触しても無音にしたいからここは未記載にする
         } else
         {
                GetComponent<AudioSource>().Play();        //オーディオクリップの音を出力するコード
         }
    }
}
