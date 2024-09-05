using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    [SerializeField]
    Pipe[] pipes;
    // Start is called before the first frame update
    
    void Start()
    {
        for (int i = 0; i < pipes.Length; i++)
        {
            pipes[i].enabled = false;
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnablePipes()
    {
        for (int i = 0; i < pipes.Length; i++)
        {
            pipes[i].enabled = true;
        }
    }
}
