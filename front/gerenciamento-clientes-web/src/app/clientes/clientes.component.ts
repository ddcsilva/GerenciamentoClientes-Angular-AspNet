import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.css']
})
export class ClientesComponent implements OnInit {

  clientes: any[] = [];
  novoCliente: any = {};

  constructor(private http: HttpClient) { }

  adicionarCliente() {
    this.http.post('http://localhost:5000/api/clientes', this.novoCliente).subscribe(() => {
      this.clientes.push(this.novoCliente);
      this.novoCliente = {};
    });
  }

  ngOnInit() {
    this.http.get<any[]>('http://localhost:5000/api/clientes').subscribe(data => {
      this.clientes = data;
    });
  }
}
