using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SollicitatieSGVW
{
    public class SollicitantLijstPagination<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; set; }

        public SollicitantLijstPagination(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            this.AddRange(items);
        }

        public bool IsPreviousPageAvailable => PageIndex > 1;
        public bool IsNextPageAvailable => PageIndex < TotalPages;

        public static SollicitantLijstPagination<T> Create(IList<T> source, int pageIndex, int pageSize)
        {
            var count = source.Count();
            var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return new SollicitantLijstPagination<T>(items, count, pageIndex, pageSize);
        }
    }
}
