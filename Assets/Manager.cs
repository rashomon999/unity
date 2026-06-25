using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    // Métodos para navegar a cada escena del menú
    public void IrATeoremaParteUno()
    {
        SceneManager.LoadScene("TeoremaFundamental");
    }

    public void IrADerivadaUno()
    {
        SceneManager.LoadScene("Derivada_Uno");
    }

    public void IrASecuenciaUno()
    {
        SceneManager.LoadScene("Secuencia_Uno");
    }

    public void IrASeriesUno()
    {
        SceneManager.LoadScene("Series_Uno");
    }

    public void IrAIntegral()
    {
        SceneManager.LoadScene("integral");
    }

    public void Salir()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
