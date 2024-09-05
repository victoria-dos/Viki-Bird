using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField]
    private float offsetX = 0.1f;

    void Start()
    {
        float tmp = Random.Range(2f, 10f);
        transform.position = new Vector3(transform.position.x, tmp, 0);
    }


    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(offsetX, 0, 0) * Time.deltaTime;
        if (transform.position.x < -20)
        {
            float tmp = Random.Range(2f, 10f);
            transform.position = new Vector3(20f, tmp, 0);
        }
    }
}
