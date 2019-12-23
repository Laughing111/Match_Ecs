
using UnityEngine;

public class MathUtils
{
    /// <summary>
    /// 计算是否生成障碍物
    /// </summary>
    /// <param name="probability">百分比概率</param>
    /// <returns></returns>
    public static bool IsBlock(int probability)
    {
        return Random.Range(0, 100)<= probability;
    }
}
