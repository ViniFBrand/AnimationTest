using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.SceneManagement;
using UnityEngine;
using Random = UnityEngine.Random;

public static class VinUtil
{

#if UNITY_EDITOR

    private static Vector3 positionParticle = new Vector3(0, 1.7f, 5.66f);
    [UnityEditor.MenuItem("Vin/Particle Test %g ")]

    public static void ParticleTest()
    {
        ParticleSystem particleSystemPrefab = Resources.Load<ParticleSystem>("Particle_Balls");
        particleSystemPrefab.transform.position = positionParticle;

        if (particleSystemPrefab != null && Application.isPlaying)
        {
            //var particle = Object.Instantiate(particleSystemPrefab, positionParticle, Quaternion.identity);
            var particle = GameObject.Instantiate(particleSystemPrefab);
            particle.Play();
            GameObject.Destroy(particle, 2f);
        }
        else
        {
            Debug.LogError("No Particle System found in Resources folder or Application isn't running");
        }
    }
#endif

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
