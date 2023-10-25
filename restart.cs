using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
 public void RestartGame()
    {
        // Загрузить текущую сцену снова
        SceneManager.LoadScene("SampleScene");
    }
}
