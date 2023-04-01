using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class hstory : MonoBehaviour

{
    public Text h_text;
    public Text h_name;
    string wtext = "";

    public List<Sprite> hCottonCandy;
    public Image hCandy;

    public List<Sprite> hats;
    public Image hat;

    public List<Sprite> MarchRabbits;
    public Image March;

    public List<Sprite> hBackGround;
    public Image hBack;


    public AudioClip[] Sound;
    AudioSource audio;

    public GameObject hImage;

    public bool hCan_Progress;
    public bool hat_bgm;

    public Www ww;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();

        StartCoroutine(H_s());
    }



    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator H_s()
    {
        if (s.instance.n == 0)
        {
            
            
            hat_bgm = false;
            ww.bgm();
            hBack.sprite = hBackGround[0];
            hCandy.sprite = hCottonCandy[1];
            hat.sprite = hats[6];
            March.sprite = MarchRabbits[8];
            yield return StartCoroutine(NormalChat("솜사탕", "우와... 여긴 티파티라도 열리는 장소인걸까?"));
            yield return StartCoroutine(NormalChat("???", "훌쩍"));
            hCandy.sprite = hCottonCandy[0];
            
            yield return StartCoroutine(NormalChat("솜사탕", "...?"));
            hCandy.sprite = hCottonCandy[1];
            yield return StartCoroutine(NormalChat("솜사탕", "우는 소리?"));
            March.sprite = MarchRabbits[0];
            yield return StartCoroutine(NormalChat("3월 토끼", "훌쩍..."));
            yield return StartCoroutine(NormalChat("솜사탕", "저 토끼가 울고 있던거구나..."));
            yield return StartCoroutine(NormalChat("솜사탕", "저기... 무슨 일이야?"));
            March.sprite = MarchRabbits[1];
            yield return StartCoroutine(NormalChat("3월 토끼", "아.. 당신은 솜사탕 맞죠..?\n갑자기 나타나 주민들을 도와주고 있다는..."));
            hCandy.sprite = hCottonCandy[2];
            yield return StartCoroutine(NormalChat("솜사탕", "어쩌다 소문이 그렇게 퍼진거지..\n아무튼 나 맞아"));
            March.sprite = MarchRabbits[3];
            yield return StartCoroutine(NormalChat("3월 토끼", "제발 저 좀 도와주세요...!"));
            hCandy.sprite = hCottonCandy[5];
            yield return StartCoroutine(NormalChat("솜사탕", "아..알았으니까 울지 말고 말해봐"));
            March.sprite = MarchRabbits[1];
            yield return StartCoroutine(NormalChat("3월 토끼", "그러니까... 몇달 전부터 모자장수라는 놈이\n저희 집을 찾아 왔는데요..."));
            yield return StartCoroutine(NormalChat("3월 토끼", "갈곳이 없다고 해서 하루 이틀 집에서 지내게 해주려 했을 뿐인데"));
            yield return StartCoroutine(NormalChat("3월 토끼", "아직까지도 저희집에 눌러 앉아서\n매일 저희집에 있는 재료들로 사치스러운 티파티를 하고 있어요"));
            March.sprite = MarchRabbits[3];
            yield return StartCoroutine(NormalChat("3월 토끼", "그래서 모자장수를..."));
            March.sprite = MarchRabbits[8];
            hat.sprite = hats[1];
            yield return StartCoroutine(NormalChat("모자장수", "3월 토끼! 여기서 뭐하는거야?"));
            March.sprite = MarchRabbits[2];
            hat.sprite = hats[6];
            yield return StartCoroutine(NormalChat("3월 토끼", "모..모자장수!"));
            March.sprite = MarchRabbits[8];
            hat.sprite = hats[5];
            yield return StartCoroutine(NormalChat("모자장수", "그리고 여기 계시는 꼬마 아가씨는?"));
            hCandy.sprite = hCottonCandy[2];
            yield return StartCoroutine(NormalChat("솜사탕", "..."));
            hat.sprite = hats[1];
            yield return StartCoroutine(NormalChat("모자장수", "흠~ 우리 꼬마 아가씨 께선 왜 날 저런 표정으로 보실까~?"));
            yield return StartCoroutine(NormalChat("모자장수", "아! 알았다"));
            hat.sprite = hats[5];
            yield return StartCoroutine(NormalChat("모자장수", "나의 오~랜 친구 3월 토끼가 이상한 말이라도 했나봐?"));
            hat.sprite = hats[6];
            March.sprite = MarchRabbits[0];
            yield return StartCoroutine(NormalChat("3월 토끼", "......"));
            hat.sprite = hats[1];
            March.sprite = MarchRabbits[8];
            yield return StartCoroutine(NormalChat("모자장수", "무슨 말이라도 해봐 3월 토끼~"));
            yield return StartCoroutine(NormalChat("솜사탕", "저기요"));
            hat.sprite = hats[5];
            yield return StartCoroutine(NormalChat("모자장수", "무슨 일이야 꼬마 아가씨?"));
            yield return StartCoroutine(NormalChat("솜사탕", "지금 여기에 티파티 하러 오신건가요?"));
            hat.sprite = hats[1];
            yield return StartCoroutine(NormalChat("모자장수", "응 그런데?"));
            hCandy.sprite = hCottonCandy[6];
            yield return StartCoroutine(NormalChat("솜사탕", "3월 토끼의 재료로 만든 케이크와 차로요?"));
            hat.sprite = hats[5];
            yield return StartCoroutine(NormalChat("모자장수", "아하하 그렇게 말하니까 내가 무슨\n3월 토끼의 허락도 안받고 이러는 사람인거 같잖아~"));
            yield return StartCoroutine(NormalChat("솜사탕", "....."));
            hat.sprite = hats[6];
            March.sprite = MarchRabbits[3];
            yield return StartCoroutine(NormalChat("3월 토끼", "......훌쩍"));
            hat.sprite = hats[6];
            March.sprite = MarchRabbits[8];
            yield return StartCoroutine(NormalChat("모자장수", "....."));
            hat.sprite = hats[4];
            yield return StartCoroutine(NormalChat("모자장수", "...그래서 뭐?\n불만이라도 있어?"));
            yield return StartCoroutine(NormalChat("솜사탕", "있고말고요"));
            yield return StartCoroutine(NormalChat("솜사탕", "당신은 3월 토끼에게 미안하지도 않아요?"));
            yield return StartCoroutine(NormalChat("모자장수", "거절하나 똑바로 못하고 네 네 대답만 하는데\n본인이 멍청한 잘못이지 내 잘못이 어디있겠어?"));
            yield return StartCoroutine(NormalChat("모자장수", "응? 3월 토끼 나한테 할 말 있어?"));
            hat.sprite = hats[6];
            March.sprite = MarchRabbits[3];
            yield return StartCoroutine(NormalChat("3월 토끼", "......."));
            hat.sprite = hats[4];
            March.sprite = MarchRabbits[8];
            yield return StartCoroutine(NormalChat("모자장수", "봐봐! 아무말도 안하잖아\n그럼 문제 없는거지?"));
            yield return StartCoroutine(NormalChat("솜사탕", "문제 있어요!"));
            yield return StartCoroutine(NormalChat("솜사탕", "당장 짐싸서 3월 토끼의 집에서 나와 주세요!"));
            yield return StartCoroutine(NormalChat("모자장수", "내가 왜?"));
            yield return StartCoroutine(NormalChat("솜사탕", "왜 겠어요!!"));
            hat.sprite = hats[5];
            yield return StartCoroutine(NormalChat("모자장수", "아이쿠~ 이거 참 목소리가 큰 아가씨네~"));
            yield return StartCoroutine(NormalChat("모자장수", "좋아 그럼 이렇게 하자!"));
            hat.sprite = hats[4];
            yield return StartCoroutine(NormalChat("모자장수", "나랑 게임하나 하자"));
            yield return StartCoroutine(NormalChat("솜사탕", "무슨 게임이요"));
            hat.sprite = hats[5];
            yield return StartCoroutine(NormalChat("모자장수", "간단한 미로 찾기!"));
            yield return StartCoroutine(NormalChat("모자장수", "내 모자는 생각보다 더 대단한 모자 거든"));
            hat.sprite = hats[1];
            yield return StartCoroutine(NormalChat("모자장수", "지금부터 네가 내 모자속에 들어가서\n내 모자 안 미로에 있는 장미 꽃을 가지고 나오면 돼"));
            yield return StartCoroutine(NormalChat("모자장수", "쉽지?\n아 물론.."));
            hat.sprite = hats[4];
            yield return StartCoroutine(NormalChat("모자장수", "장미를 못 찾으면 난 3월 토끼 집에서\n나가지 않을거고 너도 내 모자 안에서 못 나와"));
            yield return StartCoroutine(NormalChat("솜사탕", "할게요"));
            yield return StartCoroutine(NormalChat("모자장수", "정말? 용감한 아가씨네~"));
            yield return StartCoroutine(NormalChat("모자장수", "그럼..."));
            hBack.sprite = hBackGround[1];
            hCandy.sprite = hCottonCandy[7];
            hat.sprite = hats[6];
            March.sprite = MarchRabbits[8];
            yield return StartCoroutine(NormalChat("모자장수", "우리 용감한 꼬마 아가씨가 해낼 수 있을지 어디 보자고~"));

            s.instance.n = 1;

            SceneManager.LoadScene("moja_scene");//여기에 게임 들어감

        }
        else if (s.instance.n == 1)
        {
            hat_bgm = false;
            ww.bgm();
            hBack.sprite = hBackGround[0];
            hCandy.sprite = hCottonCandy[6];
            hat.sprite = hats[6];
            March.sprite = MarchRabbits[4];
            yield return StartCoroutine(NormalChat("솜사탕", "장미 찾아 왔어요"));
            yield return StartCoroutine(NormalChat("3월 토끼", "..!! 솜사탕!"));
            hat.sprite = hats[4];
            March.sprite = MarchRabbits[8];
            yield return StartCoroutine(NormalChat("모자장수", "그래~? 수고 했어\n그런데 이걸 어쩌나?"));
            yield return StartCoroutine(NormalChat("모자장수", "난 거짓말을 좋아해~ 물론 3월 토끼의 집에서\n나가 주겠다 한 것도 거짓말이고"));
            yield return StartCoroutine(NormalChat("모자장수", "그냥 한번 가지고 놀아 봤어~"));
            yield return StartCoroutine(NormalChat("솜사탕", "뭐라고요?"));
            yield return StartCoroutine(NormalChat("모자장수", "화내서 어쩌려고? 집주인도 가만히 있는데\n외부인인 네가 뭘 할 수 있는데?"));
            yield return StartCoroutine(NormalChat("모자장수", "그렇지 3월 토끼?"));
            hat.sprite = hats[6];
            March.sprite = MarchRabbits[6];
            yield return StartCoroutine(NormalChat("3월 토끼", "..."));
            hat.sprite = hats[1];
            March.sprite = MarchRabbits[8];
            yield return StartCoroutine(NormalChat("모자장수", "3월... 토끼...?"));
            hat.sprite = hats[6];
            March.sprite = MarchRabbits[6];
            audio.clip = Sound[0];
            audio.Play();
            yield return StartCoroutine(NormalChat("3월 토끼", "(쨍그랑!)"));
            hat.sprite = hats[2];
            March.sprite = MarchRabbits[8];
            yield return StartCoroutine(NormalChat("모자장수", "우왓 뭐야?!"));
            yield return StartCoroutine(NormalChat("모자장수", "너 방금 찻잔 던진거야? 그러다 맞으면 어쩌려고?"));
            hat.sprite = hats[6];
            March.sprite = MarchRabbits[7];
            yield return StartCoroutine(NormalChat("3월 토끼", "못 피한 네 잘못이지 내 잘못이 어딨겠어?"));
            hat.sprite = hats[2];
            March.sprite = MarchRabbits[8];
            yield return StartCoroutine(NormalChat("모자장수", "그게 무슨 말도 안되는 소리야?"));
            hat.sprite = hats[6];
            March.sprite = MarchRabbits[7];
            yield return StartCoroutine(NormalChat("3월 토끼", "네가 할 소리 아닌거 알잖아 모자장수"));
            yield return StartCoroutine(NormalChat("3월 토끼", "우리집에 눌러 앉아서 놀고 먹더니\n도와주러온 솜사탕을 가지고 놀아?"));
            yield return StartCoroutine(NormalChat("3월 토끼", "당장 우리집에서 나가"));
            hat.sprite = hats[3];
            March.sprite = MarchRabbits[8];
            yield return StartCoroutine(NormalChat("모자장수", "뭐... 잠깐잠깐 너 진짜 날 집에서\n내쫓으려는 거야?"));
            yield return StartCoroutine(NormalChat("모자장수", "우리 잘 지냈잖아? 너랑 나 만큼 친한 사이가 또\n어디 있다고 그래?"));
            hat.sprite = hats[6];
            March.sprite = MarchRabbits[7];
            yield return StartCoroutine(NormalChat("3월 토끼", "우리집에서 지내면서 피해만주고\n네 사치스런 티파티 때문에 가족들이 먹을게 없어"));
            yield return StartCoroutine(NormalChat("3월 토끼", "너 이상 피해주지 말고 당장 나가"));
            hat.sprite = hats[3];
            March.sprite = MarchRabbits[8];
            yield return StartCoroutine(NormalChat("모자장수", "아니.. 그러지 말고 우리의 정을 생각해서~ "));
            hat.sprite = hats[6];
            March.sprite = MarchRabbits[6];
            audio.clip = Sound[0];
            audio.Play();
            yield return StartCoroutine(NormalChat("3월 토끼", "(쨍그랑!)"));
            hat.sprite = hats[2];
            March.sprite = MarchRabbits[8];
            yield return StartCoroutine(NormalChat("모자장수", "아..알았어 알았으니까 찻잔 그만 던져!"));
            audio.clip = Sound[1];
            audio.Play();
            yield return StartCoroutine(NormalChat("모자장수", "(후다닥)"));
            hat.sprite = hats[6];
            March.sprite = MarchRabbits[6];
            hCandy.sprite = hCottonCandy[5];
            yield return StartCoroutine(NormalChat("솜사탕", "..."));
            March.sprite = MarchRabbits[1];
            hat_bgm = true;
            ww.bgm();
            yield return StartCoroutine(NormalChat("3월 토끼", "죄송해요 놀라셨죠.."));
            hCandy.sprite = hCottonCandy[1];
            yield return StartCoroutine(NormalChat("솜사탕", "괜찮아 사과까지 할 필요는 없어"));
            yield return StartCoroutine(NormalChat("3월 토끼", "진작에 이렇게 싫은건 싫다 표현 했어야 했는데...\n그걸 못해서 가족들에게도 솜사탕에게도 피해를 줘 버렸네요"));
            hCandy.sprite = hCottonCandy[3];
            yield return StartCoroutine(NormalChat("솜사탕", "그래도 이제부터는 할 수 있지?"));
            March.sprite = MarchRabbits[5];
            yield return StartCoroutine(NormalChat("3월 토끼", "네..!"));
            March.sprite = MarchRabbits[4];
            yield return StartCoroutine(NormalChat("3월 토끼", "고마워요 솜사탕..."));
            yield return StartCoroutine(NormalChat("3월 토끼", "아 그러고보니 하트여왕님의 성으로 가는 길을 찾으시죠?"));
            hCandy.sprite = hCottonCandy[1];
            yield return StartCoroutine(NormalChat("솜사탕", "응 맞아"));
            yield return StartCoroutine(NormalChat("3월 토끼", "여왕님의 성은 바로 이 옆이에요"));
            yield return StartCoroutine(NormalChat("3월 토끼", "꼭 무사히 집에 돌아 살 수 있길 빌게요"));
            hCandy.sprite = hCottonCandy[3];
            yield return StartCoroutine(NormalChat("솜사탕", "응 고마워\n그럼 난 가볼게 잘 있어 3월 토끼!"));

            audio.clip = Sound[2];
            audio.Play();

            hImage.SetActive(true);
            yield return StartCoroutine(NormalChat(" ", " "));
            while (!hCan_Progress)
            {
                yield return null;
            }
            s.instance.n = 0;
            s.instance.i = 5;
            Invoke("scenemove", 1);
        }
    }

    IEnumerator NormalChat(string narrator, string narration)
    {
        int a = 0;
        h_name.text = narrator;
        wtext = "";

        //효과
        for (a = 0; a < narration.Length; a++)
        {
            wtext += narration[a];
            h_text.text = wtext;
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
