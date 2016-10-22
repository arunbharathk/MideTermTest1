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
  
    // Use this for initialization
    void Start () {
               this._GenerateEnemies ();
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

   

    // PUBLIC METHODS ++++++++++++++++++++++++++++++
    public void RestartButton_Click()
    {
        SceneManager.LoadScene("Main");
    }

   
}
