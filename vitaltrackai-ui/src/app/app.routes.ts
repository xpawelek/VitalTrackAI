import { Routes } from '@angular/router';
import { HomepageComponent } from './pages/homepage/homepage'
import { LoginComponent } from './pages/login/login';

export const routes: Routes = [
    { path: 'home', component: HomepageComponent },
    { path: 'login', component: LoginComponent },
    { path: '', redirectTo: "/home", pathMatch: 'full' }
];