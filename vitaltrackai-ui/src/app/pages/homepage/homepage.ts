import { Component } from '@angular/core';
import { NavbarComponent } from '../../components/navbar/navbar';
import { Hero1Component } from '../../components/hero-1/hero-1';

@Component({
  selector: 'app-homepage',
  imports: [NavbarComponent, Hero1Component],
  templateUrl: './homepage.html',
  styleUrl: './homepage.scss'
})
export class HomepageComponent {

}
