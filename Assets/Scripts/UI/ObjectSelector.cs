using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using SimpleFileBrowser;

public class ObjectSelector : UIElement
{
    private TMP_InputField Field;
    private UserImage CurrentImage;
    // private EasyButton ChangeButton;
    // private EasyButton RemoveButton;
    public override void Init(GameObject gameObject)
    {
        Field = gameObject.transform.Find("Field").GetComponent<TMP_InputField>();
        gameObject.transform.Find("ChangeImage").GetComponent<EasyButton>().OnButtonClick += OnChangeButtonClick;
        gameObject.transform.Find("RemoveImage").GetComponent<EasyButton>().OnButtonClick += OnRemoveButtonClick;
    }

    public void ChangeSelectedObject(UserImage image)
    {
        CurrentImage = image;
        Field.SetTextWithoutNotify(image.UserGivenName);
    }

    private void OnChangeButtonClick()
    {
        FileBrowser.SetDefaultFilter( ".png" );
        //StartCoroutine( ShowLoadDialogCoroutine() );
    }

    private void ShowLoadDialog()
    {
        //TODO: finish load dialog integration
    }

    private void OnRemoveButtonClick()
    {   
        Field.SetTextWithoutNotify("Null");
        CurrentImage.Kill();
    }
}
