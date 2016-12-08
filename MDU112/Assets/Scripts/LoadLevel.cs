using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public void LevelLoader(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
