using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
 public void RestartGame()
    {
        // Загрузить текущую сцену снова
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
