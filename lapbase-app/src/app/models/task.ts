import { Food } from "./food";
import { Exercise } from "./exercise";

export enum TaskType {
  FoodIntake,
  Exercise
}

export interface ITask {
  id: string;
  dueDate: Date;
  type: TaskType;
  completed: boolean;
  overdue: boolean;
  patientId: number;
  advisorId: number;
}

export class TaskInput {
  id: string;
  patientId: number;
  organizationCode: number;
  dateAssigned: Date;
  calories: number;
  weight: number;
  foods: Food[];
  exercises: Exercise[];
}
