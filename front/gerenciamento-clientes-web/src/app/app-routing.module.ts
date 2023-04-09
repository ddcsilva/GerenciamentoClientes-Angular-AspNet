import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClientesComponent } from './clientes/clientes.component';

const routes: Routes = [
  { path: '', redirectTo: '/clientes', pathMatch: 'full' }, // redireciona para /clientes
  { path: 'clientes', component: ClientesComponent }, // associa /clientes ao ClientesComponent
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
