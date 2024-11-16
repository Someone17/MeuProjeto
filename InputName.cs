using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputName : MonoBehaviour
{
    public bool isPlayer;
    public TMP_InputField inputField;

    private void Start(){
        inputField.onValueChanged.AddListener(UpdateName);
    }

    public void UpdateName(string Name){

        if(isPlayer)
            SaveController.Instance.namePlayer1 = Name;
        else
            SaveController.Instance.namePlayer2 = Name;
    }

}
