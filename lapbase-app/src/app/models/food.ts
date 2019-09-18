export interface IFood {
  id: string;
  name: string;
  calorieCount: number;
  unit: string;
}

export class Food {
  name: string;
  quantity: string;
  mealTime: string;
}

export enum MealTime {
  BREAKFAST,
  LUNCH,
  DINNER
}
