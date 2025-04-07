﻿using StellarPath.API.Core.DTOs;

namespace StellarPath.API.Core.Interfaces.Services;
public interface IGalaxyService
{
    Task<IEnumerable<GalaxyDto>> GetAllGalaxiesAsync();
    Task<GalaxyDto?> GetGalaxyByIdAsync(int id);
    Task<int> CreateGalaxyAsync(GalaxyDto galaxyDto);
    Task<bool> UpdateGalaxyAsync(GalaxyDto galaxyDto);
    Task<bool> DeactivateGalaxyAsync(int id);
}

