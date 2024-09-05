using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    [SerializeField]
    TMPro.TMP_Text m_TextMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        GameManager gameManager = FindObjectOfType<GameManager>();
        m_TextMeshPro.text = "Game over. Your score is " + gameManager.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Debug.Log("Exit game.");
            Application.Quit();
        }
    }
}
