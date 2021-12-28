using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Interface;
using BookStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookStoreController : Controller
    {
        private readonly IBookStoreInterface _bookStore;

        public BookStoreController(IBookStoreInterface interfaceBook)
        {
            _bookStore = interfaceBook;
        }

        [HttpGet("GetAllBooks")]
         
        public ReturnDataStore<List<BookDetailModel>> GetAllBooks()
        {
            return _bookStore.GetBooks();
        }

        [HttpPost("AddUpdateBook")]
        
        public ReturnDataStore<BookDetailModel> AddUpdateBook(BookDetailInsertModel bookdetils)
        {

            return _bookStore.AddUpdateBook(bookdetils);
        }

        [HttpGet("GetAllBuyers")]

        public ReturnDataStore<List<BuyerDetailModel>> GetAllBuyers()
        {
            return _bookStore.GetBuyers();
        }
        [HttpPost("AddBuyer")]
        public ReturnDataStore<BuyerInsertModel> InsertBuyer(BuyerInsertModel BuyerModel)
        {
            return _bookStore.InsertBuyer(BuyerModel);
        }
        [HttpGet("SearchBookByAuthor")]
        public ReturnDataStore<List<BookDetailModel>> SearchBookByAuthor(string searchKeyword)
        {

            return _bookStore.SearchBookByAuther(searchKeyword);
        }
        [HttpGet("SearchBook")]
        public ReturnDataStore<List<BookDetailModel>> SearchBook(string searchKeyword)
        {
            return _bookStore.SearchBook(searchKeyword);
        }
    }
}