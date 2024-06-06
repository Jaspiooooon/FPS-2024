using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponModel",menuName = "Armas")]
public class WeaponModel : ScriptableObject
{
    [SerializeField] float damage;
    [SerializeField] float range;
    [SerializeField] float fireRate;
    [SerializeField] float spread;
    [SerializeField] float reloadTime;
    [SerializeField] float timeBetweenShoots;
    [SerializeField] int magazineCap;
    [SerializeField] int bulletsForShoot;
    [SerializeField] bool automatic;
    [SerializeField] bool scope;
    [SerializeField] Mesh model;
    [SerializeField] Material material;
    [SerializeField] Vector3 weaponPosition;
}
