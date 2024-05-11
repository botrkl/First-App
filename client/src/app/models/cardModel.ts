import { cardActivityModel } from "./cardActivityModel";

export class cardModel{
    id!: string;
    title!: string;
    dueDate!: Date;
    priority!: string;
    description!: string;
    listId!: string;
    cardActivities!: cardActivityModel[];
}