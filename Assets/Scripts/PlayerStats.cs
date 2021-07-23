using UnityEngine;
using System.IO;

public class PlayerStats : MonoBehaviour
{
 
   private void Awake() {
       if(Instance == null){
           Instance = this;
           DontDestroyOnLoad(gameObject);
       }else{
           Destroy(gameObject);
       }
   }

   public static PlayerStats Instance;
   public string playerName;
   public int playerHighScore;

    [System.Serializable]
    class PlayerData{
        public string playerName;
        public int highScore;
    }

      public void SavePlayerStats()
  {
      PlayerData data = new PlayerData();
      data.playerName = playerName;
      data.highScore = playerHighScore;

      string json = JsonUtility.ToJson(data);
    
      File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
      Debug.Log("DATA SAVE - Complete");
  }
  

  public void LoadPlayerStats()
  {
      string path = Application.persistentDataPath + "/savefile.json";
      if (File.Exists(path))
      {
          string json = File.ReadAllText(path);
          PlayerData data = JsonUtility.FromJson<PlayerData>(json);

          playerName = data.playerName;
          playerHighScore = data.highScore;

          Debug.Log("DATA LOAD - Complete");
      }
  }


}
