using System;

// Holds all the details of a particular species of animal
[Serializable]
public class AnimalDetails : JsonDetails<AnimalSpecies> {
    public AnimalSpecies AnimalSpecies;
    public string Noise;

    public override AnimalSpecies GetEnumCode() {
        return AnimalSpecies;
    }
}
