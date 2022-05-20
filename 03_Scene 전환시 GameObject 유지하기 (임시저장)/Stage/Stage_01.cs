using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Stage_01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StageClear());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 스테이지 클리어
    public IEnumerator StageClear()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Stage_02");
    }
}
