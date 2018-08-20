using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    public float spinForce = 45;
    public int score;
    // Use this for initialization
    void Start()
    {
        spinForce = Random.Range(30, 45);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, spinForce * Time.deltaTime, 0);
    }

    public void destroy()
    {
        Destroy(gameObject);
        RandomeGenerator.countObj--;
        Player.score+= score;
    }
}
