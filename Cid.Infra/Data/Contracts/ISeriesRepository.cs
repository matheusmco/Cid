using Cid.Domain.Entities;

namespace Cid.Infra.Data.Contracts
{
    public interface ISeriesRepository
    {
        void Add(Series series);
    }
}