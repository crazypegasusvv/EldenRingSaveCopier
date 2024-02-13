namespace EldenRingSaveCopier.Saves.Model
{
    public class NullSaveGame: ISaveGame
    {
        public Guid Id
        {
            get => Guid.Empty;
        }

        public string CharacterName
        {
            get => string.Empty;
        }
    }
}
