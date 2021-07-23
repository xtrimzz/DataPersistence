using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
}
