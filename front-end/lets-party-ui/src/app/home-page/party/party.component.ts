import { Component } from '@angular/core';

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

  // constructor(name:string, type:string, privacy:string, owner:string, location:string, beginning_time:string, length:number) {
  //   this.name = name;
  //   this.type = type;
  //   this.privacy = privacy;
  //   this.owner = owner;
  //   this.location = location;
  //   this.member_list = this.member_list;
  //   this.beginning_time = beginning_time;
  //   this.length = length;
  // }
}

class Member {

}