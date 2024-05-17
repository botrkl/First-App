import { CardActivityModel } from "./card-activity.model";

export class CardModel{
    id!: string;
    title!: string;
    dueDate!: Date;
    priority!: string;
    description!: string;
    listId!: string;
    cardActivities!: CardActivityModel[];
}