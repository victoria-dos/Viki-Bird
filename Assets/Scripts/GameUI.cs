using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField]
    Image[] lives;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < lives.Length; i++)
        {
            if (GameManager.Instance.lives > i)
            {
                lives[i].enabled = true;
            }
            else
            {
                lives[i].enabled= false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
