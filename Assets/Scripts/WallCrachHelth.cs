using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCrachHelth : MonoBehaviour
{
    [SerializeField] Wallcrash[] walls;

    void Start()
    {
        var length = walls.Length;
        // 壁の一覧を取得して、壊す対象をランダムで一つ決める
        var idx = Random.Range(0, length);
        Debug.Log("破壊対象の番号:[" + idx + "]");
        
        // 壊す壁の対象に対して、壊す設定を適用する
        for (var i = 0; i < length; i++)
        {
            if (idx == i)
            {
                walls[i].AttachCrashMode();
                // 一つ決めるだけなので以降の処理はスキップする
                break;
            }
        }
    }
}
