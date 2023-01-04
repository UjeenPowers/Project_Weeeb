using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleFileBrowser;
using System.IO;
using System.Threading.Tasks;
using System.Text;

public class FileDialogWrapper : MonoBehaviour
{
    public static FileDialogWrapper instance;
    void Start()
    {
        instance = this;
        FileBrowser.SetFilters( true, new FileBrowser.Filter( "Images", ".jpg", ".png" ));
        FileBrowser.SetDefaultFilter( ".png" );
    }

    public Task<string> StartDialog()
    {
        Task<string> t1 = new Task<string>( ()=>
        {
            //ebug.Log(FileBrowser.Result[0]);
            return FileBrowser.Result[0];
        });
        StartCoroutine(ShowLoadDialogCoroutine(t1));
        return t1;
    }

    

    IEnumerator ShowLoadDialogCoroutine(Task t1)
	{
		yield return FileBrowser.WaitForLoadDialog( FileBrowser.PickMode.FilesAndFolders, false, null, null, "Load Files and Folders", "Load" );
        //FileBrowserHelpers.ReadBytesFromFile(FileBrowser.Result[0]);

		if( FileBrowser.Success )
		{
            t1.Start();
		}
	}
}
