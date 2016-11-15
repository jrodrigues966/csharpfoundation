using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public struct Pet
    {
        public string Name;
        public string TypeOfPet;
    }
    class Program
    {
        static void Main()
        {
            //Initialize and declare to keep track of the number of pet
            var numberOfPets = 0;
            //create and array of Pet struct
            var pets = new Pet[4];
            //Create headers for the Pet list
            char number = '#';
            string nameTitle = "Name";
            string TypeTitle = "Type of Pet";
            
            while (true)
            {
                Console.WriteLine("************************************");
                Console.WriteLine();
                Console.WriteLine("Select one of the following options");
                Console.WriteLine();
                Console.WriteLine("A) Add D) Delete L) List pets");

                string Selection = Console.ReadLine();
                
                //Convert option to be non-case sensitive
                var choice = Selection.ToLower();

                Console.WriteLine("************************************");
                switch (choice)
                {
                    //if A or a is chosen, add user's entry 
                    case "a":
                        {
                            Console.Write("Name of pet: ");
                            var name = Console.ReadLine();

                            Console.Write("Type of pet: ");
                            var typeofpet = Console.ReadLine();

                            //Always add the pet at the end of the array
                            pets[numberOfPets].Name = name;
                            pets[numberOfPets].TypeOfPet = typeofpet;

                            numberOfPets++;
                            break;
                        }
                    //if D or d is chosen, user wants to delete
                    case "d":
                        {
                            //Title
                            Console.WriteLine("{0} {1, -10} {2}", number, nameTitle, TypeTitle);
                            //If there are no pets in the list print no pets
                            if (numberOfPets == 0)
                            {
                                Console.WriteLine("No pets to delete.");
                                break;
                            }                    
                            for (var i = 0; i < numberOfPets; i++)
                            {
                                Console.WriteLine("{0}  {1, -10} {2}", i + 1, pets[i].Name, pets[i].TypeOfPet);
                            }
                            Console.WriteLine();
                            Console.WriteLine("************************************");
                            Console.WriteLine();
                            Console.Write("Which pet to remove: ");

                            var petNumberToDelete = Console.ReadLine();
                            var indexToDelete = int.Parse(petNumberToDelete);

                            //Squish the array from index to the end
                            for (var i = indexToDelete - 1; i < numberOfPets; i++)
                            {
                                
                                //Copy the pet from the next index into the current index
                                pets[i] = pets[i + 1];
                            }

                            //We have one less pet
                            numberOfPets--;
                            break;
                        }
                   
                    case "l":
                        {
                            Console.WriteLine("{0}  {1, -10} {2}", number, nameTitle, TypeTitle);
                            if (numberOfPets == 0)
                            {
                                Console.WriteLine("No pets");
                            }
                            for (int i = 0; i < numberOfPets; i++)
                            {
                                Console.WriteLine("{0}. {1, -10} {2}", i + 1, pets[i].Name, pets[i].TypeOfPet);
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid option [{0}]", choice);
                            break;
                        }
                }
            }
        }
    }
}

