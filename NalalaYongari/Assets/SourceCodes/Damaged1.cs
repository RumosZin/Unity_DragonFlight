using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damaged1: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collision) // 충돌하는 순간 작동
<<<<<<< HEAD:NalalaYongari/Assets/SourceCodes/Damaged1.cs
=======
    {
        if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "meteo")
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerExit(Collider collision) // 충돌이 끝난 순간 작동
    {

    }
    private void OnTriggerStay(Collider collision) // 충돌하는 순간 작동
    {

    }

    /*
    private void OnCollisionEnter(Collision collision)
>>>>>>> 253d4ef4 (媛쒖슂 : 異⑸룎 �뙋�젙 collider瑜� trigger�쓣 �궗�슜�븿):NalalaYongari/Assets/Damaged1.cs
    {
        if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "meteo")
        {
            Destroy(gameObject);
        }
    }
<<<<<<< HEAD:NalalaYongari/Assets/SourceCodes/Damaged1.cs
    private void OnTriggerExit(Collider collision) // 충돌이 끝난 순간 작동
    {

    }
    private void OnTriggerStay(Collider collision) // 충돌하는 순간 작동
    {

    }

    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
=======
>>>>>>> 253d4ef4 (媛쒖슂 : 異⑸룎 �뙋�젙 collider瑜� trigger�쓣 �궗�슜�븿):NalalaYongari/Assets/Damaged1.cs
    */
}
