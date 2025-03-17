using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    // Método para cambiar de escena
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Ejemplo de un método que utiliza el `if`
    public void UpdateBackgroundImageColor(UnityEngine.UI.Image backgroundImage, Color nuevoColor)
    {
        if (backgroundImage != null)
        {
            backgroundImage.color = nuevoColor;
        }
    }
}
