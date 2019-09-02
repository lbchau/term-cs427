using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerHandler : MonoBehaviour
{
    // Start is called before the first frame update
   public void changeScene(bool next){
	if(next){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}	
   }
}
