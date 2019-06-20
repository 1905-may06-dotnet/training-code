import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CardsComponent } from './cards/cards.component';
import { SillyGuard } from './silly.guard';

const routes: Routes = [
  { path: 'cards', component: CardsComponent, canActivate: [SillyGuard] }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
