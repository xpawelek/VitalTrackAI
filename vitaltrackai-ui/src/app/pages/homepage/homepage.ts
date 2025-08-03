import { Component } from '@angular/core';
import { NavbarComponent } from '../../components/navbar/navbar';
import { Hero1Component } from '../../components/hero-1/hero-1';
import { Hero2Component } from '../../components/hero-2/hero-2';
import { JoinUsComponent } from '../../components/join-us/join-us';
import { FooterComponent } from '../../components/footer/footer';

@Component({
  selector: 'app-homepage',
  imports: [NavbarComponent, Hero1Component, Hero2Component, JoinUsComponent, FooterComponent],
  templateUrl: './homepage.html',
  styleUrl: './homepage.scss'
})
export class HomepageComponent {

}
