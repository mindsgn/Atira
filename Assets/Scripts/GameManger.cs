using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    public enum GameState
    {
        Opening, CountDown, StartGame, PauseGame, PlayGame, GameOver, PlayAdvert
    }

    GameState State;

    //public SpawnWorld SpawnWorld;
    public GameObject Player;
    public GameObject StartUI;
    public GameObject GamePlayUI;
    public GameObject GameOverUI;
    public GameObject CountDownUI;
    public GameObject[] Items;

    public float Timer = 2;
    private bool PlayerReady;

    //player coins/points/score
    private float PlayerCoins;
    public Text CoinsText;
    public Text CountDownText;

    // Start is called before the first frame update
    void Start()
    {
        State = GameState.StartGame;
        UpdateGame(State);
    }

    public void OpenGame()
    {
        State = GameState.CountDown;
        UpdateGame(State);
    }

    //Pause the Game
    public void PauseGame()
    {
    }

    public void UpdateScore(float score)
    {
        PlayerCoins = PlayerCoins + score;
        CoinsText.text = PlayerCoins.ToString();

    }

    //Update game state
    public void UpdateGame(GameState State)
    {
        switch (State)
        {
            case GameState.Opening:
                StartUI.SetActive(true);
                GameOverUI.SetActive(false);
                GamePlayUI.SetActive(false);
                CountDownUI.SetActive(false);
                break;
            case GameState.CountDown:
                StartUI.SetActive(false);
                GameOverUI.SetActive(false);
                GamePlayUI.SetActive(false);
                CountDownUI.SetActive(true);
                break;
            case GameState.PlayGame:
                break;
            case GameState.StartGame:
                //PlayerCoins = 0.0f;
                //CoinsText.text = PlayerCoins.ToString();
                PlayerReady = false;
                //SpawnWorld.SpawnItem();
                SpawnPlayer();
                StartUI.SetActive(false);
                GameOverUI.SetActive(false);
                GamePlayUI.SetActive(true);
                CountDownUI.SetActive(false);
                StartCoroutine(SpawnItems());
                break;
            case GameState.PauseGame:
                StartUI.SetActive(false);
                GameOverUI.SetActive(false);
                GamePlayUI.SetActive(false);
                CountDownUI.SetActive(false);
                break;
            case GameState.GameOver:
                
                GameOverUI.SetActive(true);
                break;
            case GameState.PlayAdvert:
                break;
        }
    }

    //spawn player
    public void SpawnPlayer()
    {
        Instantiate(Player, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        //PlayerReady = true;
        //StartCoroutine(SpawnItems());
    }

    //SpawnItems
    IEnumerator SpawnItems()
    {
        while (PlayerReady)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));
            Instantiate(Items[Random.Range(0, Items.Length)], new Vector3(Random.Range(-50, 50), 0, Player.transform.position.z+5000f), Quaternion.identity);
        }
    }

    //play video when player dies
    public void PlayVideoAdvert()
    {
    }

    //play video when player dies
    public void ShowAdvert()
    {

    }

    public void StartGame()
    {
        StartCountDown();
    }

    public void GameOver()
    {
        //State = GameState.GameOver;
        //UpdateGame(State);
        Debug.Log("Game Over");
    }

    //game count down to start game
    public void StartCountDown()
    {
        State = GameState.CountDown;
        UpdateGame(State);

        int x = 10;
        for (int y = 0; y < x; y++)
        {
            CountDownText.text = y.ToString();
            //wait for one second
        }

        State = GameState.StartGame;
        UpdateGame(State);
    }

    void Update()
    {
        void Update()
        {
            Timer -= Time.deltaTime;
            if (Timer <= 0f)
            {
                Instantiate(Items[Random.Range(0, Items.Length)], new Vector3(Random.Range(-50, 50), 0, Player.transform.position.z + 5000f), Quaternion.identity);
                Timer = 2f;
            }
        }
    }
}
