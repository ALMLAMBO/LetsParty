import { Component } from '@angular/core';
import { PartiesDataService } from '../../services/parties-data.service';

@Component({
  selector: 'app-party',
  templateUrl: './party.component.html',
  styleUrls: ['./party.component.css']
})
export class PartyComponent {
  name:string = "Basic party";
  type:string = "home";
  privacy:string = "public";
  owner:string = "Andy";
  location:string = "Andy's home";
  member_list:Member[] = [];
  beginning_time:any;
  length:number = 2;

  parties:any;
  constructor(private partyData:PartiesDataService){
    this.partyData.parties().subscribe((data) => {
      console.warn("data", data);
      this.parties = data;
    });
  }
}

class Member {

}