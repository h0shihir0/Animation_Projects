using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StratStops : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator new_chara;
    public Animator message_txt;
    public AudioSource main_cam;
    public Animator  nc;
    public Animator end;
    public Animator m_cam;
    public Animator smartphone;

    void Start()
    {
        //print("jjjijjjjijijij");
        message_txt.enabled = false;
        new_chara.enabled = false;
        main_cam.enabled = false;
        nc.enabled = false;
        end.enabled = false;
        m_cam.enabled = false;
        smartphone.enabled = false;
      Invoke("ReStart", 2f);
    }

    void ReStart(){
        //print("kokokko");
        new_chara.enabled = true;
        message_txt.enabled = true;
        main_cam.enabled = true;
        nc.enabled = true;
        end.enabled = true;
        m_cam.enabled = true;
        smartphone.enabled = true;

    }

    public void newcharaIsOn(){
       // newchara_line.SetActive(true);
    }

    public void NextScene() {
        SceneManager.LoadScene("SwipingTinder");
    }


    // Update is called once per frame
    void Update()
    {
        //newchara_line.SetActive(true);
    }
}
