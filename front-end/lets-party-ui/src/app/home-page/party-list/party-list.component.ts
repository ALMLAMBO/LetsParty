import { Component } from '@angular/core';
import { Party } from 'src/app/party';

@Component({
  selector: 'app-party-list',
  templateUrl: './party-list.component.html',
  styleUrls: ['./party-list.component.css']
})
export class PartyListComponent {
  parties:Party[] = [
    new Party("Party A", "private", "privacy:string", "owner:string", "location:string", "beginning_time:string", 10),
    new Party("Party B", "public", "privacy:string", "owner:string", "location:string", "beginning_time:string", 10)
  ];
  
}
