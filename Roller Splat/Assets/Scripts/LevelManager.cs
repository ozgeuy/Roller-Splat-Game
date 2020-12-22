using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    private GameObject currentLevel;
    private GameObject nextLevel;
    public int numberOfPlane;
    public Text LevelCounter;
    public int levelIndex = 0;
    public Transform[] levels;
    void Start()
    {
        instance = this;
        numberOfPlane = GameObject.FindGameObjectsWithTag("Plane").Length;
        BallController.instance.RandomColor(); //for the first ball

    }

    public void LevelControl()
    {
        numberOfPlane--;
        if (numberOfPlane == 0)
        {
            StartCoroutine(LoadLevel());

        }
    }
    public IEnumerator LoadLevel()
    {

        LevelCounter.text = "LEVEL " + (levelIndex + 1).ToString();
        StartCoroutine(LevelCompletePanel.instance.Move()); // Level Complete Panel
        LevelCompletePanel.instance.PlayConfetti(); //Play Confetti
        yield return new WaitForSeconds(4);
        LevelCompletePanel.instance.RestartLevelCompPanel(); // Restart position for the new level
        currentLevel = GameObject.FindGameObjectWithTag(levelIndex.ToString());
        nextLevel = GameObject.FindGameObjectWithTag((levelIndex + 1).ToString());
        Destroy(currentLevel);
        levelIndex++;
        Instantiate(levels[levelIndex], levels[levelIndex].transform.position, Quaternion.identity);
        numberOfPlane = GameObject.FindGameObjectsWithTag("Plane").Length;
        BallController.instance.RandomColor();
    }
}
