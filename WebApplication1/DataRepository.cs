using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1
{
    public class DataRepository
    {
        private readonly DataContext _context;

        public DataRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(SomeModel model)
        {
            _context.Models.Add(model);
            _context.SaveChanges();
        }

        public List<SomeModel> GetAllModels()
        {
            return _context.Models.ToList();
        } 
    }
}