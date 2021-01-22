using UnityEngine;
using UnityEngine.SceneManagement;

public class Playbutton : MonoBehaviour
{
    public void Start()
    {
        SceneManager.LoadScene("game");
    }
    public void mute()
    {
        AudioListener.pause = true;
    }
    public void unmute()
    {
        AudioListener.pause = false;
           
    }



}
