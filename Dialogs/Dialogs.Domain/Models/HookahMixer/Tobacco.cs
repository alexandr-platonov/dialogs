using System;
using System.Collections.Generic;

namespace Dialogs.Domain.Models.HookahMixer
{
    public class Tobacco
    {
        public Tobacco(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }

        public class EqualityComparer : IEqualityComparer<string>
        {
            public bool Equals(string x, string y)
            {
                return x?.Equals(y, StringComparison.InvariantCultureIgnoreCase) == true;
            }

            public int GetHashCode(string obj)
            {
                return obj.ToLower().GetHashCode();
            }
        }
    }
}