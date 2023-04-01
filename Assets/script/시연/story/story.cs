using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class story : MonoBehaviour
{
    public Text ChatText;//ㅊㅌ
    public Text CharacterName;//ㅇㄹ
    string wtext = "";

    public List<Sprite> Chats;
    public Image csSprite;

    public List<Sprite> Bgd;
    public Image oBgd;

    public AudioClip[] Sound;
    AudioSource audio;

    public GameObject Image;

    public bool Can_Progress;

    // Start is called before the first frame update
    void Start()
    {
        audio =  GetComponent<AudioSource>();
        audio.loop = false;

        StartCoroutine(P_s());
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    IEnumerator P_s()
    {
        csSprite.sprite = Chats[1];
        yield return StartCoroutine(NormalChat("솜사탕", "..."));
        audio.clip = Sound[0];
        audio.Play();
        yield return StartCoroutine(NormalChat("솜사탕", "(팔락 팔락)"));
        csSprite.sprite = Chats[0];
        yield return StartCoroutine(NormalChat("솜사탕", "심심해..."));
        yield return StartCoroutine(NormalChat("솜사탕", "이 책도 이미 여러번 읽어서 질렸어..."));
        yield return StartCoroutine(NormalChat("솜사탕", "이상한 나라의 앨리스... 좋아하는 소설이지만..\n결국 현실에서 일어날리 없는 이야기 잖아?"));
        yield return StartCoroutine(NormalChat("솜사탕", "차라리 나도 이 책에 나오는 앨리스 처럼 \n이상한 나라로 가게 되면 좋겠어..."));
        csSprite.sprite = Chats[2];
        yield return StartCoroutine(NormalChat("솜사탕", "그럼 적어도 지금의 이 따분한 생활보다는 즐겁겠지..."));
        csSprite.sprite = Chats[0];
        yield return StartCoroutine(NormalChat("솜사탕", "어?"));
        oBgd.sprite = Bgd[1];
        csSprite.sprite = Chats[5];
        //yield return StartCoroutine(NormalChat(" ", " "));

        while (!Input.GetMouseButtonDown(0))
        {
            yield return null;
        }

        yield return StartCoroutine(NormalChat("솜사탕", "토끼..."));
        yield return StartCoroutine(NormalChat("솜사탕", "시계를 들고 있잖아?"));
        yield return StartCoroutine(NormalChat("솜사탕", "주인이 있는 토끼인 걸까.."));
        yield return StartCoroutine(NormalChat("토끼", "(타다닥)"));
        audio.clip = Sound[1];
        audio.Play();
        yield return new WaitForSeconds(0.3f);
        audio.clip = Sound[1];
        audio.Play();
        yield return new WaitForSeconds(0.3f);
        audio.clip = Sound[1];
        audio.Play();
        yield return new WaitForSeconds(0.3f);
        csSprite.sprite = Chats[3];
        yield return StartCoroutine(NormalChat("솜사탕", "어..! 잠깐만 토끼야!"));
        oBgd.sprite = Bgd[0];
        csSprite.sprite = Chats[4];
        yield return StartCoroutine(NormalChat("솜사탕", "숲속으로 달려가 버렸어..."));
        csSprite.sprite = Chats[1];
        yield return StartCoroutine(NormalChat("솜사탕", "......"));
        csSprite.sprite = Chats[0];
        yield return StartCoroutine(NormalChat("솜사탕", "따라가 봐야 하나...?"));
        yield return StartCoroutine(NormalChat("솜사탕", "주인이 있는 토끼라면 주인을 찾아 줘야 하니까..."));
        yield return StartCoroutine(NormalChat("솜사탕", "응... 따라가 보자"));
        oBgd.sprite = Bgd[2];
        csSprite.sprite = Chats[4];
        yield return StartCoroutine(NormalChat("솜사탕", "분명 이쪽으로 갔는데...\n놓쳐 버린 걸까..."));
        yield return StartCoroutine(NormalChat("솜사탕", "어쩔 수 없네... 돌아가는 수 밖에..."));
        yield return StartCoroutine(NormalChat("솜사탕", "..."));
        csSprite.sprite = Chats[0];
        yield return StartCoroutine(NormalChat("솜사탕", "어라...?"));
        yield return StartCoroutine(NormalChat("솜사탕", "길이 보이지 않아..."));
        audio.clip = Sound[2];
        audio.Play();
        yield return StartCoroutine(NormalChat("", "(쨍그랑!)"));
        csSprite.sprite = Chats[3];
        yield return StartCoroutine(NormalChat("솜사탕", "방금 그 소린 뭐지?"));
        yield return StartCoroutine(NormalChat("솜사탕", "저쪽에서 난 거 같아 가보자..!"));
        
        audio.clip = Sound[3];
        audio.Play();
        
        Image.SetActive(true);
        yield return StartCoroutine(NormalChat(" ", " "));
        while (!Can_Progress)
        {
            yield return null;
        }
        s.instance.n = 0;
        s.instance.i = 1;
        Invoke("gotemain", 1);
    }


    IEnumerator NormalChat(string narrator, string narration)
    {
        int a = 0;
        CharacterName.text = narrator;
        wtext = "";

        //효과
        for (a = 0; a < narration.Length; a++)
        {
            wtext += narration[a];
            ChatText.text = wtext;
            yield return new WaitForSeconds(0.05f) ;
        }

        while (!Input.GetMouseButtonDown(0))
        {
            yield return null;
        }
    }

    void gotemain()
    {
        SceneManager.LoadScene("main_proto_scene");
    }

    

}
