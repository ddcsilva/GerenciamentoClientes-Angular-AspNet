﻿namespace GerenciamentoClientes.API.Models;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string DataNascimento { get; set; }
    public string Celular { get; set; }
    public string Email { get; set; }
}
