import { Component } from '@angular/core';

@Component({
  selector: 'app-calendar',
  templateUrl: './calendar.component.html',
  styleUrls: ['./calendar.component.css']
})
export class CalendarComponent {
  selectedDate: any;
  name = 'Angular 6';

  onSelect(event:string){
    console.log(event);
    this.selectedDate= event;
  }
}
