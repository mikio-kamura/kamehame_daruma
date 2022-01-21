using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigger_ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 past_position = transform.position;
        Vector3 now_size = gameObject.transform.localScale;

        //double velocity = GetComponent<Rigidbody>().x * GetComponent<Rigidbody>().x + GetComponent<Rigidbody>().y * GetComponent<Rigidbody>().y  

        if (GetComponent<Rigidbody>().velocity.magnitude > 0)
        {
            now_size.x += 0.0002f;
            now_size.y += 0.0002f;
            now_size.z += 0.0002f;

            gameObject.transform.localScale = now_size;
        }
            past_position.x = transform.position.x;
    }
}
