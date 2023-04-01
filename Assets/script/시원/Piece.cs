using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(SpriteRenderer))]
//GetComponent�� �Ҷ� null�� ���ü��� ����
public class Piece : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    public GameObject clear;

    public static Piece selected_obj;
    
    public Vector2Int index_pos;
    public Vector2Int go_pos;
    
    float between;


    Vector2[] dir = new Vector2[4];
    Vector3 mouse_pos;

    

    public void OnDrag(PointerEventData eventData)
    {
        // selected_obj�� null�� �ƴҋ���
        if (selected_obj)
        {
            if (!GameManager.Instance.pieces[index_pos.x, index_pos.y + 1 == 4 ? 3 : index_pos.y + 1] || !GameManager.Instance.pieces[index_pos.x, index_pos.y - 1 == -1 ? 0 : index_pos.y - 1])
            {
                selected_obj.transform.position = new Vector3(selected_obj.transform.position.x, mouse_pos.y, selected_obj.transform.position.z);
            }
            else if (!GameManager.Instance.pieces[index_pos.x == 2 ? 2 : index_pos.x + 1, index_pos.y] || !GameManager.Instance.pieces[index_pos.x == 0 ? 0 : index_pos.x - 1, index_pos.y])
            {
                selected_obj.transform.position = new Vector3(mouse_pos.x, selected_obj.transform.position.y, selected_obj.transform.position.z);
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // ���콺�� ���������� selected_obj�� �ڽ��� ������ ���� ( static ���� )
        selected_obj = this;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // pos -> �ڽ��� ��ġ ��ǥ
        Vector2 pos = new Vector2(index_pos.x * between - 274, index_pos.y * -between + 388);
        // now -> UI ��ǥ
        Vector2 now = GetComponent<RectTransform>().anchoredPosition;

        // pos -> now �Ÿ�
        // ���� �Ҵ� X
        float temp, pos2now;

        // ���� ��ġ ( pos )  ���콺�� �����̴� ��ġ ( now ) ���ߵǴ� ��ġ ( temp )

        for (int i = 0; i < 4; i++)
        {
            pos2now = Vector2.Distance(pos, dir[i]);
            temp = Vector2.Distance(now, dir[i]);

            // +, - �ϱ� �� ��ġ�� null��
            GameManager.Instance.pieces[index_pos.x, index_pos.y] = null;

            if (pos2now > temp)
            {
                switch (i)
                {
                    case 0:
                        if (index_pos.x + 1 < 3 && !GameManager.Instance.pieces[index_pos.x + 1, index_pos.y])
                            index_pos.x++;
                        break;
                    case 1:
                        if (index_pos.x - 1 > -1 && !GameManager.Instance.pieces[index_pos.x - 1, index_pos.y])
                            index_pos.x--;
                        break;
                    case 2:
                        if (index_pos.y - 1 > -1 && !GameManager.Instance.pieces[index_pos.x, index_pos.y - 1])
                            index_pos.y--;
                        break;
                    case 3:
                        if (index_pos.y + 1 < 4 && !GameManager.Instance.pieces[index_pos.x, index_pos.y + 1])
                            index_pos.y++;
                        break;
                }
            }

            // +, - �� ��ġ���� �ڽ�( this )�� ����
            GameManager.Instance.pieces[index_pos.x, index_pos.y] = this;
        }

        pos = new Vector2(index_pos.x * between - 274, index_pos.y * -between + 388);

        dir[0] = pos + new Vector2(between, 0);
        dir[1] = pos + new Vector2(-between, 0);
        dir[2] = pos + new Vector2(0, between);
        dir[3] = pos + new Vector2(0, -between);

        // UI�� ��ġ�� �ٲ� ��ġ�� ����
        GetComponent<RectTransform>().anchoredPosition = pos;
        // Up�̱� ������ ������ ������
        selected_obj = null;
        if (GameManager.Instance.Check())
        {
            Debug.Log("Ŭ����");
            clearmove();
            Invoke("end", 1f);
            GameManager.Instance.clear.color = new Color(1, 1, 1, 1);

            GameManager.Instance.clearsound = new AudioSource();

        }
    }
    
    private void Start()
    {
        clear.SetActive(false);

        between = GameManager.Instance.between_val;

        // �ڽ��� �־�� �Ǵ� ��ġ ����
        Vector2 pos = new Vector2(index_pos.x * between - 274, index_pos.y * -between + 388);
        dir[0] = pos + new Vector2(between, 0);
        dir[1] = pos + new Vector2(-between, 0);
        dir[2] = pos + new Vector2(0, between);
        dir[3] = pos + new Vector2(0, -between);

        // ������ ������ ��ġ ������ UI��ġ�� ����
        GetComponent<RectTransform>().anchoredPosition = pos;

        // GameManager�� �ִ� pieces 2���� �迭�� �ڽ��� ��ġ�� �ڽ��� ���� �Ҵ�
        GameManager.Instance.pieces[index_pos.x, index_pos.y] = this;
    }
    void Update()
    {
        name = $"{index_pos.x}/{index_pos.y}";
        mouse_pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
        if (selected_obj && gameObject != selected_obj.gameObject)
        {
            GetComponent<RectTransform>().anchoredPosition = new Vector2(index_pos.x * between - 274, index_pos.y * -between + 388);
        }
        
    }
   void clearmove()
    {
        clear.SetActive(true);
    }
    void end()
    {
        s.instance.n = 1;
        SceneManager.LoadScene("cat story");
    }
}

