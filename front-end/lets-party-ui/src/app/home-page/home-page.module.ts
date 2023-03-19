import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PartyComponent } from './party/party.component';
import { NavbarComponent } from './navbar/navbar.component';
import { MatSliderModule } from '@angular/material/slider';
import { MatCardModule } from '@angular/material/card';
import { PartyListComponent } from './party-list/party-list.component';
import { MatDialogModule } from '@angular/material/dialog';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { CalendarComponent } from './calendar/calendar.component';
import { MatNativeDateModule } from '@angular/material/core';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatChipsModule } from '@angular/material/chips';
import { MapPanelComponent } from './map-panel/map-panel.component';
import { MatMenuModule } from '@angular/material/menu';
import { LoginComponent } from './login/login.component';
import { MatTabsModule } from '@angular/material/tabs';
import { MatFormFieldModule } from '@angular/material/form-field';
import { RegisterComponent } from './register/register.component';
import { HomeComponent } from './home/home.component';
import { RouterModule } from '@angular/router';
import { CalendarModule, DateAdapter } from 'angular-calendar';
import { adapterFactory } from 'angular-calendar/date-adapters/date-fns';
import { FriendsComponent } from './friends/friends.component';
import { AboutUsComponent } from './about-us/about-us.component';

@NgModule({
  declarations: [
    PartyComponent,
    NavbarComponent,
    PartyListComponent,
    CalendarComponent,
    MapPanelComponent,
    LoginComponent,
    RegisterComponent,
    HomeComponent,
    FriendsComponent,
    AboutUsComponent
  ],
  imports: [
    CommonModule,
    MatCardModule,
    MatSliderModule,
    MatDialogModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatInputModule,
    MatButtonModule,
    MatToolbarModule,
    MatChipsModule,
    MatMenuModule,
    MatTabsModule,
    MatFormFieldModule,
    RouterModule,
    CalendarModule
  ],
  exports: [
    PartyComponent,
    PartyListComponent,
    NavbarComponent,
    MapPanelComponent,
    HomeComponent
  ]
})
export class HomePageModule {
}


