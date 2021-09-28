using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Releases")]
public class ReleasesAsset : ScriptableObject
{

    [SerializeField]
    private List<Release> releases = new List<Release>();
}
