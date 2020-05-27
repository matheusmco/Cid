using Cid.Domain.Entities;
using Cid.Domain.RepositoryContracts;
using Cid.Domain.Resources;

namespace Cid.Domain.Services
{
    public class ItemService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IComicRepository _comicRepository;
        private readonly IGameRepository _gameRepository;
        private readonly IMovieRepository _movieRepository;
        private readonly ISeriesRepository _seriesRepository;

        public ItemService(IBookRepository bookRepository, IComicRepository comicRepository, IGameRepository gameRepository, IMovieRepository movieRepository, ISeriesRepository seriesRepository)
        {
            _bookRepository = bookRepository;
            _comicRepository = comicRepository;
            _gameRepository = gameRepository;
            _movieRepository = movieRepository;
            _seriesRepository = seriesRepository;
        }

        public void AddItem(ItemDTO dto)
        {
            var itemType = dto.Type;

            // TODO: do mapping
            var item = new Item(dto.Name, dto.FinishedDate);

            switch (itemType)
            {
                case "book":
                    _bookRepository.Add(item as Book);
                    break;
                case "comic":
                    _comicRepository.Add(item as Comic);
                    break;
                case "game":
                    _gameRepository.Add(item as Game);
                    break;
                case "movie":
                    _movieRepository.Add(item as Movie);
                    break;
                case "series":
                    _seriesRepository.Add(item as Series);
                    break;
            }
        }
    }
}