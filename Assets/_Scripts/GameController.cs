using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
/*
 * Author  : Arun Bharath Krishnan
 * Stud_Id : 300902831
 * Last Modified Date : 22-Oct-2015
 * Script : TO define the Game controller and activities
 */
public class GameController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public int enemyCount;
	public GameObject enemy;
    private int _livesValue;
    private int _scoreValue;
    private AudioSource _endGameSound;

    [Header("UI Objects")]
    public Text LivesLabel;
    public Text ScoreLabel;
    public Text GameOverLabel;
    public Text FinalScoreLabel;
    public Button RestartButton;


  /*  public int LivesValue
    {
        get
        {
            return this._livesValue;
        }

        set
        {
            this._livesValue = value;
            if (this._livesValue <= 0)
            {
                this._endGame();
            }
            else
            {
               // Debug.("skip");
                this.LivesLabel.text = "Lives: " + this._livesValue;
            }
        }
    }
    */
   /* public int ScoreValue
    {
        get
        {
            return this._scoreValue;
        }

        set
        {
            this._scoreValue = value;
            this.ScoreLabel.text = "Score: " + this._scoreValue;
        }
    }
*/


    // Use this for initialization
    void Start () {
        //this.LivesValue = 5;
      //  this.ScoreValue = 0;

        //this.GameOverLabel.gameObject.SetActive(false);
        //this.FinalScoreLabel.gameObject.SetActive(false);
       // this.RestartButton.gameObject.SetActive(false);

       // this._endGameSound = this.GetComponent<AudioSource>();
       // this._GenerateEnemies ();
	}
	
	// Update is called once per frame
	void Update () {
       
        

    }

	// Method is used to generate enemies
	private void _GenerateEnemies() {

		for (int count=0; count < this.enemyCount; count++) {
			Instantiate(enemy);
		}
	}

   /* private void _endGame()
    {
        this.GameOverLabel.gameObject.SetActive(true);
        this.FinalScoreLabel.text = "Final Score: " + this.ScoreValue;
        this.FinalScoreLabel.gameObject.SetActive(true);
        this.RestartButton.gameObject.SetActive(true);
        this.ScoreLabel.gameObject.SetActive(false);
        this.LivesLabel.gameObject.SetActive(false);
        this._endGameSound.Play();
    }*/

    // PUBLIC METHODS ++++++++++++++++++++++++++++++
    public void RestartButton_Click()
    {
        SceneManager.LoadScene("Main");
    }
}
