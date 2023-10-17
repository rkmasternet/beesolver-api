using BeeSolverApi.Model;
using BeeSolverApi.Repository;
using System.Linq;

namespace BeeSolverApi.BusinessLogic
{
    public class MagicCardBusinessLogic : IMagicCardBusinessLogic
    {
        private readonly IMagicCardRepository _magicCardRepository;
        public MagicCardBusinessLogic(IMagicCardRepository magicCardRepository)
        {
            _magicCardRepository = magicCardRepository;
        }
        public Task<IEnumerable<MagicCard>> GetMagicCards(CardFilter cardFilter)
        {
            //Get All Magic Cards
            var allCards =_magicCardRepository.GetAllMagicCards().Result.Cards;

            //filter card data
            var filteredData = allCards
                .Where(
                    x=>
                    (string.IsNullOrEmpty(cardFilter.Name) || x.Name == cardFilter.Name) &&
                    (string.IsNullOrEmpty(cardFilter.Color) || x.Colors.Contains(cardFilter.Color)) &&
                    (string.IsNullOrEmpty(cardFilter.Type) || x.Type == cardFilter.Type)
                    );

            return Task.FromResult(filteredData);
        }
    }
}
