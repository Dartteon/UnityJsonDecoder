using System;
using UnityEngine;

// Holds all the details of a particular species of animal
[Serializable]
public class AnimalDetails : JsonDetails<AnimalType> {
    public string AnimalTypeStr;
    public string Noise;

    public AnimalType AnimalType;

    public override void Init() {
        try {
            AnimalType = (AnimalType)Enum.Parse(typeof(AnimalType), AnimalTypeStr);
        } catch (Exception e) {
            Debug.LogError("Failed to parse CombatStageEnum for [" + AnimalTypeStr + "]\n" + e);
        }
    }

    public override AnimalType GetEnumCode() {
        return AnimalType;
    }
}
