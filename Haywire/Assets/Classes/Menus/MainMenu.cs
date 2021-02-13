using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Haywire.Systems
{
    public class MainMenu : MonoBehaviour
    {
        [Header("MainMenu Controller")]
        public string SceneToLoad;

        public void Begin()
        {
            SceneManager.LoadScene(SceneToLoad);
		}

        public void QuitApplication()
        {
            Application.Quit();
		}
        
    }
}
