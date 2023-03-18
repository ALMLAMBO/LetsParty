import { Component } from '@angular/core';
import { TestConnectionService } from "./test-connection.service";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'lets-party-ui';
  party: any;

  constructor(private testService: TestConnectionService) {

  }

  ngOnInit() {
    this.testService.getTestParty().subscribe(data => {
      this.party = data;
    });
  }
}
