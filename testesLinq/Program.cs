using System;
using System.Collections.Generic;
using System.Linq;

namespace testesLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            var listaProdutos = new List<Produto>()
            {
                new Produto { Id = 1, CategoriaId = 3, Nome = "Camiseta", Status = true, Valor = 100},
                new Produto { Id = 2, CategoriaId = 3, Nome = "Short", Status = true, Valor = 1},
                new Produto { Id = 3, CategoriaId = 1, Nome = "VIdeo Game", Status = true, Valor = 99},
                new Produto { Id = 4, CategoriaId = 1, Nome = "Tv", Status = true, Valor = 45},
                new Produto { Id = 5, CategoriaId = 1, Nome = "Maquina De Lavar", Status = true, Valor = 32},
                new Produto { Id = 6, CategoriaId = 1, Nome = "Mircroondas", Status = true, Valor = 90},
                new Produto { Id = 7, CategoriaId = 2, Nome = "Arroz", Status = true, Valor = 55},
                new Produto { Id = 8, CategoriaId = 2, Nome = "Feijão", Status = true, Valor = 12},
                new Produto { Id = 9, CategoriaId = 2, Nome = "Geladeira", Status = true, Valor = 10}
            };

            var listaCategorias = new List<Categoria>()
            {
                new Categoria{Id = 1, Status = true, Nome = "Eletronicos"},
                new Categoria{Id = 2, Status = true, Nome = "Alimentos"},
                new Categoria{Id = 3, Status = true, Nome = "Vestuarios"}
            };

            //// valor total da lista
            //var valorTotal = listaProdutos.Sum(prod => prod.Valor);

            //// media do valor da lista
            //var mediaLista = listaProdutos.Average(prod => prod.Valor);

            //// Total de itens lista

            //var qtdLista = listaProdutos.Count();

            //Console.WriteLine($"Valor Total: {valorTotal}");
            //Console.WriteLine($"Media: {mediaLista}");
            //Console.WriteLine($"Total Itens: {qtdLista}");

            //// criar lista com range de numeros

            //var range = Enumerable.Range(1, 15);

            //foreach (var item in range)
            //{
            //    Console.WriteLine(item);
            //}

            // criar uma lista com varios itens semelhantes

            //var listaProdutosIguais = Enumerable.Repeat(new Produto() { Id = 1 }, 5);

            //foreach (var item in listaProdutosIguais)
            //{
            //    Console.WriteLine(item);
            //}

            //var resultado = from produto in listaProdutos 
            //                where produto.Nome.ToLower() == "Microondas".ToLower()
            //select produto;

            // var resultado = from produto in listaProdutos
            //              where produto.Nome.ToLower().Substring(0, 1) == "M".ToLower()
            //            select produto;

            // var resultado = from produto in listaProdutos
            //            where produto.Nome.ToLower().Substring(0, 1) == "M".ToLower() &&
            //          produto.Status == false
            //      select produto;

            // var resultado = from produto in listaProdutos
            //            where produto.Nome.ToLower().Substring(0, 1) == "M".ToLower() &&
            //          produto.Status == false
            //      select produto;

            // var resultado = from produto in listaProdutos
            //               where produto.Id > 1 && produto.Id < 6
            //             orderby produto.Id descending
            //           select produto;

            //  var resultado = from prod in listaProdutos
            //                select new ProdutoDto
            //              {
            //                Nome = prod.Nome.ToUpper(),
            //              Valor = prod.Valor,
            //            Status = prod.Status
            //      };

            // foreach (var item in resultado)
            //{
            //  Console.WriteLine($" {item.Nome} | {item.Valor} | {item.Status}");
            //}

            // var result = from prod in listaProdutos
            //            group prod by prod.CategoriaId into produtosAgrupados
            //          select produtosAgrupados;

            //   foreach (var item in result)
            // {
            //   Console.WriteLine(item.Key);
            // foreach (var prod in item)
            // {
            //   Console.WriteLine($" Produto: {prod.Nome} | Categoria: {prod.CategoriaId} ");
            //}
            //}


            // var result = from prod in listaProdutos
            //            join cat in listaCategorias
            //          on prod.CategoriaId equals cat.Id
            //        select new
            //      {
            //        Produto = prod,
            //      Categoria = cat
            //};

            // foreach (var item in result)
            //{

            //  Console.WriteLine($" Produto: {item.Produto.Nome} | Categoria: {item.Categoria.Nome} ");

            //}


            //    var resultado = listaProdutos.Where(prod => prod.Id >= 2 && prod.Id <= 5);

            //    foreach (var item in resultado)
            //    {
            //        Console.WriteLine($" Id: {item.Id} | Nome: {item.Nome}");
            //    }

            //var resultado = listaProdutos.Skip(3).Take(3);

            //foreach (var item in resultado)
            //{
            //    Console.WriteLine($"ID: {item.Id} | Nome: {item.Nome} ");
            //}

        }

        class Produto
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public bool Status { get; set; }
            public decimal Valor { get; set; }
            public int CategoriaId { get; set; }
        }

        class Categoria
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public bool Status { get; set; }
        }

        class ProdutoDto
        {
            public string Nome { get; set; }
            public bool Status { get; set; }
            public decimal Valor { get; set; }
        }
    }
}
