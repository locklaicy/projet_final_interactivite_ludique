using UnityEngine;
using UnityEngine.SceneManagement;

public class demarrer : MonoBehaviour
{
    public string niveau1 = "Niveau 1";

    public void Demarrer()
    {
        SceneManager.LoadScene(niveau1);
    }
}
