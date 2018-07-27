using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float Speed;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        // var x = Input.GetAxis("w") * Time.deltaTime * 150.0f;
        //var z = Input.GetAxis("d") * Time.deltaTime * 3.0f;
        //var y = Input.GetAxis("") * Time.deltaTime *

        // transform.Rotate(0, x, 0);
        // transform.Translate(0, 0, z);
        // transform.Translate(y, 0, 0); 
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-1.0f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.0f, 0f, -1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0.0f, 0f, 1f);
        }


        bool isLeftButtonDown = Input.GetMouseButtonDown(0);
        bool isRightButtonDown = Input.GetMouseButtonDown(1);
        bool isMiddleButtonDown = Input.GetMouseButtonDown(2);

        print(isLeftButtonDown);
    }
}
