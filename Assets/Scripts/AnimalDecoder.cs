public class AnimalDecoder : JsonDecoder<AnimalSpecies, AnimalDetails> {
    public static AnimalDecoder instance;

    public static AnimalDetails LoadDetails(AnimalSpecies animalSpecies) {
        if (instance == null) {
            instance = new AnimalDecoder();
        }
        AnimalDetails details = instance.Load(animalSpecies);
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
