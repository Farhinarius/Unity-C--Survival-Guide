using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    protected static int weaponCount = 0;
    protected int weaponID;

    [SerializeField]
    protected int baseDamage;
    [SerializeField]
    protected int spread;
    [SerializeField]
    protected int speed;
    
    public Weapon(int baseDamage, int spread, int speed)
    {
        weaponCount += 1;
        this.weaponID = weaponCount;
        this.baseDamage = baseDamage;
        this.spread = spread;
        this.speed = speed;
    }
    
    public virtual void GetData()
    {
            Debug.Log($" WPNCNT: {weaponCount} \n ID: {weaponID} \n DMG: {baseDamage} \n SPR: {spread} \n SPD: {speed} \n");
    }
}

[System.Serializable]
public class AssaultRifle : Weapon
{
    private int modifiedDamage;

    public AssaultRifle(int modifiedDamage, int baseDamage, int spread, int speed) : base(baseDamage, spread, speed)
    {
        this.modifiedDamage = modifiedDamage;
    }

    public override void GetData()
    {
       base.GetData(); 
       Debug.Log($"MODDMG: {modifiedDamage}");
    }

}