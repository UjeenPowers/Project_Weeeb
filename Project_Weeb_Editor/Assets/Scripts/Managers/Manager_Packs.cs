using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Manager_Packs : Manager
{
    public async void SavePack()
    {
        Task<string> t1 = FileDialogWrapper.instance.GetSavePath();
        string name = await t1;
        Debug.Log($"Saved path : {name}");
    }
    private void CompilePackToZip()
    {
        
    }
}
