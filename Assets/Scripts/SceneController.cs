using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Singleton instance for global access
    public static SceneController Instance;

    private void Awake()
    {
        // Ensure that there's only one instance of NextLevel1
        if (Instance == null)
        {
            Instance = this;
            // Persist the SceneController across scenes
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Destroy duplicate instances
            Destroy(gameObject);
        }
    }

    // Load the next level based on the current scene index
    public void LoadNextLevel()
    {
        int nextLevelIndex = SceneManager.GetActiveScene().buildIndex + 1;
        // Ensure the next level exists before attempting to load
        if (nextLevelIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadSceneAsync(nextLevelIndex);
        }
        else
        {
            Debug.LogWarning("No more levels available to load!");
        }
    }

    // Load a specific scene by its name
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }

    // Example method to load a specific starting level
    public void LoadStartingLevel()
    {
        LoadScene("Level1"); // Replace "Level1" with your actual starting level name
    }

    internal void NextLevel1()
    {
        throw new NotImplementedException();
    }
}
