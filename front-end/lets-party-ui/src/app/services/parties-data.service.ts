import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Party } from '../party';

@Injectable({
  providedIn: 'root'
})
export class PartiesDataService {
  url = "http://127.0.0.1:8000/parties"
  constructor(private http: HttpClient) {
  }
  parties() {
    // return this.http.get(this.url);
    return [
      new Party("party1","home","public","Andy","Nowhere","10pm",3),
      new Party("party2","home","private","Nicky","Nicky's home","11pm",5),
      new Party("party3","out","public","Donna","Palace Hall","10pm",3),
      new Party("party4","home","private","Laura","Laura's home","11pm",5),
      new Party("party5","home","public","Sandy","Sandy's hut","10pm",3),
      new Party("party6","out","private","Nick","Dance club 'Toronto'","11pm",5),
      new Party("party7","home","public","David","American saloon","10pm",3),
      new Party("party8","home","private","Amber","Amber's home","11pm",5),
      new Party("party9","home","public","Donald","Donald's villa","10pm",3),
      new Party("party10","out","private","Christine","Bar '75'","11pm",5)
    ]
  }
}
