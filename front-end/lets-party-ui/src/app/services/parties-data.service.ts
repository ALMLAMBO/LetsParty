import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PartiesDataService {
  url = "http://127.0.0.1:8000/parties"
  constructor(private http: HttpClient) {
  }
  parties() {
    return this.http.get(this.url);
  }
}
