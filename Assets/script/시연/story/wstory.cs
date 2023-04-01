using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class wstory : MonoBehaviour
{
    public Text w_text; 
    public Text w_name;
    string wtext = "";

    public List<Sprite> wCottonCandy;
    public Image wCandy;

    public List<Sprite> worms;
    public Image worm;

    public List<Sprite> wBackGround;
    public Image wBack;

    public AudioClip[] Sound;
    AudioSource audio;

    public GameObject WImage;

    public bool WCan_Progress;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.loop = false;

        Debug.Log("ssss");
        StartCoroutine(W_s());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator W_s()
    {
        if (s.instance.n == 0)
        {
            
            wBack.sprite = wBackGround[0];
            wCandy.sprite = wCottonCandy[1];
            worm.sprite = worms[2];
            yield return StartCoroutine(NormalChat("솜사탕", "아까랑은 조금 다른 숲이네..."));
            yield return StartCoroutine(NormalChat("솜사탕", "그건 그렇고 시계토끼씨가 이곳에 주민들에게\n길을 물어보며 가면 하트성까지 갈 수 있을 거라 그랬지..."));
            yield return StartCoroutine(NormalChat("솜사탕", "저기요! 아무도 안계세요?"));
            wCandy.sprite = wCottonCandy[0];
            yield return StartCoroutine(NormalChat("솜사탕", "..."));
            wCandy.sprite = wCottonCandy[5];
            yield return StartCoroutine(NormalChat("솜사탕", "...아무도 없나..\n이런 숲이면 누군가 살거라 생각했는데"));
            yield return StartCoroutine(NormalChat("솜사탕", "좀 오래 걸었더니 목도 마르고...\n하트성까지 가기전에 쓰러 지겠어... "));
            wCandy.sprite = wCottonCandy[1];
            yield return StartCoroutine(NormalChat("솜사탕", "어? 이게 뭐지?"));
            wBack.sprite = wBackGround[1];
            wCandy.sprite = wCottonCandy[6];
            while (!Input.GetMouseButtonDown(0))
            {
                yield return null;
            }
            wCandy.sprite = wCottonCandy[1];
            yield return StartCoroutine(NormalChat("솜사탕", "\"Drink me\"..\n마시라고..?"));
            wCandy.sprite = wCottonCandy[5];
            yield return StartCoroutine(NormalChat("솜사탕", "이런거 막 마셔도 되는 걸까...\n하지만 이거라도 마시지 않으면 목말라서 쓰러질지 몰라..."));
            yield return StartCoroutine(NormalChat("솜사탕", "..."));
            wCandy.sprite = wCottonCandy[2];
            yield return StartCoroutine(NormalChat("솜사탕", "나도 모르겠다..."));
            audio.clip = Sound[0];
            audio.Play();
            yield return StartCoroutine(NormalChat("솜사탕", "(꿀꺽)"));
            yield return new WaitForSeconds(1f);
            wCandy.sprite = wCottonCandy[6];
            worm.sprite = worms[2];
            wBack.sprite = wBackGround[4];
            audio.clip = Sound[1];
            audio.Play();
            yield return new WaitForSeconds(2f);
            wBack.sprite = wBackGround[2];
            wCandy.sprite = wCottonCandy[3];
            yield return StartCoroutine(NormalChat("솜사탕", "어라?"));
            yield return StartCoroutine(NormalChat("솜사탕", "세상이 커졌어..!"));
            worm.sprite = worms[1];
            yield return StartCoroutine(NormalChat("쐐기벌레", "아하하 그게 아니라 네가 작아진 거란다"));
            yield return StartCoroutine(NormalChat("쐐기벌레", "솜사탕... 맞지? 아까 시계토끼한테 들은 그대로네~"));
            yield return StartCoroutine(NormalChat("솜사탕", "네?! 언제부터 제 옆에..."));
            yield return StartCoroutine(NormalChat("쐐기벌레", "네가 이 숲에 도착했을 때 부터 계속 있었지"));
            yield return StartCoroutine(NormalChat("쐐기벌레", "아까 까진 거인처럼 거대 했는데 지금은 나보다도 작아져 버렸네?"));
            yield return StartCoroutine(NormalChat("쐐기벌레", "너 푸른색 물약을 마셨구나?"));
            wCandy.sprite = wCottonCandy[5];
            yield return StartCoroutine(NormalChat("솜사탕", "아.. 맞아요 방금 물약 같은 걸 마셨어요"));
            yield return StartCoroutine(NormalChat("쐐기벌레", "그건 몸을 작게 만드는 물약이야\n또 아이들이 장난이라도 쳐둔 모양이네"));
            yield return StartCoroutine(NormalChat("쐐기벌레", "이상한 나라에는 장난꾸러기들이 참 많단다\n아무거나 입에 대면 장난에 보기좋게 걸려들고 말지"));
            wCandy.sprite = wCottonCandy[2];
            yield return StartCoroutine(NormalChat("솜사탕", "질나쁜 장난이네요..."));
            yield return StartCoroutine(NormalChat("쐐기벌레", "몸만 작아진 정도면 그래도 운이 좋은거야~"));
            yield return StartCoroutine(NormalChat("솜사탕", "..."));
            wCandy.sprite = wCottonCandy[5];
            yield return StartCoroutine(NormalChat("솜사탕", "아.. 그건 그렇고 다시 돌아갈 방법은 없을까요?"));
            worm.sprite = worms[0];
            yield return StartCoroutine(NormalChat("쐐기벌레", "방법? 음~"));
            worm.sprite = worms[1];
            yield return StartCoroutine(NormalChat("쐐기벌레", "있는데 지금 당장은 불가능해"));
            yield return StartCoroutine(NormalChat("솜사탕", "네? 어째서요?"));
            yield return StartCoroutine(NormalChat("쐐기벌레", "다시 커지는 물약을 만들어야 하는데\n재료가 모두 떨어졌거든~"));
            yield return StartCoroutine(NormalChat("솜사탕", "그럼 방법이 없는건가요..?"));
            worm.sprite = worms[0];
            yield return StartCoroutine(NormalChat("쐐기벌레", "완전 없는 건 아니지 "));
            worm.sprite = worms[1];
            yield return StartCoroutine(NormalChat("쐐기벌레", "네가 물약의 재료를 구해오면 돼!"));
            yield return StartCoroutine(NormalChat("쐐기벌레", "그렇게 복잡한 재료는 아니니까 금방 찾을 수 있을거야"));
            wCandy.sprite = wCottonCandy[1];
            yield return StartCoroutine(NormalChat("솜사탕", "정말요?"));
            yield return StartCoroutine(NormalChat("솜사탕", "어떤 재료를 구해와야 하죠?"));
            yield return StartCoroutine(NormalChat("쐐기벌레", "내가 쪽지에 적어 줄게 이 3가지 재료만 찾아와 주면 돼~"));
            yield return StartCoroutine(NormalChat("솜사탕", "네 알겠어요!"));
            wCandy.sprite = wCottonCandy[0];
            yield return StartCoroutine(NormalChat("솜사탕", "(서둘러 찾아보자)"));

            //이제 미니게임 나옴,

            s.instance.n = 1;

            SceneManager.LoadScene("larva_scene");

        }
        else if (s.instance.n == 1)
        {
            //끝난후 
            wCandy.sprite = wCottonCandy[1];
            worm.sprite = worms[0];
            yield return StartCoroutine(NormalChat("솜사탕", "모두 찾아왔어요!"));
            worm.sprite = worms[1];
            yield return StartCoroutine(NormalChat("쐐기벌레", "생각보다 금방 왔네?"));
            yield return StartCoroutine(NormalChat("솜사탕", "좋아 그럼 내가 이걸로 커지는 물약을 만들어 줄게"));
            wCandy.sprite = wCottonCandy[6];
            worm.sprite = worms[2];
            wBack.sprite = wBackGround[4];
            yield return new WaitForSeconds(1f);
            wBack.sprite = wBackGround[3];
            worm.sprite = worms[1];
            yield return StartCoroutine(NormalChat("쐐기벌레", "여기 있어~ 다시 커지는 물약!"));
            wBack.sprite = wBackGround[2];
            wCandy.sprite = wCottonCandy[4];
            yield return StartCoroutine(NormalChat("솜사탕", "감사합니다 애벌레씨!"));
            yield return StartCoroutine(NormalChat("쐐기벌레", "정확히는 쐐기벌레란다"));
            yield return StartCoroutine(NormalChat("쐐기벌레", "이럴때가 아니지!"));
            yield return StartCoroutine(NormalChat("쐐기벌레", "어서 물약을 마시고 하트여왕이 있는 성으로 가보렴"));
            yield return StartCoroutine(NormalChat("쐐기벌레", "숲의 길을 쭉따라가면 체셔고양이가 사는 보라색 숲이 나올거야\n그 아이에게 또 길을 물어보면 될거란다"));
            yield return StartCoroutine(NormalChat("쐐기벌레", "잘가~ 꼬마 아가씨"));
            yield return StartCoroutine(NormalChat("솜사탕", "안녕히 계세요 쐐기벌레씨!"));
            worm.sprite = worms[2];
            wCandy.sprite = wCottonCandy[0];
            audio.clip = Sound[0];
            audio.Play();
            yield return StartCoroutine(NormalChat("솜사탕", "(꿀꺽)"));
            wCandy.sprite = wCottonCandy[6];
            wBack.sprite = wBackGround[4];
            audio.clip = Sound[1];
            audio.Play();
            yield return new WaitForSeconds(2f);
            wBack.sprite = wBackGround[0];
            wCandy.sprite = wCottonCandy[3];
            yield return StartCoroutine(NormalChat("솜사탕", "돌아 왔다...!"));
            wCandy.sprite = wCottonCandy[1];
            yield return StartCoroutine(NormalChat("솜사탕", "그럼... 이제..."));
            yield return StartCoroutine(NormalChat("솜사탕", "분명 숲의 길을 따라가다\n체셔 고양이에게 길을 또 물어보라 하셨었지?"));
            yield return StartCoroutine(NormalChat("솜사탕", "...가보자!"));

            audio.clip = Sound[2];
            audio.Play();

            WImage.SetActive(true);
            yield return StartCoroutine(NormalChat(" ", " "));
            while (!WCan_Progress)
            {
                yield return null;
            }

            s.instance.n = 0;
            s.instance.i = 3;

            Invoke("scenemove", 1);
        }
    }




    IEnumerator NormalChat(string narrator, string narration)
    {
        int a = 0;
        w_name.text = narrator;
        wtext = "";

        //효과
        for (a = 0; a < narration.Length; a++)
        {
            wtext += narration[a];
            w_text.text = wtext;
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
