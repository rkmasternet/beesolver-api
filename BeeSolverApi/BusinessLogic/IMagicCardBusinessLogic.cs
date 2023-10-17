using System.Collections.Generic;
using BeeSolverApi.Model;


namespace BeeSolverApi.BusinessLogic
{
    public interface IMagicCardBusinessLogic
    {
        Task<IEnumerable<MagicCard>> GetMagicCards(CardFilter cardFilter);
    }
}
