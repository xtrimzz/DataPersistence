using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
   
    [SerializeField] Text playerNameTxt;
    [SerializeField] Text placeholderTxt;
    // Start is called before the first frame update
     private void Start() {
        if(PlayerStats.Instance!=null)
        {
            PlayerStats.Instance.LoadPlayerStats();
            placeholderTxt.text = PlayerStats.Instance.playerName;
        }
    }
    public void LoadMainScene(){
        
        // First update PlayerStats if name changes
        if(playerNameTxt.text != "")
            PlayerStats.Instance.playerName = playerNameTxt.text;
        // Load scene
        SceneManager.LoadScene(1);
    }
}
