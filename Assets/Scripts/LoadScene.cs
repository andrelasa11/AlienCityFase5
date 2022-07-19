using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void DoLoad(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
