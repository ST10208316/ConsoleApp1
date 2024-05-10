using System;
using System.Data.Common;

namespace Program{
    public class Program{

        //RECIPE CLASS
        class Recipe{
            //PROPERTIES FOR RECIPE
            public string IngredientName{get; set;}
            public double IngredientQuantity {get; set;}

            public string IngredientUnitOfMeasurement {get; set;}

            public int IngredientsAmount{get; set;}

        }

        //STEPS CLASS
        class Steps{
            //PROPERTIES
            public int AmountOfSteps {get; set;}
            public string StepDescription {get; set;}

        }

        //RECIPE FUNCTIONS

        //FUNCTION FOR GATHERING RECIPE INGREDIENTS
            static public void RecipeIngredients(){

                //OBJECTS
                Recipe myRecipe = new Recipe();
                Steps myStep = new Steps();

                //GETTING INPUT FOR NUMBER OF INGREDIENTS
                Console.WriteLine("Enter number of ingredients >> ");
                int amountofIngredients = Convert.ToInt32(Console.ReadLine());

                //SETTING VALUE FOR AMOUNT OF INGREDIENTS (FOR OTHER METHODS TO HAVE ACCESS)
                myRecipe.IngredientsAmount = amountofIngredients;

                //STORING NUMBER OF INGREDIENTS TO Name, Quantity, Unit of measurement ARRAYS
                string[] name = new string[amountofIngredients];
                double[] quantity = new double[amountofIngredients];
                string[] unitOfMeasurement = new string[amountofIngredients];

                //FOR LOOP TO ITERATE FOR THE NUMBER OF INGREDIENTS
                for(int index = 0; index < amountofIngredients; index++){

                    Console.WriteLine("Ingredient");
                    Console.WriteLine("--------------------------------------------");

                    //INPUT FOR INGREDIENT NAME
                    Console.Write("Enter name of ingredient >> ");
                    myRecipe.IngredientName = Console.ReadLine();

                    //ASSIGNING THE INPUT TO IngredientName PROPERTY
                    name[index] = myRecipe.IngredientName;  

                    //INPUT FOR QUANTITY INGREDIENT
                    Console.Write("Enter quantity of ingredient >> ");
                    myRecipe.IngredientQuantity = Convert.ToDouble(Console.ReadLine());

                    //ASSIGNING THE INPUT TO IngredientQuantity PROPERTY
                    quantity[index] = myRecipe.IngredientQuantity;   

                    //INPUT FOR INGREDIENT UNIT OF MEASUREMENT
                    Console.Write("Enter unit of measurement for ingrdeient >> ");
                    myRecipe.IngredientUnitOfMeasurement = Console.ReadLine();

                    //ASSIGNING THE INPUT TO IngredientUnitOfMeasurement PROPERTY
                    unitOfMeasurement[index] = myRecipe.IngredientUnitOfMeasurement;

                }

                //STEPS FOR RECIPE

                //INPUT FOR NUMBER OF STEPS
                Console.WriteLine("Enter number of steps >> ");
                int numberOfSteps = Convert.ToInt32(Console.ReadLine()); 

                //SETTING VALUE FOR AMOUNT OF STEPS   
                myStep.AmountOfSteps = numberOfSteps;

                //ARRAY TO STORE DEXCRIPTION WITH THE NUMBER OF STEPS
                string[] descripton = new string[numberOfSteps];

                //FOR LOOP TO ITERATE BY THE NUMBER OF STEPS
                for(int index = 0; index < numberOfSteps; index++){

                    //INPUT FOR DESCRIPTION
                    Console.Write("Enter descripton of step >> ");
                    myStep.StepDescription = Console.ReadLine();
                    
                    //ASSIGNING THE INPUT TO StepDescription PROPERTY
                    descripton[index] = myStep.StepDescription;

                }

                //DISPLAYING RECIPE DISPLAY WITH INGREDIENTS AND STEPS
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("RECIPE DISPLAY");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("INGREDIENTS");

                
                for(int index = 0; index < amountofIngredients; index++){

                    //FINAL VALUES DISPLAYED
                    Console.WriteLine("Name: " + name[index] + "\n" + "Quantity: " + quantity[index] + "\n" + "Unit of measurement: " + unitOfMeasurement[index]);
                    Console.WriteLine("------------------------------------------");

                }

                //DISPLAYING STEPS
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("STEPS");

                for(int index = 0; index < numberOfSteps; index++){

                    Console.WriteLine("Step : " + descripton[index]);  

                }

                Console.WriteLine("------------------------------------------");

                
                //CREATING A WHILE LOOP FOR A MENU (OPTION TO CHANGE SCALE OR NOT)
                int LoopIndex = 0;

                while(LoopIndex != 2){

                    //INPUT FOR TO DETERMINE ACTION OF MENU
                    Console.WriteLine("Request For Quantity Scale Change ??\nPress Y to proceed, or N to exit");
                    string menuInput = Console.ReadLine();

                    //IF YES...
                    if(menuInput == "Y"){

                       //CONSTANTS
                       const double HALF = 0.5;
                       const double DOUBLE = 2.0;
                       const double TRIPLE = 3.0;

                       //INPUT FOR NEW SCALE QUANTITY FOR INGREDIENT
                       Console.Write("Enter new scale for quantity ingredient >> ");
                       double Input = Convert.ToDouble(Console.ReadLine());

                       //IF...ELSE IF...ELSE
                
                       //HALF 
                      //CHECKS IF INPUT MATCH HALF(0.5) AND DISPLAY NEW QUANTITY UPDATE
                      if(Input == HALF){

                        for(int index = 0; index < myRecipe.IngredientsAmount; index++){

                            //ASSIGNING NEW VALUE INTO myRecipe.IngredientQuantity
                            myRecipe.IngredientQuantity = HALF * myRecipe.IngredientQuantity;
                            quantity[index] = myRecipe.IngredientQuantity;

                            //DISPLAYING UPDATED RECIPE (AND SCALE)
                            Console.WriteLine("------------------------------------------");
                            Console.WriteLine("Updated Recipe");
                            Console.WriteLine("Name: " + name[index] + "\n" + "Quantity: " + quantity[index] + "\n" + "Unit of measurement: " + unitOfMeasurement[index]);
                            Console.WriteLine("------------------------------------------");

                        }

                    }

                    //DOUBLE
                    //CHECKS IF INPUT MATCH DOUBLE(2.0) AND DISPLAY NEW QUANTITY UPDATE
                    else if(Input == DOUBLE){

                        for(int index = 0; index < myRecipe.IngredientsAmount; index++){

                            //ASSIGNING NEW VALUE INTO myRecipe.IngredientQuantity
                            myRecipe.IngredientQuantity = DOUBLE * myRecipe.IngredientQuantity;
                            quantity[index] = myRecipe.IngredientQuantity;

                            //DISPLAYING UPDATED RECIPE (AND SCALE)
                            Console.WriteLine("------------------------------------------");
                            Console.WriteLine("Updated Recipe");
                            Console.WriteLine("Name: " + name[index] + "\n" + "Quantity: " + quantity[index] + "\n" + "Unit of measurement: " + unitOfMeasurement[index]);
                            Console.WriteLine("------------------------------------------");

                        }

                    }

                    //TRIPLE
                    //CHECKS IF INPUT MATCH TRIPLE(3.0) AND DISPLAY NEW QUANTITY UPDATE
                    else if(Input == TRIPLE){

                        for(int index = 0; index < myRecipe.IngredientsAmount; index++){

                            //ASSIGNING IngredientQuantity to TRIPLE CONSTANT
                            myRecipe.IngredientQuantity = TRIPLE * myRecipe.IngredientQuantity;
                            quantity[index] = myRecipe.IngredientQuantity;

                            //DISPLAYING UPDATED RECIPE (AND SCALE)
                            Console.WriteLine("------------------------------------------");
                            Console.WriteLine("Updated Recipe");
                            Console.WriteLine("Name: " + name[index] + "\n" + "Quantity: " + quantity[index] + "\n" + "Unit of measurement: " + unitOfMeasurement[index]);
                            Console.WriteLine("------------------------------------------");

                        }

                }

                    //ERROR MESSAGE
                    else{

                        Console.WriteLine("Incorrect input!");
                        break;

                    }

                    }

                    //IF NO...BREAK LOOP
                    else if(menuInput == "N"){

                        LoopIndex = 2;
                        break;
                    
                    }


                }

            }

            //FUNCTION TO CLEAR DATA
            static public void ClearAllData(){
                Recipe myRecipe = new Recipe();

                //SETTING VARIABLES TO 0 AND '-' TO INDICATE NO DATA AVAILABLE MEANS DATA CLEARED
                myRecipe.IngredientName = "-";
                myRecipe.IngredientQuantity = 0;
                myRecipe.IngredientUnitOfMeasurement = "-";

                //DISPLAY CLEARED DATA
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Recipe Cleared\n" +  "Name: " + myRecipe.IngredientName + "\nQuantity: " + myRecipe.IngredientQuantity + "\nUnit of measurement: " + myRecipe.IngredientUnitOfMeasurement);
                Console.WriteLine("------------------------------------------");

            }


        static void Main(string[] args) {
        
        //WHILE LOOP TO CONTROL MENU
        int index = 0;

        while(index != 4){

            //CALLING OBJECTS FROM RECIPE AND STEP CLASS
            Recipe myRecipe = new Recipe();
            Steps mySteps = new Steps();

            //USER TO ENTER OPTION FOR MENU ACTION
            Console.WriteLine("MENU \n" + "(1) CREATE AND DISPLAY RECIPE\n(2) CLEAR RECIPE\n(3) EXIT");
            int option = Convert.ToInt32(Console.ReadLine());

            //IF..ELSE IF...ELSE STATEMENTS
            
            //CREATE AND DISPLAY RECIPE
            if(option == 1){

                RecipeIngredients();

            }

            //CLEAR DATA
            else if(option == 2){

                ClearAllData();

            }

            //EXIT
            else if(option == 3){

                index = 4;
                break;

            }

            //ERROR MESSAGE
            else{

                Console.WriteLine("Incorrect input!");
            }

        }

        }
    }
}
