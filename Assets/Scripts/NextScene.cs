using UnityEngine;
using UnityEngine.SceneManagement;

public class NavBehaviour : MonoBehaviour
{
    // Function to load a specific scene
    public void LoadMyScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
