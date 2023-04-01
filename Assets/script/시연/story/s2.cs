using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class s2 : MonoBehaviour
{
    public Text Text;
    public Text Name;
    string wtext = "";

    public List<Sprite> CottonCandy;
    public Image Candy;

    public List<Sprite> ClockRabbit;
    public Image Rabbit;

    public List<Sprite> BackGround;
    public Image Back;

    public GameObject CrImage;

    public bool CrCan_Progress;

    public AudioClip[] Sound;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        StartCoroutine(CB_s());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator CB_s()
    {
        if (s.instance.n == 0)
        {
            
            Back.sprite = BackGround[0];
            Candy.sprite = CottonCandy[0];
            Rabbit.sprite = ClockRabbit[5];
            yield return StartCoroutine(NormalChat("솜사탕", "분명 이쪽에서 소리가 났었지.."));
            Rabbit.sprite = ClockRabbit[2];
            yield return StartCoroutine(NormalChat("시계토끼", "....이런 이러다 약속 시간에 늦어버리고 말겠어요"));
            Candy.sprite = CottonCandy[2];
            yield return StartCoroutine(NormalChat("솜사탕", "사람..?"));
            Rabbit.sprite = ClockRabbit[3];
            yield return StartCoroutine(NormalChat("시계토끼", "...!"));
            Rabbit.sprite = ClockRabbit[1];
            yield return StartCoroutine(NormalChat("시계토끼", "아.. 아까본 숙녀분 이로군요\n놀라게 해드려 죄송합니다"));
            Candy.sprite = CottonCandy[0];
            yield return StartCoroutine(NormalChat("솜사탕", "아까본... 이라니?"));
            Rabbit.sprite = ClockRabbit[1];
            yield return StartCoroutine(NormalChat("시계토끼", "아까 숙녀분도 절 보지 않으셨나요?"));
            yield return StartCoroutine(NormalChat("시계토끼", "잠깐만 토끼야... 라며 따라오셨던 거 같은데"));
            Candy.sprite = CottonCandy[2];
            yield return StartCoroutine(NormalChat("솜사탕", "당신이 아까 그 토끼 라고요?"));
            Rabbit.sprite = ClockRabbit[1];
            yield return StartCoroutine(NormalChat("시계토끼", "왜 그렇게 놀라시는..."));
            Rabbit.sprite = ClockRabbit[3];
            yield return StartCoroutine(NormalChat("시계토끼", "아..! 설마 당신은 이곳의 주민이 아니신 건가요?"));
            Candy.sprite = CottonCandy[3];
            yield return StartCoroutine(NormalChat("솜사탕", "이곳...?"));
            Rabbit.sprite = ClockRabbit[1];
            yield return StartCoroutine(NormalChat("시계토끼", "이 숲은 이상한 나라의 영토 입니다"));
            yield return StartCoroutine(NormalChat("시계토끼", "우리같은 주민들은 밖에서는 동물의 모습이지만\n이상한 나라의 영토 안에서는 인간의 모습을 하고 있죠"));
            Candy.sprite = CottonCandy[2];
            yield return StartCoroutine(NormalChat("솜사탕", "이상한 나라 라고요...?"));
            yield return StartCoroutine(NormalChat("솜사탕", "어서 집에 돌아가야 하는데..."));
            Rabbit.sprite = ClockRabbit[2];
            yield return StartCoroutine(NormalChat("시계토끼", "도와드리고 싶은 마음은 굴뚝 같지만..."));
            yield return StartCoroutine(NormalChat("시계토끼", "저 역시 곤란한 상황이라\n도와드리기 힘들 거 같네요..."));
            Candy.sprite = CottonCandy[0];
            yield return StartCoroutine(NormalChat("솜사탕", "곤란한 상황이요..?"));
            Rabbit.sprite = ClockRabbit[2];
            yield return StartCoroutine(NormalChat("시계토끼", "네... 방금 실수로 시계를 떨어 트리는 바람에\n여왕님께 받은 소중한 시계가 부숴져 버리고 말았어요.."));
            Candy.sprite = CottonCandy[1];
            yield return StartCoroutine(NormalChat("솜사탕", "(아... 아까 그 소리가...)"));
            Rabbit.sprite = ClockRabbit[2];
            yield return StartCoroutine(NormalChat("시계토끼", "지금 여왕님과의 약속이 있어 성으로 가는 길인데...\n시계가 부서진 걸 아시면 분명 크게 화내시겠죠..."));
            Candy.sprite = CottonCandy[1];
            yield return StartCoroutine(NormalChat("솜사탕", "(...완전히 부숴진거 같진 않고 조립만 하면 될거 같은데...)"));
            Candy.sprite = CottonCandy[0];
            yield return StartCoroutine(NormalChat("솜사탕", "저기... 그 시계 제가 고칠 수 있을 거 같아요"));
            Rabbit.sprite = ClockRabbit[3];
            yield return StartCoroutine(NormalChat("시계토끼", "그게 정말 인가요?"));
            Candy.sprite = CottonCandy[0];
            yield return StartCoroutine(NormalChat("솜사탕", "네 조립이라면 자신 있어요"));
            Rabbit.sprite = ClockRabbit[4];
            yield return StartCoroutine(NormalChat("시계토끼", "정말 감사합니다... 그러니까 성함이?"));
            Candy.sprite = CottonCandy[0];
            yield return StartCoroutine(NormalChat("솜사탕", "솜사탕이에요"));
            Rabbit.sprite = ClockRabbit[4];
            yield return StartCoroutine(NormalChat("시계토끼", "솜사탕 이로군요 저는 시계 토끼라고 합니다"));
            yield return StartCoroutine(NormalChat("시계토끼", "그럼 제 시계를 부탁드릴게요"));

            //이제 미니게임 나옴,

            SceneManager.LoadScene("si yeon");

        }
        else if (s.instance.n == 1)
        {
            
            //끝난후 
            Rabbit.sprite = ClockRabbit[0];
            Candy.sprite = CottonCandy[4];
            yield return StartCoroutine(NormalChat("솜사탕", "됐어요..! 잘 작동도 하고..."));
            Rabbit.sprite = ClockRabbit[3];
            yield return StartCoroutine(NormalChat("시계토끼", "정말 고치셨군요!"));
            Rabbit.sprite = ClockRabbit[4];
            yield return StartCoroutine(NormalChat("시계토끼", "정말 다행이에요 이걸로 여왕님과의 약속에도\n늦지 않을 수 있겠어요..."));
            yield return StartCoroutine(NormalChat("시계토끼", "뭐라고 감사를 드려야 할지..."));
            Rabbit.sprite = ClockRabbit[1];
            yield return StartCoroutine(NormalChat("시계토끼", "아 그러고 보니 돌아갈 방법을 찾고 계시는 거죠?"));
            Candy.sprite = CottonCandy[0];
            yield return StartCoroutine(NormalChat("솜사탕", "맞아요.. 혹시 방법을 아시나요?"));
            Back.sprite = BackGround[1];
            Rabbit.sprite = ClockRabbit[1];
            yield return StartCoroutine(NormalChat("시계토끼", "이 이상한 나라에서 밖으로 나가려면 숲에서 부터\n멀리 떨어져 있는 하트 성으로가서 하트여왕의 허락을 받아야 해요"));
            Candy.sprite = CottonCandy[3];
            yield return StartCoroutine(NormalChat("솜사탕", "여왕님의 허락이요..?"));
            Rabbit.sprite = ClockRabbit[4];
            yield return StartCoroutine(NormalChat("시계토끼", "음.. 여왕님은 조금 대하기 까다로운 분이지만\n기분 파시니 기분만 좀 맞춰 드리면 금방 허락해 주실거예요"));
            yield return StartCoroutine(NormalChat("시계토끼", "너무 걱정하지 않으셔도 됩니다"));
            Candy.sprite = CottonCandy[0];
            yield return StartCoroutine(NormalChat("솜사탕", "그렇다면야 조금 안심이 되네요"));
            Rabbit.sprite = ClockRabbit[3];
            yield return StartCoroutine(NormalChat("시계토끼", "이런! 시간이 벌써 이렇게..."));
            yield return StartCoroutine(NormalChat("시계토끼", "저는 더 늦기전에 가봐야 할 거 같네요"));
            Rabbit.sprite = ClockRabbit[4];
            yield return StartCoroutine(NormalChat("시계토끼", "이 주변에는 이상한나라의 주민들이 많으니\n그들에게 길을 물어보면 될거예요"));
            yield return StartCoroutine(NormalChat("시계토끼", "그럼 다음에 기회가 된다면 다시 뵈죠"));
            Candy.sprite = CottonCandy[4];
            yield return StartCoroutine(NormalChat("솜사탕", "네 감사합니다..! 다음에 기회가 된다면 뵈요 시계토끼씨"));

            audio.clip = Sound[0];
            audio.Play();

            CrImage.SetActive(true);
            yield return StartCoroutine(NormalChat(" ", " "));
            while (!CrCan_Progress)
            {
                yield return null;
            }

            s.instance.n = 0;
            s.instance.i = 2;

            Invoke("scenemove", 1);

        }
    }

    IEnumerator NormalChat(string narrator, string narration)
    {
        int a = 0;
        Name.text = narrator;
        wtext = "";

        //효과
        for (a = 0; a < narration.Length; a++)
        {
            wtext += narration[a];
            Text.text = wtext;
            yield return new WaitForSeconds(0.05f);
        }

        while (!Input.GetMouseButtonDown(0))
        {
            yield return null;
        }
    }

    void scenemove()
    {
        SceneManager.LoadScene("main_proto_scene");
    }






}



