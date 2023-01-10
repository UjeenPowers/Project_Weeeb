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

    public Task<string> GetLoadPath() //Returns path to image
    {
        Task<string> t1 = new Task<string>( ()=>
        {
            return FileBrowser.Result[0];
        });
        StartCoroutine(ShowLoadDialogCoroutine(t1));
        return t1;
    }

    public Task<string> GetSavePath() //Returns path for saving obj
    {
        Task<string> t1 = new Task<string>( ()=>
        {
            return FileBrowser.Result[0];
        });
        StartCoroutine(ShowLoadDialogCoroutine(t1));
        return t1;
    }

    IEnumerator ShowLoadDialogCoroutine(Task t1)
	{
		yield return FileBrowser.WaitForLoadDialog( FileBrowser.PickMode.FilesAndFolders, false, null, null, "Load Files and Folders", "Load" );
		if( FileBrowser.Success )
		{
            t1.Start();
		}
	}

    IEnumerator ShowSaveDialogCoroutine(Task t1)
	{
		yield return FileBrowser.WaitForSaveDialog( FileBrowser.PickMode.FilesAndFolders, false, null, null, "Load Files and Folders", "Load" );
		if( FileBrowser.Success )
		{
            t1.Start();
		}
	}
}
