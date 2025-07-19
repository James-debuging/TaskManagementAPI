using System.ComponentModel.DataAnnotations;

namespace TaskManagementAPI.Models
{
    public class PagingResult<T>
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public int TotalCount { get; set; }
        public IEnumerable<T> Items { get; set; }

        public PagingResult(IEnumerable<T> source, int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalCount = source.Count();

            Items = source.Count() > 0 ? source
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList() :
                new List<T>();
        }
    }
}
