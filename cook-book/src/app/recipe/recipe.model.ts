export class Recipe {
  public name: string;
  public description: string;
  public filePath: string;
  constructor(name: string, description: string, filePath: string) {
    this.name = name;
    this.description = description;
    this.filePath = filePath;
  }
}
