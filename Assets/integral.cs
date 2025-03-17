using UnityEngine;
using TMPro; // Importar el namespace de TextMeshPro
using UnityEngine.SceneManagement;

public class integral : MonoBehaviour
{
    public TMP_InputField input1; // Referencias a los inputs de TextMeshPro
    public TMP_Text resultadoText; // Texto de TextMeshPro para mostrar el resultado

    public string respuestaCorrecta1 = "Respuesta1"; // Respuestas correctas
  
 
 
 
    public void Verificar()
    {
        // Compara las respuestas de los inputs con las respuestas correctas
        bool esCorrecto = true;

        if (input1.text != respuestaCorrecta1) esCorrecto = false;
  
   
       
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
