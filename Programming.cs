using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float speed=1.0f;
    //publicでunityEditor上でも使える変数を宣言できる．floatは処理速度が速い．

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        //左矢印キーを入力された時のIf処理
        {
            if(this.transform.position.x > -4)
            {this.transform.position += Vector3.left * speed * Time.deltaTime;}
            //this(player)の位置がx>-4であれば，左にspeed(先程宣言したもの)をかけて単位時間フレーム(何も書かないと処理速度フレームになり性能性が出てしまう)をかけて位置情報の数値に足してやる．
        }
        //何も書かれていないので，If外は何もしない．
        if(Input.GetKey(KeyCode.RightArrow))
        {
             if(this.transform.position.x < 4)
             {this.transform.position += Vector3.right *speed *Time.deltaTime;}
        }
        //何も書かれていないので，If外は何もしない．
    }
}
