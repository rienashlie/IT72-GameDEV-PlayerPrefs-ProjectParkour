using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinishUnlocked : MonoBehaviour
{
    public int levelToUnlock;
    public GameObject SucessCanvas;
    public AudioSource AudioSource;
    int numberOfUnlockedLevels;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            
            numberOfUnlockedLevels = PlayerPrefs.GetInt("levelsUnlocked");
            SucessCanvas.SetActive(true);
            DeltaTimePaused();
            AudioSource.Play();
            

            if(numberOfUnlockedLevels <= levelToUnlock) {

                PlayerPrefs.SetInt("levelsUnlocked", numberOfUnlockedLevels + 1);
            }
        }
    }
    public void DeltaTimePaused()
    {
        Time.timeScale = 0f;
    }
}
