using UnityEngine;
using UnityEngine.UI;

public class PuzzleManager : MonoBehaviour
{
    public Button[] optionButtons; // Asigna los botones en el Inspector
    public GameObject correctModel; // Asigna el modelo correcto en el Inspector
    public GameObject incorrectModel; // Asigna el modelo incorrecto en el Inspector

    private void Start()
    {
        // Asigna la función a cada botón
        foreach (Button button in optionButtons)
        {
            button.onClick.AddListener(() => OnOptionButtonClick(button));
        }
    }

    // Esta función será llamada cuando se haga clic en un botón
    private void OnOptionButtonClick(Button clickedButton)
    {
        // Verifica si el botón clickeado es el correcto
        if (clickedButton.name == "CorrectButton") // Asegúrate de que el nombre coincide con el botón correcto
        {
            // Muestra el modelo correcto y oculta el modelo incorrecto
            if (correctModel != null)
            {
                correctModel.SetActive(true);
            }
            if (incorrectModel != null)
            {
                incorrectModel.SetActive(false);
            }
        }
        else
        {
            // Muestra el modelo incorrecto y oculta el modelo correcto
            if (correctModel != null)
            {
                correctModel.SetActive(false);
            }
            if (incorrectModel != null)
            {
                incorrectModel.SetActive(true);
            }
        }
    }
}
