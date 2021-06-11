import { Component, OnInit } from "@angular/core";
import { Recipe } from "../recipe.model";

@Component({
  selector: "app-recipe-list",
  templateUrl: "./recipe-list.component.html",
  styleUrls: ["./recipe-list.component.sass"]
})
export class RecipeListComponent implements OnInit {
  recipes: Recipe[] = [
    new Recipe(
      "Potato Curry",
      "this is a potato curry",
      "https://simply-delicious-food.com/wp-content/uploads/2019/07/Potato-curry-1-500x500.jpg"
    ),
    new Recipe(
      "Potato Curry",
      "this is a potato curry",
      "https://simply-delicious-food.com/wp-content/uploads/2019/07/Potato-curry-1-500x500.jpg"
    )  
  ];
  constructor() {}

  ngOnInit(): void {}
}
