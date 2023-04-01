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
            yield return StartCoroutine(NormalChat("�ػ���", "�Ʊ���� ���� �ٸ� ���̳�..."));
            yield return StartCoroutine(NormalChat("�ػ���", "�װ� �׷��� �ð��䳢���� �̰��� �ֹε鿡��\n���� ����� ���� ��Ʈ������ �� �� ���� �Ŷ� �׷���..."));
            yield return StartCoroutine(NormalChat("�ػ���", "�����! �ƹ��� �Ȱ輼��?"));
            wCandy.sprite = wCottonCandy[0];
            yield return StartCoroutine(NormalChat("�ػ���", "..."));
            wCandy.sprite = wCottonCandy[5];
            yield return StartCoroutine(NormalChat("�ػ���", "...�ƹ��� ����..\n�̷� ���̸� ������ ��Ŷ� �����ߴµ�"));
            yield return StartCoroutine(NormalChat("�ػ���", "�� ���� �ɾ����� �� ������...\n��Ʈ������ �������� ���� ���ھ�... "));
            wCandy.sprite = wCottonCandy[1];
            yield return StartCoroutine(NormalChat("�ػ���", "��? �̰� ����?"));
            wBack.sprite = wBackGround[1];
            wCandy.sprite = wCottonCandy[6];
            while (!Input.GetMouseButtonDown(0))
            {
                yield return null;
            }
            wCandy.sprite = wCottonCandy[1];
            yield return StartCoroutine(NormalChat("�ػ���", "\"Drink me\"..\n���ö��..?"));
            wCandy.sprite = wCottonCandy[5];
            yield return StartCoroutine(NormalChat("�ػ���", "�̷��� �� ���ŵ� �Ǵ� �ɱ�...\n������ �̰Ŷ� ������ ������ �񸻶� �������� ����..."));
            yield return StartCoroutine(NormalChat("�ػ���", "..."));
            wCandy.sprite = wCottonCandy[2];
            yield return StartCoroutine(NormalChat("�ػ���", "���� �𸣰ڴ�..."));
            audio.clip = Sound[0];
            audio.Play();
            yield return StartCoroutine(NormalChat("�ػ���", "(�ܲ�)"));
            yield return new WaitForSeconds(1f);
            wCandy.sprite = wCottonCandy[6];
            worm.sprite = worms[2];
            wBack.sprite = wBackGround[4];
            audio.clip = Sound[1];
            audio.Play();
            yield return new WaitForSeconds(2f);
            wBack.sprite = wBackGround[2];
            wCandy.sprite = wCottonCandy[3];
            yield return StartCoroutine(NormalChat("�ػ���", "���?"));
            yield return StartCoroutine(NormalChat("�ػ���", "������ Ŀ����..!"));
            worm.sprite = worms[1];
            yield return StartCoroutine(NormalChat("�������", "������ �װ� �ƴ϶� �װ� �۾��� �Ŷ���"));
            yield return StartCoroutine(NormalChat("�������", "�ػ���... ����? �Ʊ� �ð��䳢���� ���� �״�γ�~"));
            yield return StartCoroutine(NormalChat("�ػ���", "��?! �������� �� ����..."));
            yield return StartCoroutine(NormalChat("�������", "�װ� �� ���� �������� �� ���� ��� �־���"));
            yield return StartCoroutine(NormalChat("�������", "�Ʊ� ���� ����ó�� �Ŵ� �ߴµ� ������ �����ٵ� �۾��� ���ȳ�?"));
            yield return StartCoroutine(NormalChat("�������", "�� Ǫ���� ������ ���̱���?"));
            wCandy.sprite = wCottonCandy[5];
            yield return StartCoroutine(NormalChat("�ػ���", "��.. �¾ƿ� ��� ���� ���� �� ���̾��"));
            yield return StartCoroutine(NormalChat("�������", "�װ� ���� �۰� ����� �����̾�\n�� ���̵��� �峭�̶� �ĵ� ����̳�"));
            yield return StartCoroutine(NormalChat("�������", "�̻��� ���󿡴� �峭�ٷ������ �� ���ܴ�\n�ƹ��ų� �Կ� ��� �峭�� �������� �ɷ���� ����"));
            wCandy.sprite = wCottonCandy[2];
            yield return StartCoroutine(NormalChat("�ػ���", "������ �峭�̳׿�..."));
            yield return StartCoroutine(NormalChat("�������", "���� �۾��� ������ �׷��� ���� �����ž�~"));
            yield return StartCoroutine(NormalChat("�ػ���", "..."));
            wCandy.sprite = wCottonCandy[5];
            yield return StartCoroutine(NormalChat("�ػ���", "��.. �װ� �׷��� �ٽ� ���ư� ����� �������?"));
            worm.sprite = worms[0];
            yield return StartCoroutine(NormalChat("�������", "���? ��~"));
            worm.sprite = worms[1];
            yield return StartCoroutine(NormalChat("�������", "�ִµ� ���� ������ �Ұ�����"));
            yield return StartCoroutine(NormalChat("�ػ���", "��? ��°����?"));
            yield return StartCoroutine(NormalChat("�������", "�ٽ� Ŀ���� ������ ������ �ϴµ�\n��ᰡ ��� �������ŵ�~"));
            yield return StartCoroutine(NormalChat("�ػ���", "�׷� ����� ���°ǰ���..?"));
            worm.sprite = worms[0];
            yield return StartCoroutine(NormalChat("�������", "���� ���� �� �ƴ��� "));
            worm.sprite = worms[1];
            yield return StartCoroutine(NormalChat("�������", "�װ� ������ ��Ḧ ���ؿ��� ��!"));
            yield return StartCoroutine(NormalChat("�������", "�׷��� ������ ���� �ƴϴϱ� �ݹ� ã�� �� �����ž�"));
            wCandy.sprite = wCottonCandy[1];
            yield return StartCoroutine(NormalChat("�ػ���", "������?"));
            yield return StartCoroutine(NormalChat("�ػ���", "� ��Ḧ ���ؿ;� ����?"));
            yield return StartCoroutine(NormalChat("�������", "���� ������ ���� �ٰ� �� 3���� ��Ḹ ã�ƿ� �ָ� ��~"));
            yield return StartCoroutine(NormalChat("�ػ���", "�� �˰ھ��!"));
            wCandy.sprite = wCottonCandy[0];
            yield return StartCoroutine(NormalChat("�ػ���", "(���ѷ� ã�ƺ���)"));

            //���� �̴ϰ��� ����,

            s.instance.n = 1;

            SceneManager.LoadScene("larva_scene");

        }
        else if (s.instance.n == 1)
        {
            //������ 
            wCandy.sprite = wCottonCandy[1];
            worm.sprite = worms[0];
            yield return StartCoroutine(NormalChat("�ػ���", "��� ã�ƿԾ��!"));
            worm.sprite = worms[1];
            yield return StartCoroutine(NormalChat("�������", "�������� �ݹ� �Գ�?"));
            yield return StartCoroutine(NormalChat("�ػ���", "���� �׷� ���� �̰ɷ� Ŀ���� ������ ����� �ٰ�"));
            wCandy.sprite = wCottonCandy[6];
            worm.sprite = worms[2];
            wBack.sprite = wBackGround[4];
            yield return new WaitForSeconds(1f);
            wBack.sprite = wBackGround[3];
            worm.sprite = worms[1];
            yield return StartCoroutine(NormalChat("�������", "���� �־�~ �ٽ� Ŀ���� ����!"));
            wBack.sprite = wBackGround[2];
            wCandy.sprite = wCottonCandy[4];
            yield return StartCoroutine(NormalChat("�ػ���", "�����մϴ� �ֹ�����!"));
            yield return StartCoroutine(NormalChat("�������", "��Ȯ���� �����������"));
            yield return StartCoroutine(NormalChat("�������", "�̷����� �ƴ���!"));
            yield return StartCoroutine(NormalChat("�������", "� ������ ���ð� ��Ʈ������ �ִ� ������ ������"));
            yield return StartCoroutine(NormalChat("�������", "���� ���� �ߵ��󰡸� ü�Ű���̰� ��� ����� ���� ���ðž�\n�� ���̿��� �� ���� ����� �ɰŶ���"));
            yield return StartCoroutine(NormalChat("�������", "�߰�~ ���� �ư���"));
            yield return StartCoroutine(NormalChat("�ػ���", "�ȳ��� �輼�� ���������!"));
            worm.sprite = worms[2];
            wCandy.sprite = wCottonCandy[0];
            audio.clip = Sound[0];
            audio.Play();
            yield return StartCoroutine(NormalChat("�ػ���", "(�ܲ�)"));
            wCandy.sprite = wCottonCandy[6];
            wBack.sprite = wBackGround[4];
            audio.clip = Sound[1];
            audio.Play();
            yield return new WaitForSeconds(2f);
            wBack.sprite = wBackGround[0];
            wCandy.sprite = wCottonCandy[3];
            yield return StartCoroutine(NormalChat("�ػ���", "���� �Դ�...!"));
            wCandy.sprite = wCottonCandy[1];
            yield return StartCoroutine(NormalChat("�ػ���", "�׷�... ����..."));
            yield return StartCoroutine(NormalChat("�ػ���", "�и� ���� ���� ���󰡴�\nü�� ����̿��� ���� �� ����� �ϼ̾���?"));
            yield return StartCoroutine(NormalChat("�ػ���", "...������!"));

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

        //ȿ��
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
    void scenemove() // Invoke �� �������� ���� �Լ�
    {
        SceneManager.LoadScene("main_proto_scene");
    }

}
