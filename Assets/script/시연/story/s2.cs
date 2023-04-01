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
            yield return StartCoroutine(NormalChat("�ػ���", "�и� ���ʿ��� �Ҹ��� ������.."));
            Rabbit.sprite = ClockRabbit[2];
            yield return StartCoroutine(NormalChat("�ð��䳢", "....�̷� �̷��� ��� �ð��� �ʾ������ ���ھ��"));
            Candy.sprite = CottonCandy[2];
            yield return StartCoroutine(NormalChat("�ػ���", "���..?"));
            Rabbit.sprite = ClockRabbit[3];
            yield return StartCoroutine(NormalChat("�ð��䳢", "...!"));
            Rabbit.sprite = ClockRabbit[1];
            yield return StartCoroutine(NormalChat("�ð��䳢", "��.. �Ʊ ����� �̷α���\n���� �ص�� �˼��մϴ�"));
            Candy.sprite = CottonCandy[0];
            yield return StartCoroutine(NormalChat("�ػ���", "�Ʊ... �̶��?"));
            Rabbit.sprite = ClockRabbit[1];
            yield return StartCoroutine(NormalChat("�ð��䳢", "�Ʊ� ����е� �� ���� �����̳���?"));
            yield return StartCoroutine(NormalChat("�ð��䳢", "��� �䳢��... ��� ������̴� �� ������"));
            Candy.sprite = CottonCandy[2];
            yield return StartCoroutine(NormalChat("�ػ���", "����� �Ʊ� �� �䳢 ����?"));
            Rabbit.sprite = ClockRabbit[1];
            yield return StartCoroutine(NormalChat("�ð��䳢", "�� �׷��� ���ô�..."));
            Rabbit.sprite = ClockRabbit[3];
            yield return StartCoroutine(NormalChat("�ð��䳢", "��..! ���� ����� �̰��� �ֹ��� �ƴϽ� �ǰ���?"));
            Candy.sprite = CottonCandy[3];
            yield return StartCoroutine(NormalChat("�ػ���", "�̰�...?"));
            Rabbit.sprite = ClockRabbit[1];
            yield return StartCoroutine(NormalChat("�ð��䳢", "�� ���� �̻��� ������ ���� �Դϴ�"));
            yield return StartCoroutine(NormalChat("�ð��䳢", "�츮���� �ֹε��� �ۿ����� ������ ���������\n�̻��� ������ ���� �ȿ����� �ΰ��� ����� �ϰ� ����"));
            Candy.sprite = CottonCandy[2];
            yield return StartCoroutine(NormalChat("�ػ���", "�̻��� ���� ����...?"));
            yield return StartCoroutine(NormalChat("�ػ���", "� ���� ���ư��� �ϴµ�..."));
            Rabbit.sprite = ClockRabbit[2];
            yield return StartCoroutine(NormalChat("�ð��䳢", "���͵帮�� ���� ������ ���� ������..."));
            yield return StartCoroutine(NormalChat("�ð��䳢", "�� ���� ����� ��Ȳ�̶�\n���͵帮�� ���� �� ���׿�..."));
            Candy.sprite = CottonCandy[0];
            yield return StartCoroutine(NormalChat("�ػ���", "����� ��Ȳ�̿�..?"));
            Rabbit.sprite = ClockRabbit[2];
            yield return StartCoroutine(NormalChat("�ð��䳢", "��... ��� �Ǽ��� �ð踦 ���� Ʈ���� �ٶ���\n���մԲ� ���� ������ �ð谡 �ν��� ������ ���Ҿ��.."));
            Candy.sprite = CottonCandy[1];
            yield return StartCoroutine(NormalChat("�ػ���", "(��... �Ʊ� �� �Ҹ���...)"));
            Rabbit.sprite = ClockRabbit[2];
            yield return StartCoroutine(NormalChat("�ð��䳢", "���� ���մ԰��� ����� �־� ������ ���� ���ε�...\n�ð谡 �μ��� �� �ƽø� �и� ũ�� ȭ���ð���..."));
            Candy.sprite = CottonCandy[1];
            yield return StartCoroutine(NormalChat("�ػ���", "(...������ �ν����� ���� �ʰ� ������ �ϸ� �ɰ� ������...)"));
            Candy.sprite = CottonCandy[0];
            yield return StartCoroutine(NormalChat("�ػ���", "����... �� �ð� ���� ��ĥ �� ���� �� ���ƿ�"));
            Rabbit.sprite = ClockRabbit[3];
            yield return StartCoroutine(NormalChat("�ð��䳢", "�װ� ���� �ΰ���?"));
            Candy.sprite = CottonCandy[0];
            yield return StartCoroutine(NormalChat("�ػ���", "�� �����̶�� �ڽ� �־��"));
            Rabbit.sprite = ClockRabbit[4];
            yield return StartCoroutine(NormalChat("�ð��䳢", "���� �����մϴ�... �׷��ϱ� ������?"));
            Candy.sprite = CottonCandy[0];
            yield return StartCoroutine(NormalChat("�ػ���", "�ػ����̿���"));
            Rabbit.sprite = ClockRabbit[4];
            yield return StartCoroutine(NormalChat("�ð��䳢", "�ػ��� �̷α��� ���� �ð� �䳢��� �մϴ�"));
            yield return StartCoroutine(NormalChat("�ð��䳢", "�׷� �� �ð踦 ��Ź�帱�Կ�"));

            //���� �̴ϰ��� ����,

            SceneManager.LoadScene("si yeon");

        }
        else if (s.instance.n == 1)
        {
            
            //������ 
            Rabbit.sprite = ClockRabbit[0];
            Candy.sprite = CottonCandy[4];
            yield return StartCoroutine(NormalChat("�ػ���", "�ƾ��..! �� �۵��� �ϰ�..."));
            Rabbit.sprite = ClockRabbit[3];
            yield return StartCoroutine(NormalChat("�ð��䳢", "���� ��ġ�̱���!"));
            Rabbit.sprite = ClockRabbit[4];
            yield return StartCoroutine(NormalChat("�ð��䳢", "���� �����̿��� �̰ɷ� ���մ԰��� ��ӿ���\n���� ���� �� �ְھ��..."));
            yield return StartCoroutine(NormalChat("�ð��䳢", "����� ���縦 ����� ����..."));
            Rabbit.sprite = ClockRabbit[1];
            yield return StartCoroutine(NormalChat("�ð��䳢", "�� �׷��� ���� ���ư� ����� ã�� ��ô� ����?"));
            Candy.sprite = CottonCandy[0];
            yield return StartCoroutine(NormalChat("�ػ���", "�¾ƿ�.. Ȥ�� ����� �ƽó���?"));
            Back.sprite = BackGround[1];
            Rabbit.sprite = ClockRabbit[1];
            yield return StartCoroutine(NormalChat("�ð��䳢", "�� �̻��� ���󿡼� ������ �������� ������ ����\n�ָ� ������ �ִ� ��Ʈ �����ΰ��� ��Ʈ������ ����� �޾ƾ� �ؿ�"));
            Candy.sprite = CottonCandy[3];
            yield return StartCoroutine(NormalChat("�ػ���", "���մ��� ����̿�..?"));
            Rabbit.sprite = ClockRabbit[4];
            yield return StartCoroutine(NormalChat("�ð��䳢", "��.. ���մ��� ���� ���ϱ� ��ٷο� ��������\n��� �Ľô� ��и� �� ���� �帮�� �ݹ� ����� �ֽǰſ���"));
            yield return StartCoroutine(NormalChat("�ð��䳢", "�ʹ� �������� �����ŵ� �˴ϴ�"));
            Candy.sprite = CottonCandy[0];
            yield return StartCoroutine(NormalChat("�ػ���", "�׷��ٸ�� ���� �Ƚ��� �ǳ׿�"));
            Rabbit.sprite = ClockRabbit[3];
            yield return StartCoroutine(NormalChat("�ð��䳢", "�̷�! �ð��� ���� �̷���..."));
            yield return StartCoroutine(NormalChat("�ð��䳢", "���� �� �ʱ����� ������ �� �� ���׿�"));
            Rabbit.sprite = ClockRabbit[4];
            yield return StartCoroutine(NormalChat("�ð��䳢", "�� �ֺ����� �̻��ѳ����� �ֹε��� ������\n�׵鿡�� ���� ����� �ɰſ���"));
            yield return StartCoroutine(NormalChat("�ð��䳢", "�׷� ������ ��ȸ�� �ȴٸ� �ٽ� ����"));
            Candy.sprite = CottonCandy[4];
            yield return StartCoroutine(NormalChat("�ػ���", "�� �����մϴ�..! ������ ��ȸ�� �ȴٸ� �ƿ� �ð��䳢��"));

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

        //ȿ��
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



