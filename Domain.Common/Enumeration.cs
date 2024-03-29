﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public abstract class Enumeration : IComparable
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Enumeration()
        {
            
        }
        protected Enumeration(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString() => Name;
        public static IEnumerable<T> GetAll<T>() where T : Enumeration
        {
            var fields = typeof(T).GetFields(BindingFlags.Public |
                                             BindingFlags.Static |
                                             BindingFlags.DeclaredOnly);
            return fields.Select(f => f.GetValue(null)).Cast<T>();
        }
        public int CompareTo(object? other) => Id.CompareTo(((Enumeration)other).Id);
        public override int GetHashCode() => (Name,Id).GetHashCode();
        
    }
}
