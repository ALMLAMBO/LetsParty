import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PartyComponent } from './party/party.component';
import { NavbarComponent } from './navbar/navbar.component';
import { MatSliderModule } from '@angular/material/slider';
import { MatCardModule } from '@angular/material/card';
import { PartyListComponent } from './party-list/party-list.component';

@NgModule({
  declarations: [
    PartyComponent,
    NavbarComponent,
    PartyListComponent
  ],
  imports: [
    CommonModule,
    MatCardModule,
    MatSliderModule
  ],
  exports: [
    PartyComponent,
    PartyListComponent,
    NavbarComponent,
  ]
})
export class HomePageModule {
  party_list:PartyListComponent = new PartyListComponent();
}
