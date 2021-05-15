using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalDecoder : JsonDecoder<AnimalType, AnimalDetails> {
    public static AnimalDecoder instance;

    public static AnimalDetails LoadDetails(AnimalType AnimalType) {
        if (instance == null) {
            instance = new AnimalDecoder();
        }
        AnimalDetails details = instance.Load(AnimalType);
        if (details == null) {
            return new AnimalDetails();
        }
        return details;
    }

    protected override string GetJsonFileName() {
        return "Animals";
    }

    private AnimalDecoder() {
    }
}
