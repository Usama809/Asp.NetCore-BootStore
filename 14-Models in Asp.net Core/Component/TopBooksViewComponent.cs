using _14_Models_in_Asp.net_Core.Repositores;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace _14_Models_in_Asp.net_Core.Component
{
    public class TopBooksViewComponent : ViewComponent
    {
        private readonly IBookRepository _bookRepository;
        public TopBooksViewComponent(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository; 
        }
        public async Task<IViewComponentResult>InvokeAsync(int count)
        {
            var books = await _bookRepository.GetTopBooksAsync(count);
            return View("~/Views/Shared/Component/TopBooks/Default.cshtml", books);
        }
    }
}
