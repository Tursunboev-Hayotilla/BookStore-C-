using BookStore.Domain.Entities;
using MediatR;

namespace BookStore.Application.useCases.Books.Queries
{
    public class GetBookByIdQuery : IRequest<Book>
    {
        public long Id { get; set; }
    }
}
