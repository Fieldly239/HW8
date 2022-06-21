﻿using Net6_EF_Repository.Models;
using Net6_EF_Repository.Repositories;

namespace Net6_EF_Repository.Services
{
    public class BranchesService : IBranchesService
    {
        private readonly IBranchesRepository _branchesRepository;
        //dependency injection
        //injection
        public BranchesService(IBranchesRepository branchesRepository)
        {
            //Set dependency
            _branchesRepository = branchesRepository;
        }
        public IEnumerable<Branches> GetAll()
        {
            var branches = _branchesRepository.GetAll();
            var resp = branches.OrderByDescending(m => m.BranchName);
            return resp;
        }
    }
}
