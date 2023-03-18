import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PartyComponent } from './party/party.component';
import { NavbarComponent } from './navbar/navbar.component';
import { MatSliderModule } from '@angular/material/slider';
import { MatCardModule } from '@angular/material/card';

@NgModule({
  declarations: [
    PartyComponent,
    NavbarComponent
  ],
  imports: [
    CommonModule,
    MatCardModule,
    MatSliderModule
  ],
  exports: [
    PartyComponent,
    NavbarComponent,
  ]
})
export class HomePageModule {
  party:PartyComponent = new PartyComponent();
}
