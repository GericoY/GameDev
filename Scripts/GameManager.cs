using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    public GameObject coinPrefab;
    public GameObject enemyPrefab;
    public int numberOfCoins = 10; // Adjust this value to determine how many coins to spawn.
    public int numberOfMobs = 5; // Adjust this value to determine how many coins to spawn.

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();

        for (int i = 0; i < numberOfCoins; i++)
        {
        Vector3 spawnPosition = new Vector3(Random.Range(-2f, 40f), Random.Range(0.1f, 3.5f), 0f);
        //Vector3 spawnPosition = new Vector3(Random.Range(-5f, 5f), Random.Range(0.1f, 0.5f), 0f);
        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
        }

        for (int i = 0; i < numberOfMobs; i++)
        {
        Vector3 spawnPosition = new Vector3(Random.Range(5.23f, 40f), Random.Range(-3.59f, -3.59f), 0f);
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        }
    }

    // Scoring , Score Text
    public void AddScore(int amount){  // Kung ilang points kapag na destroy mo yung isang coin

        Scene scene = SceneManager.GetActiveScene();

        score += amount;
        UpdateScoreText();

        if (score == (numberOfCoins * 5))
        {
            if (scene.name == "Level 1")
            {
                SceneManager.LoadScene("Level 2");
            }
            
            else if (scene.name == "Level 2")
            {
                Debug.Log("Active Scene is '" + scene.name + "'.");
                SceneManager.LoadScene("Level 3");
            }
        }
    }

    void UpdateScoreText(){
        scoreText.text = "Score: " + score;

    }

}
