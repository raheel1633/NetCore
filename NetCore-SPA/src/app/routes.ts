import {Routes} from '@angular/router';
import { HomeComponent } from './home/home.component';
import { AuthGuard } from './_guards/auth.guard';
import { OrderListComponent } from './order-list/order-list.component';

export const appRoutes: Routes = [
  { path: 'home', component: HomeComponent },
  {
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
      { path: 'orderlist', component: OrderListComponent }
    ]
  },
  { path: '**', redirectTo: 'home', pathMatch: 'full'}
];
