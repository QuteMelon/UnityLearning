using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace ButtonScript
{
    /// <summary>
    /// SceneCheckout: 切换场景
    /// </summary>
    public class SceneCheckout : MonoBehaviour
    {
        public void Click(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }

        public void Click(int sceneIndex)
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}