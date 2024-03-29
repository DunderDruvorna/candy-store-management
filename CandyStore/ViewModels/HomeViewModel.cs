﻿using CandyStore.Data.Models;

namespace CandyStore.ViewModels;

public class HomeViewModel
{
    public IEnumerable<Candy> CandyOnSale { get; set; } = default!;
}