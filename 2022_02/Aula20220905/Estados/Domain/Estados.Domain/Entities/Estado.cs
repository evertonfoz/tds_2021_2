﻿using System.ComponentModel.DataAnnotations;

namespace Estados.Domain.Entities
{
    public class EstadoEntity
    {
        [Key]
        public int EstadoID { get; set; }
        public string UF { get;  set; }
        public string Nome { get; set; }

        public EstadoEntity()
        {

        }
        //public EstadoEntity(string uf, string nome, int? estadoID=null)
        //{
        //    UF = uf;
        //    Nome = nome;
        //    EstadoID = estadoID;
        //}

        public void Update(string uf, string nome)
        {
            UF = uf;
            Nome = nome;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(EstadoID);
        }

        public override int GetHashCode()
        {
            return EstadoID.GetHashCode();
        }

        public override string ToString()
        {
            return $"[{UF}] - [{Nome}]";
        }
    }
}
