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

    //Randomize GameObject from Array
    public static T GetRandom<T>(this T[] array)
    {
        if(array.Length == 0)
            return default(T);

        return array[Random.Range(0, array.Length)];
    }

    //Randomize GameObject from List but return an object that is different from the one selected
    public static T GetRandomButNotSame<T>(this List<T> list, T unique)
    {
        if (list.Count == 1)
            return unique;

        int randomIndex = Random.Range(0, list.Count);
        return list[randomIndex];
    }

    #endregion
}
