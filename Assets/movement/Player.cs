using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float A = 0;
    public float B = 1;

    [Range(0,1)]
    public float T = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private Vector3 move = new Vector3(0, 0, 0);

    // Update is called once per frame
    void Update()
    {
        //float lerp = Mathf.Lerp(A, B, T);
        //Vector3 forward = this.transform.forward;
        //Vector3 move = forward * 0.1f;
        float speed = 0;
        float angle = 0;
        if (Input.GetKey(KeyCode.DownArrow)){ speed = -0.1f;}
        if (Input.GetKey(KeyCode.UpArrow)){ speed = 0.1f;}
        if (Input.GetKey(KeyCode.RightArrow)) { angle -= 1f; }
        if (Input.GetKey(KeyCode.LeftArrow)) { angle += 1f; }

        // this.transform.forward = forward;
        Vector3 move = this.transform.forward * speed;
        this.transform.Rotate(Vector3.up, angle);
        // this.transform.position += move; // this.transform.position = move;
        this.transform.Translate(move);
        //Debug.Log(T);
    }
}
