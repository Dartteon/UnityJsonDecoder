using UnityEngine;

public class DecoderExample : MonoBehaviour {
    void Start() {
        string catNoise = AnimalDecoder.LoadDetails(AnimalSpecies.CAT).Noise;
        Debug.Log("Cat goes " + catNoise);

        string dogNoise = AnimalDecoder.LoadDetails(AnimalSpecies.DOG).Noise;
        Debug.Log("Dog goes " + dogNoise);
    }
}
