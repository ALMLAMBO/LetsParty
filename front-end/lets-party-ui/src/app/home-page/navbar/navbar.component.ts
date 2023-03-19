import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { CalendarComponent } from '../calendar/calendar.component';
import { LoginRegisterComponent } from '../loginRegister/loginRegister.component';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent {
  constructor(public dialog: MatDialog) {}

reload(){
  
}

openCalendarDialog() {
  const dialogRef = this.dialog.open(CalendarComponent);

  dialogRef.afterClosed().subscribe(result => {
    console.log('Dialog result: A');
  })
}

openLoginRegisterDialog() {
  const dialogRef = this.dialog.open(LoginRegisterComponent);

  dialogRef.afterClosed().subscribe(result => {
    console.log('Dialog result: B');
  })
}
}