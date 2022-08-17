﻿using GlobalForums.Data.Domains.Models;
using GlobalForums.Data.Domains.Services;
using GlobalForums.Data.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace GlobalForums.Service.Services
{
    public class ForumService : IForum
    {
        private readonly ApplicationDbContext _context;

        public ForumService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task Create(Forum forum)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int forumId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Forum> GetAll()
        {
            return _context.Forums
                .Include(post => post.Posts);
        }

        public IEnumerable<ApplicationUser> GetAllActivityUsers()
        {
            throw new NotImplementedException();
        }

        public Forum GetById(int id)
        {
            var forum = _context.Forums.Where(f => f.Id == id)
                 .Include(f => f.Posts).ThenInclude(p => p.User)
                 .Include(f => f.Posts).ThenInclude(p => p.Replies).ThenInclude(r => r.User)
                 .FirstOrDefault();

            return forum;
        }

        public Task UpdateForumDescription(int forumId, string newDescription)
        {
            throw new NotImplementedException();
        }

        public Task UpdateForumTitle(int forumId, string newTitle)
        {
            throw new NotImplementedException();
        }
    }
}
