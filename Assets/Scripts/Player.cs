using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
   
    public float jumpForce = 5f; // Adjustable force for the leap
    private Rigidbody rb;
    public int counter = 0;

    [SerializeField]
    PipeManager pipeManager;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        // Getting the Rigidbody component attached to the game object
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    void Update()
    {
        // Check for jump input (Space key)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.isKinematic = false;
            pipeManager.EnablePipes();
            // Apply an upward force to the rigidbody for jumping
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        GameManager gameManager = GameManager.Instance;
        gameManager.lives -= 1;
        Debug.Log(gameManager.lives + " lives reamining");
        gameManager.score += counter;
        int bestScore = PlayerPrefs.GetInt("bestScore", 0);

        if (gameManager.lives == 0)
        {
            if (bestScore < gameManager.score)
            {
                PlayerPrefs.SetInt("bestScore", gameManager.score);
            }
            Debug.Log("Game over. Your score is " + gameManager.score);
            SceneManager.LoadScene(1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("On trigger enter.");
        counter += 1;
    }


}
