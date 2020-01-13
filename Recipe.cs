using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Recepie
{
    class Recipe : ICloneable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<string> Ingredients = new List<string>();

        public Recipe(int id, string name, List<string> ingredients)
        {

            this.ID = id;
            this.Name = name;
            this.Ingredients = ingredients;
        }
        public Recipe(Recipe recipe)
        {
            this.ID = recipe.ID;
            this.Name = recipe.Name;
            this.Ingredients = new List<string>(recipe.Ingredients);
        }

        public object Clone()
        {
            Recipe result = (Recipe)this.MemberwiseClone();
            //result.Ingredients = new List<string>(Ingredients);
            return result;
        }


        public override string ToString()
        {

            if (Ingredients != null)
            {
                string result = $"The ingredients of the {this.Name}: ";
                for (int i = 0; i < this.Ingredients.Count; i++)
                {

                    {
                        result += (Ingredients[i] + " ");

                    }
                }
                return result;
            }
            else return "Give some ingredients first";

        }


    }
}
