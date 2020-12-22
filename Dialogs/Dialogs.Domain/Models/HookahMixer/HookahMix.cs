﻿using System.Collections.Generic;
using System.Linq;

namespace Dialogs.Domain.Models.HookahMixer
{
    public class HookahMix
    {
        public HookahMix(int id, params TobaccoMix[] tobaccos)
        {
            Id = id;
            Tobaccos = tobaccos.ToList();
        }

        public int Id { get; }
        public string Name { get; }
        public string Description => string.Join(", ", Tobaccos.Select(x => $"{x.Tobacco.Name.ToLower()} - {x.Percent}%"));

        public List<TobaccoMix> Tobaccos { get; }
    }
}
