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
            yield return StartCoroutine(NormalChat("�ػ���", "�̰��� ��Ʈ������ ��..."));
            hqCandy.sprite = hqCottonCandy[3];
            yield return StartCoroutine(NormalChat("�ػ���", "�׷��� �����̶�� ����� �̷��� ��\n���� �� �ִ� �ǰ� ? "));
            yield return StartCoroutine(NormalChat("???", "����ü ���� ������ž�!!"));
            hqCandy.sprite = hqCottonCandy[2];
            yield return StartCoroutine(NormalChat("�ػ���", "............\n....��� ������ ��Ҹ���?"));
            hq.sprite = hqs[5];
            yield return StartCoroutine(NormalChat("��Ʈ����", "�� ���� ����� �߿� �� ������ ����� �ƴ�\n����� �� �Ѹ� ���� ���̳�!?"));
            yield return StartCoroutine(NormalChat("��Ʈ����", "���� �̸��� ������ ����!"));
            yield return StartCoroutine(NormalChat("�ػ���", "..."));
            yield return StartCoroutine(NormalChat("��Ʈ����", "�ű� ��!!"));
            yield return StartCoroutine(NormalChat("�ػ���", "...����?"));
            yield return StartCoroutine(NormalChat("��Ʈ����", "ó������ ���ε� �� ������?"));
            hq.sprite = hqs[2];
            yield return StartCoroutine(NormalChat("��Ʈ����", "�ƴ�.. ����� �ʿ� ����\n�ȱ׷��� ����� ���� ���� �� �̿��µ�"));
            yield return StartCoroutine(NormalChat("��Ʈ����", "�������� ���̶� �ĳ���\n����� �Ѱ� ���������� �𸣰ڱ���"));
            hqCandy.sprite = hqCottonCandy[3];
            yield return StartCoroutine(NormalChat("�ػ���", "��... ��ø��� ���մ�!"));
            hq.sprite = hqs[5];
            yield return StartCoroutine(NormalChat("��Ʈ����", "����?"));
            yield return StartCoroutine(NormalChat("�ػ���", "���� ���մ��� ���͵帱 �� �ֽ��ϴ�!\n���� ������ ã�� ��ô��� ������ ���ֽø�..."));
            hq.sprite = hqs[2];
            yield return StartCoroutine(NormalChat("��Ʈ����", "�װ� ���� ��� ���� �� ����?\n���;� �߹��� ġ�� �� ó�� ���̴µ�?"));
            hqCandy.sprite = hqCottonCandy[2];
            yield return StartCoroutine(NormalChat("�ػ���", "���� ���ݱ��� �� �̻��� ���� ���ƴٴϸ�\n������ �ֹε��� ���� �Խ��ϴ�!"));
            yield return StartCoroutine(NormalChat("�ػ���", "�и� ���մԵ� ���� �� ���� �ſ���"));
            Rabbit.sprite = Rabbits[0];
            hq.sprite = hqs[6];
            yield return StartCoroutine(NormalChat("�ð��䳢", "�׳��� ���� ����Դϴ� ���մ�"));
            hqCandy.sprite = hqCottonCandy[1];
            yield return StartCoroutine(NormalChat("�ػ���", "�ð��䳢��..!"));
            hq.sprite = hqs[1];
            Rabbit.sprite = Rabbits[2];
            yield return StartCoroutine(NormalChat("��Ʈ����", "�ð��䳢 �ʿ� �ƴ� �����̳�?"));
            Rabbit.sprite = Rabbits[1];
            hq.sprite = hqs[6];
            yield return StartCoroutine(NormalChat("�ð��䳢", "�����Դϴ� �� ���� �׳࿡��\n������ ���� ���� ������"));
            yield return StartCoroutine(NormalChat("�ð��䳢", "�׷��� �׳࿡�� �ѹ� ��ȸ�� �ֽô°� ��ʴϱ�?"));
            hq.sprite = hqs[0];
            Rabbit.sprite = Rabbits[2];
            yield return StartCoroutine(NormalChat("��Ʈ����", "��..."));
            hq.sprite = hqs[1];
            yield return StartCoroutine(NormalChat("��Ʈ����", "�׷� ����"));
            hq.sprite = hqs[2];
            yield return StartCoroutine(NormalChat("��Ʈ����", "�� ���� ã�Ƴ��� �� ���� ���\n���� �ĳ� ���̾�"));
            yield return StartCoroutine(NormalChat("�ػ���", "�׷��� ã�� ��Ű� ���� �ΰ���"));
            hqBack.sprite = hqBackGround[1];
            hq.sprite = hqs[1];
            yield return StartCoroutine(NormalChat("��Ʈ����", "��Ʈ����� ��ũ���̾Ƹ� ã�� ����\n���� �� 3�� �ۿ� ���� ���� ���ε�"));
            yield return StartCoroutine(NormalChat("��Ʈ����", "3���� ��� ����� ������"));
            yield return StartCoroutine(NormalChat("�ػ���", "�׷� �װ� ã�ƿ��� �Ǵ� ����?"));
            yield return StartCoroutine(NormalChat("��Ʈ����", "�׷� �´�"));
            yield return StartCoroutine(NormalChat("��Ʈ����", "���� ��Ʈ ������ ��� ã�ƿ´ٸ�\n�� ���� ġ�� �ʰ� �� ��Ź�� �ϳ� ����ֵ��� �ϸ� "));
            hqBack.sprite = hqBackGround[0];
            hqCandy.sprite = hqCottonCandy[0];
            yield return StartCoroutine(NormalChat("�ػ���", "(�׷� ������ ���� �� �� �־�...)"));
            hq.sprite = hqs[5];
            yield return StartCoroutine(NormalChat("��Ʈ����", "�� �ٹ��Ÿ��� �ִ°���?\n� ã�ƿ����� �ϰŶ�!"));
            hqCandy.sprite = hqCottonCandy[2];
            yield return StartCoroutine(NormalChat("�ػ���", "��.. ��!!"));

            s.instance.n = 1;

            SceneManager.LoadScene("HQueen_1");//���⿡ ���� ��
        }
        else if (s.instance.n == 1)
        {
            hq_bgm = true;
            ww.Hqbgm();
            hqBack.sprite = hqBackGround[0];
            hqCandy.sprite = hqCottonCandy[0];
            hq.sprite = hqs[3];
            Rabbit.sprite = Rabbits[2];
            yield return StartCoroutine(NormalChat("��Ʈ����", "��! ���� �Ƹ��ٿ� �������� ��� ã�� �Ա���!"));
            hqCandy.sprite = hqCottonCandy[1];
            yield return StartCoroutine(NormalChat("�ػ���", "�׷�..."));
            hq.sprite = hqs[4];
            yield return StartCoroutine(NormalChat("��Ʈ����", "�׷� ���ݱ����� ���ʸ� ����ϰ�\n�״��� ���� ģ�ٴ� ���� �ŵε��� ����"));
            hq.sprite = hqs[3];
            yield return StartCoroutine(NormalChat("��Ʈ����", "�״��� �̸��� ������ �ְڳ�?"));
            yield return StartCoroutine(NormalChat("�ػ���", "���� �ػ��� �̶�� �մϴ� ��Ʈ���մ�"));
            yield return StartCoroutine(NormalChat("��Ʈ����", "�״�� �� ��︮�� �̸��̱� �ػ���\n�׷��� ���� �״��� ��Ź�� ����ְڴ� ��ӵ� �߾���"));
            yield return StartCoroutine(NormalChat("��Ʈ����", "���ϴ� �� �ϳ� ���� ���ƶ�\n�� ��Ʈ������ �������� �� �� �ִ� �Ŷ�� ���� �����ֵ��� ����"));
            yield return StartCoroutine(NormalChat("�ػ���", "�̹� �˰� ��ð����� �� �� ������ �ֹ��� �ƴմϴ�\n���� ���� ��� ������ ���� ���� �;��"));
            hq.sprite = hqs[4];
            yield return StartCoroutine(NormalChat("��Ʈ����", "����� ��Ź�� �ƴϱ���"));
            yield return StartCoroutine(NormalChat("��Ʈ����", "�׷� �� ��Ʈ������ ��������\n�״뿡�� �̻��ѳ����� ������ ������ �ο� �ϳ��"));
            hq.sprite = hqs[3];
            yield return StartCoroutine(NormalChat("��Ʈ����", "�׷� ������ �� ������ ���� �ػ���"));
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
            yield return StartCoroutine(NormalChat("�ػ���", "........"));
            hqCandy.sprite = hqCottonCandy[1];
            yield return StartCoroutine(NormalChat("�ػ���", "���... ��...\n��ݱ��� �̻��� ���� �־��µ�..."));
            hqCandy.sprite = hqCottonCandy[3];
            yield return StartCoroutine(NormalChat("�ػ���", "���� ���̿���..?"));
            hqCandy.sprite = hqCottonCandy[1];
            yield return StartCoroutine(NormalChat("�ػ���", "��..?"));
            hqCandy.sprite = hqCottonCandy[5];
            hqBack.sprite = hqBackGround[4];
            while (!Input.GetMouseButtonDown(0))
            {
                yield return null;
            }
            yield return StartCoroutine(NormalChat("�ػ���", "�ɽ��ϸ� ��Ϳ�...\n�̻��ѳ��� �ϵ�"));
            hqCandy.sprite = hqCottonCandy[4];
            yield return StartCoroutine(NormalChat("�ػ���", "...���� �ƴϿ�����..\n�� ����߰ڳ�..."));
            yield return StartCoroutine(NormalChat("�ػ���", "��ġ ���� �� �Ҽ��� ���ΰ��� �� ����̿���..\n�׷� �̻��� ������ �ٸ����� �ƴ϶�"));
            yield return StartCoroutine(NormalChat("�ػ���", "�̻��� ������ �ػ���... �̷���?"));
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

        //ȿ��
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

    void scenemove() // Invoke �� �������� ���� �Լ�
    {
        M6GA call = GameObject.Find("zizonbox").GetComponent<M6GA>();
        call.lock_num++;
        SceneManager.LoadScene("jjap_title");//����ٰ� �������� ����â
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