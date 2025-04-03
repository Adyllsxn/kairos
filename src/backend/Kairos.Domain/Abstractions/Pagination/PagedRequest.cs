namespace Kairos.Domain.Abstractions.Pagination;
public class PagedRequest
{
    public int PageNumber { get; set; } = PagedConfig.DefaultPageNumber;
    public int PageSize { get; set; } = PagedConfig.DefaultPageSize;
}
