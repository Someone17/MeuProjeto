using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveController : MonoBehaviour
{
    public Color colorPlayer1 = Color.white;
    public Color colorPlayer2 = Color.white;

    public static SaveController _instance;

    public string namePlayer1;
    public string namePlayer2;


     public static SaveController Instance
    {
        get
        {
            if(_instance == null){
                _instance = FindObjectOfType<SaveController>();

                if(_instance == null){
                    GameObject singletonObject = new GameObject(typeof(SaveController).Name);
                    _instance = singletonObject.AddComponent<SaveController>();
                }
            }
            return _instance;
        }
    }

    private void Awake(){
        if(_instance != null && _instance != this){
            Destroy(this.gameObject);
            return;
        }

        DontDestroyOnLoad(this.gameObject);
    }
    
    public string GetName(bool isPlayer){
        return isPlayer ? namePlayer1 : namePlayer2;
    }
    
    public void Reset(){
        namePlayer1 = "";
        namePlayer2 = "";
        colorPlayer1 = Color.white;
        colorPlayer2 = Color.white;
    }
    public void SaveWinner(string winner){
        PlayerPrefs.SetString("SaveWinner", winner);
    }

    public string GetLastWinner(){
        return PlayerPrefs.GetString("SaveWinner");
    }
    public void ClearSave(){
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
