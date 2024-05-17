import { CardModel } from "./card.model";

export class ListModel{
    id!:string;
    title!:string;
    cards:CardModel[] = [];
}