import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { listOfCardModel } from '../models/listOfCardModel';

const API_BASE_URL: string = "https://localhost:7109/api";

@Injectable({
    providedIn: 'root'
  })
  export class BoardService {
  
    constructor(private http: HttpClient) { }
  
    getBoardData(): Observable<listOfCardModel[]> {
        return this.http.get<listOfCardModel[]>(`${API_BASE_URL}/board`);
      }
  } 