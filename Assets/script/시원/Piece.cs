using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(SpriteRenderer))]
//GetComponent를 할때 null이 나올수가 없음
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
        // selected_obj가 null이 아닐떄에
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
        // 마우스를 눌렀을때에 selected_obj에 자신의 정보를 담음 ( static 변수 )
        selected_obj = this;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // pos -> 자신의 위치 좌표
        Vector2 pos = new Vector2(index_pos.x * between - 274, index_pos.y * -between + 388);
        // now -> UI 좌표
        Vector2 now = GetComponent<RectTransform>().anchoredPosition;

        // pos -> now 거리
        // 아직 할당 X
        float temp, pos2now;

        // 원래 위치 ( pos )  마우스로 움직이는 위치 ( now ) 가야되는 위치 ( temp )

        for (int i = 0; i < 4; i++)
        {
            pos2now = Vector2.Distance(pos, dir[i]);
            temp = Vector2.Distance(now, dir[i]);

            // +, - 하기 전 위치는 null로
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

            // +, - 한 위치에는 자신( this )를 넣음
            GameManager.Instance.pieces[index_pos.x, index_pos.y] = this;
        }

        pos = new Vector2(index_pos.x * between - 274, index_pos.y * -between + 388);

        dir[0] = pos + new Vector2(between, 0);
        dir[1] = pos + new Vector2(-between, 0);
        dir[2] = pos + new Vector2(0, between);
        dir[3] = pos + new Vector2(0, -between);

        // UI의 위치를 바뀐 위치로 갱신
        GetComponent<RectTransform>().anchoredPosition = pos;
        // Up이기 때문에 선택을 해제함
        selected_obj = null;
        if (GameManager.Instance.Check())
        {
            Debug.Log("클리어");
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

        // 자신이 있어야 되는 위치 정보
        Vector2 pos = new Vector2(index_pos.x * between - 274, index_pos.y * -between + 388);
        dir[0] = pos + new Vector2(between, 0);
        dir[1] = pos + new Vector2(-between, 0);
        dir[2] = pos + new Vector2(0, between);
        dir[3] = pos + new Vector2(0, -between);

        // 위에서 저장한 위치 정보를 UI위치에 대입
        GetComponent<RectTransform>().anchoredPosition = pos;

        // GameManager에 있는 pieces 2차원 배열에 자신의 위치에 자신의 정보 할당
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

