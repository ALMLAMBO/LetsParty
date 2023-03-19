import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutUsComponent } from './home-page/about-us/about-us.component';
import { CalendarComponent } from './home-page/calendar/calendar.component';
import { FriendsComponent } from './home-page/friends/friends.component';
import { HomeComponent } from './home-page/home/home.component';

const routes: Routes = [
  {
    component:CalendarComponent,
    path:'calendar'
  },
  {
    component:HomeComponent,
    path:''
  },
  {
    component:FriendsComponent,
    path:'friends'
  },
  {
    component:AboutUsComponent,
    path:'about-us'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
