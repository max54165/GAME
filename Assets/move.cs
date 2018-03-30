using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour {

    Rigidbody rb;

    public Text countText;
    public Text winText;
    public Text myTime;

    public float speed;
        int count;
        DateTime curr;
	// Use this for initialization
	void Start () {
        
        rb=GetComponent<Rigidbody>();
        count = 0;
        countText.text = "分數:";
        winText.text = "";
        curr = DateTime.Now;
        myTime.text = "10";
    }
	
	// Update is called once per frame
	void Update () {

        float x = Input.GetAxis("Horizontal")*speed;
        float z = Input.GetAxis("Vertical")*speed;
        //transform.Translate(x, 0, z);

        rb.AddForce(new Vector3(x, 0, z));
        TimeSpan ts = DateTime.Now - curr;
        if (ts.Seconds < 10)
        {
            myTime.text = (10 - ts.Seconds).ToString() + ":" + (1000 - ts.Milliseconds).ToString();
        }
        else
        {
            myTime.text = "0";
            winText.text = "You lose!";
        }
	}
    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.CompareTag("Pick Up"))
        //{
            other.gameObject.SetActive(false);
            count++;
            countText.text = "分數:" + count.ToString();
            if(count>=3)
        {

            winText.text = "You Win!";
        }
        //}
    }
}
