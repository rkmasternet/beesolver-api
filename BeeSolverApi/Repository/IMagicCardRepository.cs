using BeeSolverApi.Model;

namespace BeeSolverApi.Repository
{
    public interface IMagicCardRepository
    {
        Task<CardDetails> GetAllMagicCards();
    }
}
