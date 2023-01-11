using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    [SerializeField] float loadTime = 2f;
    bool isTriggerd = false;

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="Player" && !isTriggerd)
        {
            StartCoroutine(LoadLevel());
            isTriggerd = true;
        }
    }

    IEnumerator LoadLevel()
    {
        yield return new WaitForSecondsRealtime(loadTime);
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        if(nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        FindObjectOfType<ScenePersist>().ResetScenePersist();
        SceneManager.LoadScene(nextSceneIndex);
    }
}
