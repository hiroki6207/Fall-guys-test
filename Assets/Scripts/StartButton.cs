using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Threading.Tasks;

[RequireComponent(typeof(Button))]
public class StartButton : MonoBehaviour
{
    [SerializeField]private AudioSource buttonSound;
    // Start is called before the first frame update
    private void Start()
    {
        var button = GetComponent<Button>();
        //ボタンを押下した時のリスナーを設定
        button.onClick.AddListener(async () =>
        {
            buttonSound.pitch = Random.Range(0.7f, 1.3f);
            buttonSound.Play();
            GameObject.Find("FadeInOutPanel").GetComponent<FadeInOut>().Fadeout();
            await Task.Delay(3000);
            //シーン遷移の際にはSceneManagerを使用する
            SceneManager.LoadScene("MainScene");
        });
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
