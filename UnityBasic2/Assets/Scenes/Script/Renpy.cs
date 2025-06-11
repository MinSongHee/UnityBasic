using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Renpy : MonoBehaviour
{
    [SerializeField] Image img_BG; // 배경
    [SerializeField] Image[] img_Character; // 캐릭터
    
    // 캐릭터 이름 : 호시노
    [SerializeField] TextMeshProUGUI txt_Name;
    // 캐릭터 타이틀 : 대책위원회
    [SerializeField] TextMeshProUGUI txt_NameTitle;
    // 대사 : 여기에 대사가 출력됩니다.
    [SerializeField] TextMeshProUGUI txt_Dialogue;

    int id = 1;

    void Start()
    {
        RefreshUI();
    }

    public void OnClickButton()
    {
        id++; // 2
        RefreshUI();
    }

    void RefreshUI()
    {
        // 대사 테이블의 1번 ID의 캐릭터 ID 컬럼을 가지고 온다.
        int characterID = SData.GetDialogueData(id).Character;
        // 캐릭터 테이블에서 캐릭터 ID에 해당하는 이름을 가지고 온다.
        txt_Name.text = SData.GetCharacterData(characterID).Name;
        // 캐릭터 테이블에서 캐릭터 ID에 타이틀을 가지고 온다.
        txt_NameTitle.text = SData.GetCharacterData(characterID).Title; 

        txt_Dialogue.text = SData.GetDialogueData(id).Dialogue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
