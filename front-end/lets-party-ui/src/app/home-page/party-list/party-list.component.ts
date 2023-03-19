import { Component } from '@angular/core';
import { PartiesDataService } from '../../services/parties-data.service';

@Component({
  selector: 'app-party-list',
  templateUrl: './party-list.component.html',
  styleUrls: ['./party-list.component.css']
})
export class PartyListComponent {
  parties:any;
  constructor(private partyData:PartiesDataService){
    this.partyData.parties().subscribe((data) => {
      console.warn("data", data);
      this.parties = data;
    });
  }
}
