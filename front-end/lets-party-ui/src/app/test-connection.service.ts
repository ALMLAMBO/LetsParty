import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class TestConnectionService {
  constructor(private http: HttpClient) { }

  getTestParty() {
    return this.http.get('http://127.0.0.1:8000/');
  }
}
