using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class story : MonoBehaviour
{
    public Text ChatText;//����
    public Text CharacterName;//����
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
        yield return StartCoroutine(NormalChat("�ػ���", "..."));
        audio.clip = Sound[0];
        audio.Play();
        yield return StartCoroutine(NormalChat("�ػ���", "(�ȶ� �ȶ�)"));
        csSprite.sprite = Chats[0];
        yield return StartCoroutine(NormalChat("�ػ���", "�ɽ���..."));
        yield return StartCoroutine(NormalChat("�ػ���", "�� å�� �̹� ������ �о ���Ⱦ�..."));
        yield return StartCoroutine(NormalChat("�ػ���", "�̻��� ������ �ٸ���... �����ϴ� �Ҽ�������..\n�ᱹ ���ǿ��� �Ͼ�� ���� �̾߱� �ݾ�?"));
        yield return StartCoroutine(NormalChat("�ػ���", "���� ���� �� å�� ������ �ٸ��� ó�� \n�̻��� ����� ���� �Ǹ� ���ھ�..."));
        csSprite.sprite = Chats[2];
        yield return StartCoroutine(NormalChat("�ػ���", "�׷� ��� ������ �� ������ ��Ȱ���ٴ� ��̰���..."));
        csSprite.sprite = Chats[0];
        yield return StartCoroutine(NormalChat("�ػ���", "��?"));
        oBgd.sprite = Bgd[1];
        csSprite.sprite = Chats[5];
        //yield return StartCoroutine(NormalChat(" ", " "));

        while (!Input.GetMouseButtonDown(0))
        {
            yield return null;
        }

        yield return StartCoroutine(NormalChat("�ػ���", "�䳢..."));
        yield return StartCoroutine(NormalChat("�ػ���", "�ð踦 ��� ���ݾ�?"));
        yield return StartCoroutine(NormalChat("�ػ���", "������ �ִ� �䳢�� �ɱ�.."));
        yield return StartCoroutine(NormalChat("�䳢", "(Ÿ�ٴ�)"));
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
        yield return StartCoroutine(NormalChat("�ػ���", "��..! ��� �䳢��!"));
        oBgd.sprite = Bgd[0];
        csSprite.sprite = Chats[4];
        yield return StartCoroutine(NormalChat("�ػ���", "�������� �޷��� ���Ⱦ�..."));
        csSprite.sprite = Chats[1];
        yield return StartCoroutine(NormalChat("�ػ���", "......"));
        csSprite.sprite = Chats[0];
        yield return StartCoroutine(NormalChat("�ػ���", "���� ���� �ϳ�...?"));
        yield return StartCoroutine(NormalChat("�ػ���", "������ �ִ� �䳢��� ������ ã�� ��� �ϴϱ�..."));
        yield return StartCoroutine(NormalChat("�ػ���", "��... ���� ����"));
        oBgd.sprite = Bgd[2];
        csSprite.sprite = Chats[4];
        yield return StartCoroutine(NormalChat("�ػ���", "�и� �������� ���µ�...\n���� ���� �ɱ�..."));
        yield return StartCoroutine(NormalChat("�ػ���", "��¿ �� ����... ���ư��� �� �ۿ�..."));
        yield return StartCoroutine(NormalChat("�ػ���", "..."));
        csSprite.sprite = Chats[0];
        yield return StartCoroutine(NormalChat("�ػ���", "���...?"));
        yield return StartCoroutine(NormalChat("�ػ���", "���� ������ �ʾ�..."));
        audio.clip = Sound[2];
        audio.Play();
        yield return StartCoroutine(NormalChat("", "(¸�׶�!)"));
        csSprite.sprite = Chats[3];
        yield return StartCoroutine(NormalChat("�ػ���", "��� �� �Ҹ� ����?"));
        yield return StartCoroutine(NormalChat("�ػ���", "���ʿ��� �� �� ���� ������..!"));
        
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

        //ȿ��
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
