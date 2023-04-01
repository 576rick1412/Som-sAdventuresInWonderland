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
            yield return StartCoroutine(NormalChat("�ػ���", "���Ⱑ ü�� ����̰� ��� ����� ��..."));
            yield return StartCoroutine(NormalChat("�ػ���", "�׷� ���⼭ ü�� ����̸� ã���� �ǰ���?"));
            yield return StartCoroutine(NormalChat("???", "��~~~��!"));
            cCandy.sprite = cCottonCandy[4];
            yield return StartCoroutine(NormalChat("�ػ���", "��? ��� ��Ҹ���.."));
            yield return StartCoroutine(NormalChat("???", "����� ����~! ���� ����!"));
            yield return StartCoroutine(NormalChat("�ػ���", "���� ��?"));
            yield return StartCoroutine(NormalChat("�ػ���", "��!"));
            cat.sprite = cats[3];
            yield return StartCoroutine(NormalChat("ü�� �����", "���� �ô�!"));
            cat.sprite = cats[1];
            yield return StartCoroutine(NormalChat("ü�� �����", "�װ� �ػ��� ����?\n���� �������� �̹� ���� �޾Ҿ�!"));
            cCandy.sprite = cCottonCandy[1];
            yield return StartCoroutine(NormalChat("�ػ���", "�ҽ��� ��û ������.."));
            cat.sprite = cats[3];
            yield return StartCoroutine(NormalChat("ü�� �����", "�̻��� ������ �ֹε��� �� �ҽĿ� �ΰ� �ϰŵ�~!"));
            cat.sprite = cats[1];
            yield return StartCoroutine(NormalChat("ü�� �����", "�Ƹ� �̹� �̻��� ������ �ֹ� ��κ���\n���� �ҽ��� �˰� ���� �ž�~"));
            yield return StartCoroutine(NormalChat("�ػ���", "�׷� ���� �� �� ã�� �־������� �˰ڳ�?"));
            cat.sprite = cats[3];
            yield return StartCoroutine(NormalChat("ü�� �����", "���� �˰���~! ������!"));
            cat.sprite = cats[1];
            yield return StartCoroutine(NormalChat("ü�� �����", "������ ���� ���� �˷��� �� ����!\n�� ����� ���� ���ܼ� ���̾�~"));
            cCandy.sprite = cCottonCandy[3];
            yield return StartCoroutine(NormalChat("�ػ���", "���� ����غ��̴� ǥ���� �ƴѵ�.."));
            cat.sprite = cats[2];
            yield return StartCoroutine(NormalChat("ü�� �����", "�ƴ� �ƴ�!! ���� �Ҹ�~!\n���� ��~û ��� �ϴٰ�!"));
            cat.sprite = cats[1];
            yield return StartCoroutine(NormalChat("ü�� �����", "�׷��� �װ� �� �� ���������� �ϴµ�~"));
            yield return StartCoroutine(NormalChat("�ػ���", "�׳� ó������ ���ʹ޶�� ����..."));
            cat.sprite = cats[3];
            yield return StartCoroutine(NormalChat("ü�� �����", "�׷� ��� ���ݾ�! �ڵ� ����!\n�ƹ�ư �� �����ָ� ���� �� �����ٰ�!"));
            cCandy.sprite = cCottonCandy[1];
            yield return StartCoroutine(NormalChat("�ػ���", "�׷��� ������ ����?"));
            cat.sprite = cats[2];
            yield return StartCoroutine(NormalChat("ü�� �����", "�װ� ������~"));
            cat.sprite = cats[5];
            cCandy.sprite = cCottonCandy[6];
            cBack.sprite = cBackGround[1];
            yield return StartCoroutine(NormalChat("ü�� �����", "����� ���� �� ��������� ���� � ���� ��..."));
            yield return StartCoroutine(NormalChat("ü�� �����", "���� ������ â���� ���� ���� ����� ����� �߰� �߰ŵ�~!"));
            yield return StartCoroutine(NormalChat("ü�� �����", "�׷��� ������� ����� ��� ������ ����µ�"));
            yield return StartCoroutine(NormalChat("ü�� �����", "�Ʊ� �Ǽ��� �������� ������ ������ ������ ����!"));
            cat.sprite = cats[2];
            cCandy.sprite = cCottonCandy[2];
            cBack.sprite = cBackGround[0];
            yield return StartCoroutine(NormalChat("ü�� �����", "�׷��� ���� ���� ���� �����~"));
            cCandy.sprite = cCottonCandy[3];
            yield return StartCoroutine(NormalChat("�ػ���", "... �װ� �׷��� ����� ���̾�?"));
            cat.sprite = cats[4];
            yield return StartCoroutine(NormalChat("ü�� �����", "�翬����! �̸��� �λ��� �̿��ٰ�!"));
            yield return StartCoroutine(NormalChat("ü�� �����", "�׷��� �����ٰž�?"));
            yield return StartCoroutine(NormalChat("�ػ���", "���� ��� ����� �ϴµ�?"));
            cat.sprite = cats[3];
            yield return StartCoroutine(NormalChat("ü�� �����", "������~! ���� ������ �ٽ� ���� �ָ� ��!\n�� ���Ƽ��� ���� �ϰ� ������ �� �̷��� ���� �� �ϰŵ�"));
            cCandy.sprite = cCottonCandy[1];
            yield return StartCoroutine(NormalChat("�ػ���", "�˾Ҿ�... ���� ���� ���"));
            yield return StartCoroutine(NormalChat("ü�� �����", "���� �����ִ°ž�? �ƽ�~!\n�׷� ��Ź �� �Ұ�!"));

            SceneManager.LoadScene("si won");

        }
        else if(s.instance.n == 1)
        {
            cCandy.sprite = cCottonCandy[1];
            cat.sprite = cats[0];
            yield return StartCoroutine(NormalChat("�ػ���", "�ƴ�... ���󺹱� �ƾ�"));
            cat.sprite = cats[3];
            yield return StartCoroutine(NormalChat("ü�� �����", "���� �� �߾�~?\n����ϴ�~!!"));
            yield return StartCoroutine(NormalChat("ü�� �����", "�̰ɷ� �̸��� �λ����� �ٽ� ���� �� �� �ְھ�!"));
            cCandy.sprite = cCottonCandy[1];
            yield return StartCoroutine(NormalChat("�ػ���", "�׷��� ��Ʈ������ ���� ������̾�?"));
            yield return StartCoroutine(NormalChat("ü�� �����", "��~ �´� �´�\n�װ� ������� �Դ��ſ��� ��!"));
            cat.sprite = cats[1];
            yield return StartCoroutine(NormalChat("ü�� �����", "���� �ִ� ������ ������ ��~ ���ٺ���\n� �� �༮���� ���ðž� �µ����� �ٽ��ѹ� �����!"));
            cat.sprite = cats[3];
            yield return StartCoroutine(NormalChat("ü�� �����", "�� ������ �׳༮�鵵 �� ������ �� �ʿ��� �� ������~"));
            cCandy.sprite = cCottonCandy[3];
            yield return StartCoroutine(NormalChat("�ػ���", "�̻��� ������ �ֹε��� ���� �̷���\n������ ���� �ʿ� �Ѱž�..."));
            yield return StartCoroutine(NormalChat("ü�� �����", "�׳� �װ� ���� �� ���Ƽ�\n�ֹε��� ������ �ʿ��� �� �̰����� ���� ���̾�!"));
            yield return StartCoroutine(NormalChat("�ػ���", ".... �ƹ�ư ���� �� ������"));
            yield return StartCoroutine(NormalChat("ü�� �����", "�߰� �ػ���~!"));

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

        //ȿ��
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

    void scenemove() // Invoke �� �������� ���� �Լ�
    {
        SceneManager.LoadScene("main_proto_scene");
    }


}

