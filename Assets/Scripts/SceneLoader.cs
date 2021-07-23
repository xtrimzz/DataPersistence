using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    [SerializeField] Text playerNameTxt;
    // Start is called before the first frame update
    public void LoadMainScene(){
        // First update PlayerStats
        PlayerStats.Instance.playerName = playerNameTxt.text;
        // Load scene
        SceneManager.LoadScene(1);
    }
}
