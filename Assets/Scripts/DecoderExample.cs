using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoderExample : MonoBehaviour {
    void Start() {
        Debug.Log(AnimalType.CAT + " goes " + AnimalDecoder.LoadDetails(AnimalType.CAT).Noise);
        Debug.Log(AnimalType.DOG + " goes " + AnimalDecoder.LoadDetails(AnimalType.DOG).Noise);
    }
}
