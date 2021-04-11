using UnityEngine;
using UnityEngine.SceneManagement;

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
