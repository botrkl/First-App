import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { AddCardModel } from "../models/addModels/add-card.model";
import { UpdateCardModel } from "../models/updateModels/update-card.model";

const API_BASE_URL: string = "https://localhost:7109/api";

@Injectable({
    providedIn: 'root'
  })
  export class CardService {
  
    constructor(private http: HttpClient) { }
  
    addCard(addCardModel: AddCardModel) {
        return this.http.post(`${API_BASE_URL}/cards`,addCardModel);
      }
    deleteCard(id:string){
      return this.http.delete(`${API_BASE_URL}/cards/${id}`)
    }

    updateCard(updateCard:UpdateCardModel){
      return this.http.patch(`${API_BASE_URL}/cards/${updateCard.id}`,updateCard)
    }
} 