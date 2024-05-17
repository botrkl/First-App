import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { ListModel } from "../models/list.model";
import { Observable } from "rxjs";

const API_BASE_URL: string = "https://localhost:7109/api";

@Injectable({
    providedIn: 'root'
  })
  export class BoardService {
  
    constructor(private http: HttpClient) { }
  
    getBoardData(): Observable<ListModel[]> {
        return this.http.get<ListModel[]>(`${API_BASE_URL}/board`);
      }
} 