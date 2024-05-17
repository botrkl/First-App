import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { AddCardModel } from "../models/addModels/add-card.model";
import { CardActivityModel } from "../models/card-activity.model";
import { Observable } from "rxjs";

const API_BASE_URL: string = "https://localhost:7109/api";

@Injectable({
    providedIn: 'root'
  })
  export class HistoryService {
  
    constructor(private http: HttpClient) { }

    getHistoryData(): Observable<CardActivityModel[]> {
        return this.http.get<CardActivityModel[]>(`${API_BASE_URL}/history`);
      }
} 