import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http: HttpClient) { }

  getData() {
    return this.http.get('https://localhost:5001/api/MyController'); // Update URL with your ASP.NET Core API endpoint
  }

  postData(body: any) {
    return this.http.post('https://localhost:5001/api/MyController', body); // Example of POST request
  }
}
