import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { AddListModel } from "../models/addModels/add-list.model";
import { UpdateListModel } from "../models/updateModels/update-list.model";
import { ListModel } from "../models/list.model";
import { Observable } from "rxjs";

const API_BASE_URL: string = "https://localhost:7109/api";

@Injectable({
    providedIn: 'root'
  })
  export class ListService {
  
    constructor(private http: HttpClient) { }
  
    addList(addListModel: AddListModel) {
        return this.http.post(`${API_BASE_URL}/lists`,addListModel);
      }
    deleteList(id :string){
      return this.http.delete(`${API_BASE_URL}/list/${id}`);
    }
    updateList(updateList:UpdateListModel){
      return this.http.patch(`${API_BASE_URL}/list/${updateList.id}`,updateList)
    }
    getAllList(): Observable<ListModel[]>{
      return this.http.get<ListModel[]>(`${API_BASE_URL}/lists`)
    }
} 