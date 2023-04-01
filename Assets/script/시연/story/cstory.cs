using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cstory : MonoBehaviour
{

    public Text c_text;
    public Text c_name;
    string wtext = "";

    public List<Sprite> cCottonCandy;
    public Image cCandy;

    public List<Sprite> cats;
    public Image cat;

    public List<Sprite> cBackGround;
    public Image cBack;

    public GameObject CatImage;

    public bool CatCan_Progress;

    public AudioClip[] Sound;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        StartCoroutine(C_s());
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator C_s()
    {
        if(s.instance.n == 0)
        {
            cBack.sprite = cBackGround[0];
            cCandy.sprite = cCottonCandy[1];
            cat.sprite = cats[5];
            yield return StartCoroutine(NormalChat("솜사탕", "여기가 체셔 고양이가 사는 보라색 숲..."));
            yield return StartCoroutine(NormalChat("솜사탕", "그럼 여기서 체셔 고양이를 찾으면 되겠지?"));
            yield return StartCoroutine(NormalChat("???", "어~~~이!"));
            cCandy.sprite = cCottonCandy[4];
            yield return StartCoroutine(NormalChat("솜사탕", "어? 어디서 목소리가.."));
            yield return StartCoroutine(NormalChat("???", "여기야 여기~! 나무 위쪽!"));
            yield return StartCoroutine(NormalChat("솜사탕", "나무 위?"));
            yield return StartCoroutine(NormalChat("솜사탕", "아!"));
            cat.sprite = cats[3];
            yield return StartCoroutine(NormalChat("체셔 고양이", "드디어 봤다!"));
            cat.sprite = cats[1];
            yield return StartCoroutine(NormalChat("체셔 고양이", "네가 솜사탕 맞지?\n쐐기 벌레한테 이미 연락 받았어!"));
            cCandy.sprite = cCottonCandy[1];
            yield return StartCoroutine(NormalChat("솜사탕", "소식이 엄청 빠르네.."));
            cat.sprite = cats[3];
            yield return StartCoroutine(NormalChat("체셔 고양이", "이상한 나라의 주민들은 새 소식에 민감 하거든~!"));
            cat.sprite = cats[1];
            yield return StartCoroutine(NormalChat("체셔 고양이", "아마 이미 이상한 나라의 주민 대부분이\n너의 소식을 알고 있을 거야~"));
            yield return StartCoroutine(NormalChat("솜사탕", "그럼 내가 왜 널 찾고 있었는지도 알겠네?"));
            cat.sprite = cats[3];
            yield return StartCoroutine(NormalChat("체셔 고양이", "물론 알고말고~! 하지만!"));
            cat.sprite = cats[1];
            yield return StartCoroutine(NormalChat("체셔 고양이", "지금은 내가 길을 알려줄 수 없어!\n좀 곤란한 일이 생겨서 말이야~"));
            cCandy.sprite = cCottonCandy[3];
            yield return StartCoroutine(NormalChat("솜사탕", "전혀 곤란해보이는 표정이 아닌데.."));
            cat.sprite = cats[2];
            yield return StartCoroutine(NormalChat("체셔 고양이", "아니 아니!! 무슨 소리~!\n지금 엄~청 곤란 하다고!"));
            cat.sprite = cats[1];
            yield return StartCoroutine(NormalChat("체셔 고양이", "그래서 네가 날 좀 도와줬으면 하는데~"));
            yield return StartCoroutine(NormalChat("솜사탕", "그냥 처음부터 도와달라고 하지..."));
            cat.sprite = cats[3];
            yield return StartCoroutine(NormalChat("체셔 고양이", "그럼 재미 없잖아! 멋도 없고!\n아무튼 날 도와주면 나도 널 도와줄게!"));
            cCandy.sprite = cCottonCandy[1];
            yield return StartCoroutine(NormalChat("솜사탕", "그래서 도와줄 일은?"));
            cat.sprite = cats[2];
            yield return StartCoroutine(NormalChat("체셔 고양이", "그게 말이지~"));
            cat.sprite = cats[5];
            cCandy.sprite = cCottonCandy[6];
            cBack.sprite = cBackGround[1];
            yield return StartCoroutine(NormalChat("체셔 고양이", "사실은 내가 전 쐐기벌레의 숲에 놀러 갔을 때..."));
            yield return StartCoroutine(NormalChat("체셔 고양이", "쐐기 벌레의 창고에서 무지 예쁜 보라색 사과를 발견 했거든~!"));
            yield return StartCoroutine(NormalChat("체셔 고양이", "그래서 기념으로 사과를 들고 사진을 찍었는데"));
            yield return StartCoroutine(NormalChat("체셔 고양이", "아까 실수로 손톱으로 사진을 조각내 버렸지 뭐야!"));
            cat.sprite = cats[2];
            cCandy.sprite = cCottonCandy[2];
            cBack.sprite = cBackGround[0];
            yield return StartCoroutine(NormalChat("체셔 고양이", "그래서 지금 무지 무지 곤란해~"));
            cCandy.sprite = cCottonCandy[3];
            yield return StartCoroutine(NormalChat("솜사탕", "... 그게 그렇게 곤란할 일이야?"));
            cat.sprite = cats[4];
            yield return StartCoroutine(NormalChat("체셔 고양이", "당연하지! 이몸의 인생샷 이였다고!"));
            yield return StartCoroutine(NormalChat("체셔 고양이", "그래서 도와줄거야?"));
            yield return StartCoroutine(NormalChat("솜사탕", "내가 어떻게 해줘야 하는데?"));
            cat.sprite = cats[3];
            yield return StartCoroutine(NormalChat("체셔 고양이", "간단해~! 사진 조각을 다시 맞춰 주면 돼!\n맘 같아서는 내가 하고 싶은데 난 이런거 정말 못 하거든"));
            cCandy.sprite = cCottonCandy[1];
            yield return StartCoroutine(NormalChat("솜사탕", "알았어... 사진 조각 줘봐"));
            yield return StartCoroutine(NormalChat("체셔 고양이", "정말 도와주는거야? 아싸~!\n그럼 부탁 좀 할게!"));

            SceneManager.LoadScene("si won");

        }
        else if(s.instance.n == 1)
        {
            cCandy.sprite = cCottonCandy[1];
            cat.sprite = cats[0];
            yield return StartCoroutine(NormalChat("솜사탕", "됐다... 원상복구 됐어"));
            cat.sprite = cats[3];
            yield return StartCoroutine(NormalChat("체셔 고양이", "벌써 다 했어~?\n대단하다~!!"));
            yield return StartCoroutine(NormalChat("체셔 고양이", "이걸로 이몸의 인생샷을 다시 전시 할 수 있겠어!"));
            cCandy.sprite = cCottonCandy[1];
            yield return StartCoroutine(NormalChat("솜사탕", "그래서 하트여왕의 성은 어느쪽이야?"));
            yield return StartCoroutine(NormalChat("체셔 고양이", "아~ 맞다 맞다\n그거 물어보려고 왔던거였지 참!"));
            cat.sprite = cats[1];
            yield return StartCoroutine(NormalChat("체셔 고양이", "내가 있는 나무를 등지고 쭉~ 가다보면\n어떤 두 녀석들이 나올거야 걔들한테 다시한번 물어봐!"));
            cat.sprite = cats[3];
            yield return StartCoroutine(NormalChat("체셔 고양이", "내 생각엔 그녀석들도 네 도움이 좀 필요할 거 같지만~"));
            cCandy.sprite = cCottonCandy[3];
            yield return StartCoroutine(NormalChat("솜사탕", "이상한 나라의 주민들은 뭐가 이렇게\n도움이 많이 필요 한거야..."));
            yield return StartCoroutine(NormalChat("체셔 고양이", "그냥 네가 운이 안 좋아서\n주민들이 도움이 필요할 때 이곳으로 왔을 뿐이야!"));
            yield return StartCoroutine(NormalChat("솜사탕", ".... 아무튼 고마워 난 가볼게"));
            yield return StartCoroutine(NormalChat("체셔 고양이", "잘가 솜사탕~!"));

            audio.clip = Sound[0];
            audio.Play();

            CatImage.SetActive(true);
            yield return StartCoroutine(NormalChat(" ", " "));
            while (!CatCan_Progress)
            {
                yield return null;
            }
            s.instance.n = 0;
            s.instance.i = 4;
            Invoke("scenemove", 1);
        }
    }

    IEnumerator NormalChat(string narrator, string narration)
    {
        int a = 0;
        c_name.text = narrator;
        wtext = "";

        //효과
        for (a = 0; a < narration.Length; a++)
        {
            wtext += narration[a];
            c_text.text = wtext;
            yield return new WaitForSeconds(0.05f);
        }

        while (!Input.GetMouseButtonDown(0))
        {
            yield return null;
        }
    }

    void scenemove() // Invoke 를 쓰기위해 만든 함수
    {
        SceneManager.LoadScene("main_proto_scene");
    }


}

