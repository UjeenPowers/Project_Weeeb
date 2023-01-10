using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using SimpleFileBrowser;
using System.Threading.Tasks;
using System;

public class ObjectSelector : UIElement
{
    private TMP_InputField FieldName;
    private TMP_InputField FieldX;
    private TMP_InputField FieldY;
    private UserImage CurrentImage;
    public override void Init(GameObject gameObject)
    {
        FieldName = gameObject.transform.Find("FieldName").GetComponent<TMP_InputField>();
        FieldX = gameObject.transform.Find("FieldX").GetComponent<TMP_InputField>();
        FieldY = gameObject.transform.Find("FieldY").GetComponent<TMP_InputField>();
        gameObject.transform.Find("ChangeImage").GetComponent<EasyButton>().OnButtonClick += OnChangeButtonClick;
        gameObject.transform.Find("RemoveImage").GetComponent<EasyButton>().OnButtonClick += OnRemoveButtonClick;
    }

    public void ChangeSelectedObject(UserImage image)
    {
        CurrentImage = image;
        FieldName.SetTextWithoutNotify(image.UserGivenName);
        FieldX.SetTextWithoutNotify(image.Pos.x.ToString());
        FieldY.SetTextWithoutNotify(image.Pos.y.ToString());
        image.OnPosChanged += RedrawFields;

        //TODO: figure out better way of working with TMP_InputField, probably with Adapter
        FieldX.onEndEdit.AddListener(ChangePos);
        FieldY.onEndEdit.AddListener(ChangePos);
    }

    private void ChangePos(string text)
    {
        try
        {
            float x = float.Parse(FieldX.text);
            float y = float.Parse(FieldY.text);

            CurrentImage.ChangePos(new Vector2(x,y));
        }
        catch (FormatException e)
        {
            Debug.Log("Wrong format for position");
        }
    }

    private void RedrawFields(Vector2 pos)
    {
        
    }

    private void OnChangeButtonClick()
    {
        if (CurrentImage != null)
        ShowLoadDialog();
    }

    private async void ShowLoadDialog()
    {
        Task<string> t1 = FileDialogWrapper.instance.GetLoadPath();
        string name = await t1;
        CurrentImage.ChangeImage(name);
    }

    private void OnRemoveButtonClick()
    {   
        FieldName.SetTextWithoutNotify("Null");
        CurrentImage.Kill();
    }
}
