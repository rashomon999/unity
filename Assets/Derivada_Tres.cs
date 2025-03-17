using UnityEngine;
using TMPro; // Importar el namespace de TextMeshPro
using UnityEngine.SceneManagement;

public class Derivada_Tres : MonoBehaviour
{
    public TMP_InputField input1, input2, input3, input4, input5; // Referencias a los inputs de TextMeshPro
    public TMP_Text resultadoText; // Texto de TextMeshPro para mostrar el resultado

    public string respuestaCorrecta1 = "Respuesta1"; // Respuestas correctas
    public string respuestaCorrecta2 = "Respuesta2";
    public string respuestaCorrecta3 = "Respuesta3";
    public string respuestaCorrecta4 = "Respuesta4";

    public string respuestaCorrecta5 = "Respuesta5";
 

    public void Verificar()
    {
        // Compara las respuestas de los inputs con las respuestas correctas
        bool esCorrecto = true;

        if (input1.text != respuestaCorrecta1) esCorrecto = false;
        if (input2.text != respuestaCorrecta2) esCorrecto = false;
        if (input3.text != respuestaCorrecta3) esCorrecto = false;
        if (input4.text != respuestaCorrecta4) esCorrecto = false;
        if (input5.text != respuestaCorrecta5) esCorrecto = false;
         // Muestra un mensaje dependiendo si todas las respuestas son correctas
        if (esCorrecto)
        {
            resultadoText.text = "¡Todas las respuestas son correctas!";
            LoadNextScene();
        }
        else
        {
            resultadoText.text = "Algunas respuestas son incorrectas. Intenta de nuevo.";
        }
    }


    
    void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1); // Carga la siguiente escena por índice
    }
}
