using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
   private void Awake() {
       if(Instance == null){
           Instance = this;
           DontDestroyOnLoad(gameObject);
       }else{
           Destroy(gameObject);
       }
   }

   public static SceneManager Instance;

    

}
