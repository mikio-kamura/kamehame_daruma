using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horming : MonoBehaviour
{
    public GameObject Player;
    public GameObject hominghuman;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Sphere");
        //homingparent = GameObject.Find("horming_human");
        //hominghuman = homingparent.transform.Find("Cube").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        hominghuman.transform.position = Vector3.MoveTowards(hominghuman.transform.position, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), speed * Time.deltaTime * 100000);

        Debug.Log(speed * Time.deltaTime );

       // hominghuman.transform.localScale = new Vector3(0, 50, 0);
    }
}
