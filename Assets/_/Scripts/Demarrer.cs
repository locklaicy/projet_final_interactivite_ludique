using UnityEngine;
using UnityEngine.SceneManagement;

public class Demarrer : MonoBehaviour
{
    public string niveau1 = "Niveau 1"; // Nom exact ☝️

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(niveau1);
    }
}