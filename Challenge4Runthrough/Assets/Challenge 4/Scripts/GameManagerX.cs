using UnityEngine; 
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerX : MonoBehaviour
{
    public static GameManagerX instance;

    [Header("UI Elements")]
    public Text waveText;
    public Text messageText;

    [Header("State")]
    public bool gameActive = false;
    public int currentWave = 1;

    private void Awake()
    {
        // Ensure singleton instance
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        // Show intro message until spacebar is pressed
        messageText.text = "To win, pass Wave 10.\nTo lose, all enemies in the current wave get through the player goal.\nPress SPACE to Start";
        waveText.text = "Wave: 1";

        // Pause game until player starts
        Time.timeScale = 0f;
    }

    private void Update()
    {
        // Start the game
        if (!gameActive && Input.GetKeyDown(KeyCode.Space))
        {
            gameActive = true;
            messageText.text = "";
            Time.timeScale = 1f; // resume game
        }

        // Restart game on lose/win
        if (!gameActive && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    // Call this to update the wave number
    public void UpdateWave(int wave)
    {
        currentWave = wave;
        waveText.text = "Wave: " + currentWave;

        // Win condition: pass wave 10
        if (currentWave > 10)
        {
            WinGame();
        }
    }

    // Call this if the player fails (enemy reaches Player Goal)
    public void LoseGame()
    {
        gameActive = false;
        messageText.text = "YOU LOSE! Press R to Restart!";
        Time.timeScale = 0f; // pause game
    }

    public void WinGame()
    {
        gameActive = false;
        messageText.text = "YOU WIN! Press R to Restart!";
        Time.timeScale = 0f; // pause game
    }
}