using UnityEngine;

public class CTCharacter : MonoBehaviour
{
    [SerializeField] public CTCharacterId id;
    [SerializeField] public string displayName;
    [SerializeField] public int health;
    [SerializeField] public int energyLevel;
    [SerializeField] public int experience;

    public virtual void Spawn() { }
    public virtual void Kill() { }
    public virtual void OnDeath() { }
    public virtual void OnSpawn() { }
}
