using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("UI Elements")]
    public Text waveText;
    public Text messageText;

    [Header("State")]
    public bool gameActive = false;
    public int currentWave = 1;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        // Show intro message
        messageText.text = "To win, pass Wave 10.\nTo lose, fall off the platform.\nPress SPACE to Start";
        waveText.text = "Wave: 1";
    }

    private void Update()
    {
        // Start the game
        if (!gameActive && Input.GetKeyDown(KeyCode.Space))
        {
            gameActive = true;
            messageText.text = "";
        }

        // Restart game on lose/win
        if (!gameActive && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void UpdateWave(int wave)
    {
        currentWave = wave;
        waveText.text = "Wave: " + currentWave;

        // Win condition
        if (currentWave > 10)
        {
            WinGame();
        }
    }

    public void LoseGame()
    {
        gameActive = false;
        messageText.text = "YOU LOSE! Press R to Restart!";
    }

    public void WinGame()
    {
        gameActive = false;
        messageText.text = "YOU WIN! Press R to Restart!";
    }
}