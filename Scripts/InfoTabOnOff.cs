using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InfoTabOnOff : MonoBehaviour
{


    public Image BlackBackGround;

    //title Turn Off/On
    public Image npcTitlePlaceHolder;
    public Image characterTitlePlaceHolder;

    // NPC Next Button Turn Off/On
    public Button npcNextButton;
    public TMP_Text textNpcNextText;
    public Image ImageNpcNextImage;

    // Character Next Button Turn Off/On
    public Button characterNextButton;
    public TMP_Text textCharacterNextText;
    public Image ImageCharacterNextImage;

    // NPC Prev Button Turn Off/On
    public Button npcPreviousButton;
    public TMP_Text textNpcPreviousText;
    public Image ImageNpcPrevImage;

    // Character Prev Button Turn Off/On
    public Button characterPreviousButton;
    public TMP_Text textCharacterPreviousText;
    public Image ImageCharacterPrevImage;

    //PlaceHolder Turn Off/On
    public Text npcDisplayerHolder;
    public Text npcNameHolder;
    public Text npcInfoNameHolder;

    //Sprite Turn Off/On 
    public SpriteRenderer selectedNPCHolder;


    void Start()
    {
        characterTitlePlaceHolder.enabled = false;
        characterNextButton.enabled= false;
        textCharacterNextText.enabled= false;
        ImageCharacterNextImage.enabled= false;
        ImageCharacterPrevImage.enabled= false;
        textCharacterPreviousText.enabled= false;
        characterPreviousButton.enabled= false;
    }
    public void is_Characters_Info_Visable()
    {
        BlackBackGround.enabled = false;
        npcTitlePlaceHolder.enabled = false;
        ImageNpcNextImage.enabled = false;
        ImageNpcPrevImage.enabled = false;
        textNpcNextText.enabled = false;
        textNpcPreviousText.enabled = false;
        npcNextButton.enabled = false;
        npcPreviousButton.enabled = false;
        npcDisplayerHolder.enabled = false;
        npcNameHolder.enabled = false;
        npcInfoNameHolder.enabled = false;
        selectedNPCHolder.enabled = false;

        BlackBackGround.enabled = true;
        characterTitlePlaceHolder.enabled = true;
        characterNextButton.enabled = true;
        textCharacterNextText.enabled = true;
        ImageCharacterNextImage.enabled = true;
        ImageCharacterPrevImage.enabled = true;
        textCharacterPreviousText.enabled = true;
        characterPreviousButton.enabled = true;
    }

    public void is_NPC_INFO_Visable()
    {
        BlackBackGround.enabled = true;
        npcTitlePlaceHolder.enabled = true;
        ImageNpcNextImage.enabled = true;
        ImageNpcPrevImage.enabled = true;
        textNpcNextText.enabled = true;
        textNpcPreviousText.enabled = true;
        npcNextButton.enabled = true;
        npcPreviousButton.enabled = true;
        npcDisplayerHolder.enabled = true;
        npcNameHolder.enabled = true;
        npcInfoNameHolder.enabled = true;
        selectedNPCHolder.enabled = true;

        characterTitlePlaceHolder.enabled = false;
        characterNextButton.enabled = false;
        textCharacterNextText.enabled = false;
        ImageCharacterNextImage.enabled = false;
        ImageCharacterPrevImage.enabled = false;
        textCharacterPreviousText.enabled = false;
        characterPreviousButton.enabled = false;
    }
}
