import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";

import { AppComponent } from "./app.component";
import { RecipeComponent } from "./recipe/recipe.component";
import { RecipeListComponent } from "./recipe/recipe-list/recipe-list.component";
import { RecipeItemComponent } from "./recipe/recipe-list/recipe-item/recipe-item.component";
import { RecipeDetailComponent } from "./recipe/recipe-detail/recipe-detail.component";
import { HeaderComponent } from "./header/header.component";
import { ShoppingComponent } from './shopping/shopping.component';
import { ShoppingListComponent } from './shopping/shopping-list/shopping-list.component';
import { ShoppingEditComponent } from './shopping/shopping-edit/shopping-edit.component';


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    RecipeComponent,  
    RecipeListComponent,
    RecipeItemComponent,
    RecipeDetailComponent,
    ShoppingComponent,
    ShoppingListComponent,
    ShoppingEditComponent
  ],
  imports: [BrowserModule],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}
