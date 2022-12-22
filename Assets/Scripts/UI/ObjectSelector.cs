using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using SimpleFileBrowser;
using System.Threading.Tasks;

public class ObjectSelector : UIElement
{
    private TMP_InputField Field;
    private UserImage CurrentImage;
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
        if (CurrentImage != null)
        ShowLoadDialog();
    }

    private async void ShowLoadDialog()
    {
        Task<string> t1 = FileDialogWrapper.instance.StartDialog();
        string name = await t1;
        //Debug.Log(name);
        CurrentImage.ChangeImage(name);
    }

    private void OnRemoveButtonClick()
    {   
        Field.SetTextWithoutNotify("Null");
        CurrentImage.Kill();
    }
}
