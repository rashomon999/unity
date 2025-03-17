using UnityEngine;
using TMPro; // Importar el namespace de TextMeshPro
using UnityEngine.SceneManagement;

public class Derivadas_Cuatro : MonoBehaviour
{
    public TMP_InputField input1, input2, input3, input4, input5, input6, input7, input8, input9; // Referencias a los inputs de TextMeshPro
    public TMP_Text resultadoText; // Texto de TextMeshPro para mostrar el resultado

    public string respuestaCorrecta1 = "Respuesta1"; // Respuestas correctas
    public string respuestaCorrecta2 = "Respuesta2";
    public string respuestaCorrecta3 = "Respuesta3";
    public string respuestaCorrecta4 = "Respuesta4";

    public string respuestaCorrecta5 = "Respuesta5";
 
    public string respuestaCorrecta6 = "Respuesta6";

    public string respuestaCorrecta7 = "Respuesta7";
    public string respuestaCorrecta8 = "Respuesta8";
    public string respuestaCorrecta9 = "Respuesta9";
     public void Verificar()
    {
        // Compara las respuestas de los inputs con las respuestas correctas
        bool esCorrecto = true;

        if (input1.text != respuestaCorrecta1) esCorrecto = false;
        if (input2.text != respuestaCorrecta2) esCorrecto = false;
        if (input3.text != respuestaCorrecta3) esCorrecto = false;
        if (input4.text != respuestaCorrecta4) esCorrecto = false;
        if (input5.text != respuestaCorrecta5) esCorrecto = false;
        if (input6.text != respuestaCorrecta6) esCorrecto = false;
        if (input7.text != respuestaCorrecta7) esCorrecto = false;
        if (input8.text != respuestaCorrecta8) esCorrecto = false;
        if (input9.text != respuestaCorrecta9) esCorrecto = false;
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
