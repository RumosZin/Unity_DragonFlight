using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using TMPro;

public class weDragonMove : MonoBehaviour
{
    Vector3 clickPoint; //���콺�� Ŭ���� ��ġ
    float Speed = 0.5f; //�����̴� �ӵ�

    //private TextMeshProUGUI myCoin;
    public int get_coin = 0; //�� ���� ���� ���� ���� ��
    public int one_coin = 100; //���� 1���� 100��

    void Start()
    {
<<<<<<< HEAD:Nalala2/Assets/SourceCodes/weDragonMove.cs
        myCoin = GameObject.Find("coin").GetComponent<TextMeshProUGUI>();
        myCoin.text = "[Get Coin]: " + get_coin.ToString();
=======
        //myCoin = GameObject.Find("coin").GetComponent<TextMeshProUGUI>();
        //myCoin.text = "[Get Coin]: " + get_coin.ToString();
>>>>>>> 26656c70 (.gitattributes 넣고 재도전):NalalaYongari/Assets/SourceCodes/weDragonMove.cs
        gameObject.transform.position = new Vector3(0, 7, 8);
    }

    void OnMouseDown()
    {
        clickPoint = Input.mousePosition;
    }

    void OnMouseDrag()
    {
        Vector3 differ = Input.mousePosition - clickPoint; //ó���� Ŭ���� ��ġ�� �巡���� ��ġ�� ����
        Vector3 pos = transform.position; //�ش���ġ�� �̵�
        pos.x += differ.x * Time.deltaTime * Speed; //�̵��Ÿ� �����ϱ� (�Ÿ�=�ӷ�*�ð� ����...)
        transform.position = pos; //transform.position�� ��ġ�� �����ϸ� �ش� ��ġ�� �̵��Ѵ�.
        clickPoint = Input.mousePosition;
    }

    private void OnTriggerEnter(Collider col)
    {

        //if (col.gameObject.tag == "Coin")
        //{
        //    get_coin += one_coin;
        //    Debug.Log(get_coin);
        //}

        //if (col.gameObject.tag == "gem")
        //{
        //    get_coin += one_coin * 10;
        //    Debug.Log(get_coin);
        //}

    }

    //void SetCountText()
    //{
    //    myCoin.text = "[Get Coin]: " + get_coin.ToString();
    //}

    //void Update()
    //{
    //    SetCountText();
    //}
}