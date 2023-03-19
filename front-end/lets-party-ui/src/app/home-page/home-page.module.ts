import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PartyComponent } from './party/party.component';
import { NavbarComponent } from './navbar/navbar.component';
import { MatSliderModule } from '@angular/material/slider';
import { MatCardModule } from '@angular/material/card';
import { PartyListComponent } from './party-list/party-list.component';
import { MatDialogModule } from '@angular/material/dialog';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatFormFieldModule } from '@angular/material/form-field';
import { CalendarComponent } from './calendar/calendar.component';
import { MatNativeDateModule } from '@angular/material/core';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatChipsModule } from '@angular/material/chips';
import { MapPanelComponent } from './map-panel/map-panel.component';
import { MatMenuModule } from '@angular/material/menu';
import { LoginRegisterComponent } from './loginRegister/loginRegister.component';
import { MatTabsModule } from '@angular/material/tabs';

@NgModule({
  declarations: [
    PartyComponent,
    NavbarComponent,
    PartyListComponent,
    CalendarComponent,
    MapPanelComponent,
    LoginRegisterComponent
  ],
  imports: [
    CommonModule,
    MatCardModule,
    MatSliderModule,
    MatDialogModule,
    MatDatepickerModule,
    MatFormFieldModule,
    MatNativeDateModule,
    MatInputModule,
    MatButtonModule,
    MatToolbarModule,
    MatChipsModule,
    MatMenuModule,
    MatTabsModule
  ],
  exports: [
    PartyComponent,
    PartyListComponent,
    NavbarComponent,
    MapPanelComponent
  ]
})
export class HomePageModule {
}


