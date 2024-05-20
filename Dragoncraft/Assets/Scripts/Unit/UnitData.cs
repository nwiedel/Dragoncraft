using UnityEngine;

namespace Dragoncraft
{
[CreateAssetMenu(menuName = "Dragoncraft/New Unit")]
    public class UnitData : ScriptableObject
    {
        public UnitType Type;
        public int Level;
        public float LevelMultiplyer;
        public float Health;
        public float Attac;
        public float Defense;
        public float WalkSpeed;
        public float AttackSpeed;
    }
}
