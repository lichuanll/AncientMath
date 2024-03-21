using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoadAni : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject EventObj;
    [SerializeField] private Button button;
    [SerializeField] private Animator animator;
    [SerializeField] private int SceneIndex;
    void Start()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);
        GameObject.DontDestroyOnLoad(EventObj);
        button.onClick.AddListener(LoadNextScene);
    }

    public void LoadNextScene()
    {
        StartCoroutine(LoadScene(SceneIndex));
        StartCoroutine(DestroyObj());
    }

    IEnumerator LoadScene(int index)
    {
        animator.SetBool("FadeIn",true);
        animator.SetBool("FadeOut", false);
        yield return new WaitForSeconds(2);
       AsyncOperation async = SceneManager.LoadSceneAsync(index);
       async.completed += OnLoadedScene;
    }

    void OnLoadedScene(AsyncOperation obj)
    {
        animator.SetBool("FadeIn", false);
        animator.SetBool("FadeOut", true);
    }

    IEnumerator DestroyObj()
    {
        yield return new WaitForSeconds(3);
        Destroy(this.gameObject);
        Destroy(EventObj);
    }
    // Update is called once per frame
    
}
