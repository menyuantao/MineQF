using QFramework;
using UnityEngine;

public class PlayerControl : AbstractCommand
{
    private int mfootnum;
    protected override void OnExecute()
    {
        mfootnum = this.GetModel<Model>().FootNum;
        Debug.Log("人物移动一格！"+ mfootnum);
        this.GetModel<Model>().FootNum++;
    }
}
