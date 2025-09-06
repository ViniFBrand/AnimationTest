using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class VinUtil
{
    #region RANDOMIZERS
    //Randomize GameObject from List
    public static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }

    //Randomize GameObject fro Array
    public static T GetRandom<T>(this T[] array)
    {
        if(array.Length == 0)
            return default(T);

        return array[Random.Range(0, array.Length)];
    }

    public static T GetRandomButNotSame<T>(this List<T> list, T unique)
    {
        if (list.Count == 1)
            return unique;

        int randomIndex = Random.Range(0, list.Count);
        return list[randomIndex];
    }

    #endregion
}
