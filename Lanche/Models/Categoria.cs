﻿namespace Lanche.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Name { get; set; }
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }

    }
}
