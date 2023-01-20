using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context)
        {
            _context = context;
        }
        public async Task add(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public async Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetById(int id)
        {
            var result = await _context.Actors.FindAsync(id);
            return result;
        }

        public async Task<Actor> Update(int id, Actor actor)
        {
            throw new NotImplementedException();
        }
    }
}
