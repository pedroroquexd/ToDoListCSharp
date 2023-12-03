using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {

    //cria uma lista para armazenar as tarefas
    List<string> toDoList = new List<string>();

    while (true)
    {
      //exibir menu de opções
      Console.WriteLine("I). Adicionar Tarefa.");
      Console.WriteLine("II). Exibir Tarefas.");
      Console.WriteLine("III). Sair.");

      //obter a escolha do usuário
      string input = Console.ReadLine();

      //verificar se a escolha é um número
      if (int.TryParse(input, out int choice))
      {
        switch (choice)
        {
        case 1:
          //adicionar tarefa
          Console.WriteLine("Digite a nova tarefa: ");
          string newTask = Console.ReadLine();
          toDoList.Add(newTask);
          Console.WriteLine("Tarefa adicionada com sucesso!");
          break;

        case 2:
          //exibir tarefa
          if (toDoList.Count > 0)
          {
            Console.WriteLine("Tarefas: ");
            for (int i = 0; i < toDoList.Count; i++)
            {
              Console.WriteLine($"{i + 1}. {toDoList[i]}");
            }
          }
          break;

        case 3:
          //sair do programa
          Console.WriteLine("Saindo do programa...");
          break;

        default:
          //tratar escolha inválida
          Console.WriteLine("Opção inválida. Tente novamente!");
          break;
        }
      }
          else
      {
        //tratar entrada não numérica
        Console.WriteLine("Por favor, insira um número correspondente às opções.");
      }
      }
    }
}

