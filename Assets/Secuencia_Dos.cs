using UnityEngine;
using TMPro; // Importar el namespace de TextMeshPro
using UnityEngine.SceneManagement;

public class Secuencia_Dos : MonoBehaviour
{
    public TMP_InputField input1,input2, input3; // Referencias a los inputs de TextMeshPro
    public TMP_Text resultadoText; // Texto de TextMeshPro para mostrar el resultado

    public string respuestaCorrecta1 = "Respuesta1"; // Respuestas correctas 
    public string respuestaCorrecta2 = "Respuesta1"; // Respuestas correctas 
    public string respuestaCorrecta3 = "Respuesta1"; // Respuestas correctas 


    public void Verificar()
    {
        // Compara las respuestas de los inputs con las respuestas correctas
        bool esCorrecto = true;

        if (input1.text != respuestaCorrecta1) esCorrecto = false;
        if (input2.text != respuestaCorrecta2) esCorrecto = false;
        if (input3.text != respuestaCorrecta3) esCorrecto = false;
     
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
 