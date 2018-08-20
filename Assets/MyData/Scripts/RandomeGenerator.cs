using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomeGenerator : MonoBehaviour {
    private const float MAX_RANGE = 3.0f;
    public static int countObj;
    public GameObject[] cubeList = new GameObject[3];
    private const int MAX_OBJ = 100;
    // Use this for initialization
    void Start()
    {
        countObj = 0;
        //cubeList = GameObject.FindGameObjectsWithTag("Cube");
    }
    // Update is called once per frame
    void Update()
    {
        if (countObj < MAX_OBJ)
        {
            generate();
            countObj++;
        }
    }

    void generate()
    {
        int index = Random.Range(0, cubeList.Length);
        Instantiate(cubeList[index], new Vector3(Random.Range(-MAX_RANGE, MAX_RANGE), Random.Range(-1.0f, MAX_RANGE), Random.Range(-MAX_RANGE, MAX_RANGE)), new Quaternion());
    }
}
