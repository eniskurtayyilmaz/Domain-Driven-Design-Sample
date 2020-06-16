﻿using Exercise.Application.Contracts.Buses.Dtos;
using Exercise.Application.Contracts.Companies.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Application.Contracts.Companies
{
    public interface ICompanyAppService
    {
        Task<CompanyDto> GetAsync(Guid id);

        Task<CompanyWithDetailsDto> GetWithDetails(Guid id);

        Task<IList<CompanyDto>> GetListAsync();

        Task<IList<CompanyWithDetailsDto>> GetListWithDetailsAsync();

        Task<CreateCompanyDto> CreateAsync(CreateCompanyDto entity);

        Task<UpdateCompanyDto> UpdateAsync(UpdateCompanyDto entity);

        Task<CreateBusDto> AddBusAsync(CreateBusDto entity);

        Task DeleteAsync(Guid id);

        Task<bool> EnsureChangesAsync();

    }
}