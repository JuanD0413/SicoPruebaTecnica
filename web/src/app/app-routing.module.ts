import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EstudiantesComponent } from './pages/estudiantes/estudiantes.component';
import { CursosComponent } from './pages/cursos/cursos.component';

const routes: Routes = [{
  path:'estudiantes', component: EstudiantesComponent
},{
  path:'cursos', component: CursosComponent
},{
  path:'', component: EstudiantesComponent
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
