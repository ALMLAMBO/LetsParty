import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { LoginComponent } from '../login/login.component';
import { RegisterComponent } from '../register/register.component';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent {
  constructor(public dialog: MatDialog) {
  }

reload(){
  
}

openCalendarDialog() {

}

openLoginDialog() {
  const dialogRef = this.dialog.open(LoginComponent, {panelClass: 'login-dialog'});

  dialogRef.afterClosed().subscribe(result => {
    console.log('Dialog result: B');
  })
}

openRegisterDialog() {
  const dialogRef = this.dialog.open(RegisterComponent);

  dialogRef.afterClosed().subscribe(result => {
    console.log('Dialog result: C');
  })
}
}