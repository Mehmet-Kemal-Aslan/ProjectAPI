using ProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookApiContext _context;

        public BookRepository(BookApiContext context)
        {
            _context = context;
        }

        public async Task<BookApiModel> Create(BookApiModel book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task Delete(int id)
        {
            var bookToDelete = await _context.Books.FindAsync(id);
            _context.Books.Remove(bookToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<BookApiModel>> Get()
        {
            return _context.Books.ToList();
        }

        public async Task<BookApiModel> Get(int id)
        {
            return await _context.Books.FindAsync(id);
        }

        public async Task Update(BookApiModel book)
        {
            _context.Entry(book).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
