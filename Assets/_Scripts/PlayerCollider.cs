using UnityEngine;
using System.Collections;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
public class PlayerCollider : MonoBehaviour {


    [Header("User Interface")]

    public Text scoreText;
    private int score = 0;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("touched Enemy");
            score += 100;
            scoreText.text = "Score: " + score;
            Debug.Log("Score: " + score);
        }
    }

}
