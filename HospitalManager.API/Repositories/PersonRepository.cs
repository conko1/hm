﻿using HospitalManager.API.DbContexts;
using HospitalManager.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManager.API.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApiDbContext _context;

        public PersonRepository(ApiDbContext context)
        { 
            this._context = context;
        }

        public async Task Add(Person person)
        {
            await this._context.Persons.AddAsync(person);
            await this._context.SaveChangesAsync();
        }

        public async Task Delete(Person person)
        {
            this._context.Persons.Remove(person);
            await this._context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            return await this._context.Persons.ToListAsync();
        }

        public async Task<Person> GetById(string birthNumber)
        {
            return await this._context.Persons.FindAsync(birthNumber);
        }

        public async Task Update(Person person)
        {
            this._context.Persons.Update(person);
            await this._context.SaveChangesAsync();
        }
    }
}