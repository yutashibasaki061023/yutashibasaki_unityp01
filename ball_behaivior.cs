using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_behaivior : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody myrigid;
    // Start is called before the first frame update
    void Start()
    {
         myrigid = this.GetComponent<Rigidbody>();
         //myrigidに規定値のコンポーネントの内，Rigidbodyを取得して代入．
         myrigid.AddForce((transform.forward + transform.right)*speed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
