namespace EldenRingSaveCopier.Saves.Model
{
    public interface ISaveGame
    {
        Guid Id { get; }
        string CharacterName { get; }
    }
}
