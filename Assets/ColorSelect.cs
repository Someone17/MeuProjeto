using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSelect : MonoBehaviour
{
    public Button uiButton;
    public Image paddleReference;

    public bool isColorPlayer = false;
    // Start is called before the first frame update
    public void OnButtonClick()
    {
        paddleReference.color = uiButton.colors.normalColor;

        if(isColorPlayer){
            SaveController.Instance.colorPlayer1 = paddleReference.color;
        }
        else
        {
            SaveController.Instance.colorPlayer2 = paddleReference.color;
        }
    }

   
}
