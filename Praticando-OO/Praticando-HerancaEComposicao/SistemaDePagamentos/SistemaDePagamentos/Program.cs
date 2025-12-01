using SistemaDePagamentos;
using SistemaDePagamentos.Interfaces;


PagamentoCredito cliente1 = new PagamentoCredito("Nicolas", "nicolas@email.com");
PagamentoDebito cliente2 = new PagamentoDebito("Julia", "julia@email.com");


cliente1.ProcessarPagamento();
cliente2.ProcessarPagamento();

