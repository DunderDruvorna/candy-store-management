﻿using CandyStore.Data.Models;

namespace CandyStoreManagementAPI.Services.Interfaces;

public interface ITemplateRepository
{
    Task<IEnumerable<Candy>> Get();
}