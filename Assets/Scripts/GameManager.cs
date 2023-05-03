using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] players;
    Scene scene;
    public void Start()
    {
        scene = SceneManager.GetActiveScene();
        Debug.Log("Active Scene name is: " + scene.name + "\nActive Scene index: " + scene.buildIndex);
    }


    public void CheckWinState()
    {
        int AliveCount = 0;

        foreach (GameObject player in players)
        {
            if (player.activeSelf)
            {
                AliveCount++;
            }
        }

        //checks if anybody is alive before changing scenes
        if (AliveCount <= 1)
        {
            //Invoke(nameof(Bombermanlevel2), 2f);
            Bombermanlevel2("Bombermanlevel2");
        }
    }

    public void Bombermanlevel2(string scenename)

        //When a player dies it changes to the next level
    {
        //SceneManager.LoadScene(SceneManager.GetSceneByName("Bombermanlevel2").buildIndex);
        SceneManager.LoadScene(scenename);
    }
}