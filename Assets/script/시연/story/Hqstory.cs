using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hqstory : MonoBehaviour
{
    public Text hq_text;
    public Text hq_name;
    string wtext = "";

    public List<Sprite> hqCottonCandy;
    public Image hqCandy;

    public List<Sprite> hqs;
    public Image hq;

    public List<Sprite> Rabbits;
    public Image Rabbit;

    public List<Sprite> hqBackGround;
    public Image hqBack;

    public AudioClip[] Sound;
    AudioSource audio;

    public GameObject Image;
    public GameObject EndImage;

    public List<GameObject> WBackGround;

    public bool Can_Progress;
    public bool EndCan_Progress;
    public bool hq_bgm;

    public Www ww;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();

        StartCoroutine(HQ_s());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator HQ_s()
    {
        if (s.instance.n == 0)
        {
            hq_bgm = true;
            ww.Hqbgm();
            hqBack.sprite = hqBackGround[0];
            hqCandy.sprite = hqCottonCandy[1];
            hq.sprite = hqs[6];
            Rabbit.sprite = Rabbits[2];
            yield return StartCoroutine(NormalChat("솜사탕", "이곳이 하트여왕의 성..."));
            hqCandy.sprite = hqCottonCandy[3];
            yield return StartCoroutine(NormalChat("솜사탕", "그런데 여왕이라는 사람을 이렇게 막\n만날 수 있는 건가 ? "));
            yield return StartCoroutine(NormalChat("???", "도대체 어디로 사라진거야!!"));
            hqCandy.sprite = hqCottonCandy[2];
            yield return StartCoroutine(NormalChat("솜사탕", "............\n....방금 누구의 목소리지?"));
            hq.sprite = hqs[5];
            yield return StartCoroutine(NormalChat("하트여왕", "이 많은 사람들 중에 내 보석의 행방을 아는\n사람이 단 한명도 없단 말이냐!?"));
            yield return StartCoroutine(NormalChat("하트여왕", "어쩜 이리도 무능할 수가!"));
            yield return StartCoroutine(NormalChat("솜사탕", "..."));
            yield return StartCoroutine(NormalChat("하트여왕", "거기 너!!"));
            yield return StartCoroutine(NormalChat("솜사탕", "...저요?"));
            yield return StartCoroutine(NormalChat("하트여왕", "처음보는 얼굴인데 넌 누구지?"));
            hq.sprite = hqs[2];
            yield return StartCoroutine(NormalChat("하트여왕", "아니.. 대답할 필요 없다\n안그래도 기분이 좋지 않은 참 이였는데"));
            yield return StartCoroutine(NormalChat("하트여왕", "누군가의 목이라도 쳐내면\n기분이 한결 나아질지도 모르겠구나"));
            hqCandy.sprite = hqCottonCandy[3];
            yield return StartCoroutine(NormalChat("솜사탕", "자... 잠시만요 여왕님!"));
            hq.sprite = hqs[5];
            yield return StartCoroutine(NormalChat("하트여왕", "뭐지?"));
            yield return StartCoroutine(NormalChat("솜사탕", "제가 여왕님을 도와드릴 수 있습니다!\n지금 무엇을 찾고 계시는지 말씀만 해주시면..."));
            hq.sprite = hqs[2];
            yield return StartCoroutine(NormalChat("하트여왕", "그걸 내가 어떻게 믿을 수 있지?\n살고싶어 발버둥 치는 것 처럼 보이는데?"));
            hqCandy.sprite = hqCottonCandy[2];
            yield return StartCoroutine(NormalChat("솜사탕", "저는 지금까지 이 이상한 나라를 돌아다니며\n수많은 주민들을 도와 왔습니다!"));
            yield return StartCoroutine(NormalChat("솜사탕", "분명 여왕님도 도울 수 있을 거예요"));
            Rabbit.sprite = Rabbits[0];
            hq.sprite = hqs[6];
            yield return StartCoroutine(NormalChat("시계토끼", "그녀의 말은 사실입니다 여왕님"));
            hqCandy.sprite = hqCottonCandy[1];
            yield return StartCoroutine(NormalChat("솜사탕", "시계토끼씨..!"));
            hq.sprite = hqs[1];
            Rabbit.sprite = Rabbits[2];
            yield return StartCoroutine(NormalChat("하트여왕", "시계토끼 너와 아는 사이이냐?"));
            Rabbit.sprite = Rabbits[1];
            hq.sprite = hqs[6];
            yield return StartCoroutine(NormalChat("시계토끼", "물론입니다 저 역시 그녀에게\n도움을 받은 적이 있지요"));
            yield return StartCoroutine(NormalChat("시계토끼", "그러니 그녀에게 한번 기회를 주시는게 어떠십니까?"));
            hq.sprite = hqs[0];
            Rabbit.sprite = Rabbits[2];
            yield return StartCoroutine(NormalChat("하트여왕", "흠..."));
            hq.sprite = hqs[1];
            yield return StartCoroutine(NormalChat("하트여왕", "그래 좋다"));
            hq.sprite = hqs[2];
            yield return StartCoroutine(NormalChat("하트여왕", "단 일을 찾아내지 못 했을 경우\n목을 쳐낼 것이야"));
            yield return StartCoroutine(NormalChat("솜사탕", "그래서 찾고 계신게 무엇 인가요"));
            hqBack.sprite = hqBackGround[1];
            hq.sprite = hqs[1];
            yield return StartCoroutine(NormalChat("하트여왕", "하트모양의 핑크다이아를 찾고 있지\n세상에 단 3개 밖에 없는 귀한 것인데"));
            yield return StartCoroutine(NormalChat("하트여왕", "3개가 모두 사라져 버렸지"));
            yield return StartCoroutine(NormalChat("솜사탕", "그럼 그걸 찾아오면 되는 거죠?"));
            yield return StartCoroutine(NormalChat("하트여왕", "그래 맞다"));
            yield return StartCoroutine(NormalChat("하트여왕", "나의 하트 보석을 모두 찾아온다면\n네 목을 치지 않고 네 부탁도 하나 들어주도록 하마 "));
            hqBack.sprite = hqBackGround[0];
            hqCandy.sprite = hqCottonCandy[0];
            yield return StartCoroutine(NormalChat("솜사탕", "(그럼 집으로 돌아 갈 수 있어...)"));
            hq.sprite = hqs[5];
            yield return StartCoroutine(NormalChat("하트여왕", "뭘 꾸물거리고 있는거지?\n어서 찾아오도록 하거라!"));
            hqCandy.sprite = hqCottonCandy[2];
            yield return StartCoroutine(NormalChat("솜사탕", "아.. 네!!"));

            s.instance.n = 1;

            SceneManager.LoadScene("HQueen_1");//여기에 게임 들어감
        }
        else if (s.instance.n == 1)
        {
            hq_bgm = true;
            ww.Hqbgm();
            hqBack.sprite = hqBackGround[0];
            hqCandy.sprite = hqCottonCandy[0];
            hq.sprite = hqs[3];
            Rabbit.sprite = Rabbits[2];
            yield return StartCoroutine(NormalChat("하트여왕", "오! 나의 아름다운 보석들을 모두 찾아 왔구나!"));
            hqCandy.sprite = hqCottonCandy[1];
            yield return StartCoroutine(NormalChat("솜사탕", "그럼..."));
            hq.sprite = hqs[4];
            yield return StartCoroutine(NormalChat("하트여왕", "그래 지금까지의 무례를 사과하고\n그대의 목을 친다는 말은 거두도록 하지"));
            hq.sprite = hqs[3];
            yield return StartCoroutine(NormalChat("하트여왕", "그대의 이름을 가르쳐 주겠나?"));
            yield return StartCoroutine(NormalChat("솜사탕", "저는 솜사탕 이라고 합니다 하트여왕님"));
            yield return StartCoroutine(NormalChat("하트여왕", "그대와 잘 어울리는 이름이군 솜사탕\n그러고 보니 그대의 부탁을 들어주겠단 약속도 했었지"));
            yield return StartCoroutine(NormalChat("하트여왕", "원하는 걸 하나 말해 보아라\n나 하트여왕의 권한으로 할 수 있는 거라면 뭐든 도와주도록 하지"));
            yield return StartCoroutine(NormalChat("솜사탕", "이미 알고 계시겠지만 전 이 나라의 주민이 아닙니다\n원래 제가 살던 곳으로 돌아 가고 싶어요"));
            hq.sprite = hqs[4];
            yield return StartCoroutine(NormalChat("하트여왕", "어려운 부탁도 아니구나"));
            yield return StartCoroutine(NormalChat("하트여왕", "그럼 나 하트여왕의 권한으로\n그대에게 이상한나라의 입출입 권한을 부여 하노라"));
            hq.sprite = hqs[3];
            yield return StartCoroutine(NormalChat("하트여왕", "그럼 다음에 또 보도록 하지 솜사탕"));
            hqBack.sprite = hqBackGround[3];
            audio.clip = Sound[0];
            audio.Play();
            Image.SetActive(true);
            WBackGround[0].SetActive(true);
            yield return StartCoroutine(NormalChat(" ", " "));
            while (!Can_Progress)
            {
                yield return null;
            }
            hqBack.sprite = hqBackGround[2];
            hq.sprite = hqs[6];
            hq_bgm = false;
            ww.Hqbgm();
            hqCandy.sprite = hqCottonCandy[0];
            yield return StartCoroutine(NormalChat("솜사탕", "........"));
            hqCandy.sprite = hqCottonCandy[1];
            yield return StartCoroutine(NormalChat("솜사탕", "어라... 나...\n방금까지 이상한 나라에 있었는데..."));
            hqCandy.sprite = hqCottonCandy[3];
            yield return StartCoroutine(NormalChat("솜사탕", "전부 꿈이였나..?"));
            hqCandy.sprite = hqCottonCandy[1];
            yield return StartCoroutine(NormalChat("솜사탕", "어..?"));
            hqCandy.sprite = hqCottonCandy[5];
            hqBack.sprite = hqBackGround[4];
            while (!Input.GetMouseButtonDown(0))
            {
                yield return null;
            }
            yield return StartCoroutine(NormalChat("솜사탕", "심심하면 놀러와요...\n이상한나라 일동"));
            hqCandy.sprite = hqCottonCandy[4];
            yield return StartCoroutine(NormalChat("솜사탕", "...꿈이 아니였구나..\n꼭 놀러가야겠네..."));
            yield return StartCoroutine(NormalChat("솜사탕", "마치 내가 이 소설의 주인공이 된 기분이였어..\n그럼 이상한 나라의 앨리스가 아니라"));
            yield return StartCoroutine(NormalChat("솜사탕", "이상한 나라의 솜사탕... 이려나?"));
            WBackGround[1].SetActive(true);
            hqCandy.sprite = hqCottonCandy[5];
            hqBack.sprite = hqBackGround[5];
            yield return new WaitForSeconds(2f);
            audio.clip = Sound[0];
            audio.Play();
            EndImage.SetActive(true);
            yield return StartCoroutine(NormalChat(" ", " "));
            
            while (!EndCan_Progress)
            {
                yield return null;
            }


            s.instance.n = 0;
            s.instance.i = 8;

            Invoke("scenemove", 1);
            
        }

    }

    IEnumerator NormalChat(string narrator, string narration)
    {
        int a = 0;
        hq_name.text = narrator;
        wtext = "";

        //효과
        for (a = 0; a < narration.Length; a++)
        {
            wtext += narration[a];
            hq_text.text = wtext;
            yield return new WaitForSeconds(0.05f);
        }

        while (!Input.GetMouseButtonDown(0))
        {
            yield return null;
        }
    }

    void scenemove() // Invoke 를 쓰기위해 만든 함수
    {
        M6GA call = GameObject.Find("zizonbox").GetComponent<M6GA>();
        call.lock_num++;
        SceneManager.LoadScene("jjap_title");//여기다가 스테이지 선택창
    }

    public void ok()
    {

        if (Input.GetMouseButtonUp(0))
        {

            Debug.Log("hhhhhhhhhhh");
            s.instance.i = 1;
            Image.SetActive(false);

        }

    }

}