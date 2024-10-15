using System;
using PetPals.Entity;
using PetPals.Business.Repository;
using PetPals.BusinessLayer.Services;
using PetPals.Repositories;
using PetPals.BusinessLayer.Exceptions;

namespace PetPals
{
    class Program
    {
        static void Main(string[] args)
        {
            PetRepository petRepository = new PetRepository();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Pet Management System");
                Console.WriteLine("1. Add Pet");
                Console.WriteLine("2. Update Pet");
                Console.WriteLine("3. Delete Pet");
                Console.WriteLine("4. Get Pet by ID");
                Console.WriteLine("5. Get All Pets");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option (1-6): ");

                string option = Console.ReadLine();

                try
                {
                    switch (option)
                    {
                        case "1":
                            // Add Pet
                           
                            Console.Write("Enter Pet Name: ");
                            string newPetName = Console.ReadLine();
                            Console.Write("Enter Pet Age: ");
                            int newPetAge = int.Parse(Console.ReadLine());
                            if (newPetAge < 0)
                            {
                                throw new InvalidPetAgeException("Age cannot be negative.");
                            }
                            Console.Write("Enter Pet Breed: ");
                            string newPetBreed = Console.ReadLine();

                            // Create a new pet with constructor
                            Pet newPet = new Pet(newPetName, newPetAge, newPetBreed);
                            petRepository.AddPet(newPet);
                            Console.WriteLine("Pet added successfully.");
                            break;

                        case "2":
                            // Update Pet
                         
                            Console.Write("Enter new Pet Name: ");
                            string updatedPetName = Console.ReadLine();
                            Console.Write("Enter new Pet Age: ");
                            int updatedPetAge = int.Parse(Console.ReadLine());
                            if (updatedPetAge < 0)
                            {
                                throw new InvalidPetAgeException("Age cannot be negative.");
                            }
                            Console.Write("Enter new Pet Breed: ");
                            string updatedPetBreed = Console.ReadLine();

                            // Create an updated pet
                            Pet updatedPet = new Pet(updatedPetName, updatedPetAge, updatedPetBreed);
                            if (petRepository.UpdatePet(updatedPet))
                            {
                                Console.WriteLine("Pet updated successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Pet not found.");
                            }
                            break;

                        case "3":
                            // Delete Pet
                            Console.Write("Enter Pet ID to delete: ");
                            int petIdToDelete = int.Parse(Console.ReadLine());
                            if (petRepository.DeletePet(petIdToDelete))
                            {
                                Console.WriteLine("Pet deleted successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Pet not found.");
                            }
                            break;

                        case "4":
                            // Get Pet by ID
                            Console.Write("Enter Pet ID: ");
                            int petIdToGet = int.Parse(Console.ReadLine());
                            Pet pet = petRepository.GetPetById(petIdToGet);
                            if (pet != null)
                            {
                                Console.WriteLine($"Pet Found: ID = {pet.Id}, Name = {pet.Name}, Age = {pet.Age}, Breed = {pet.Breed}");
                            }
                            else
                            {
                                Console.WriteLine("Pet not found.");
                            }
                            break;

                        case "5":
                            // Get All Pets
                            var allPets = petRepository.GetAllPets();
                            Console.WriteLine("All Pets:");
                            foreach (var p in allPets)
                            {
                                Console.WriteLine($"ID = {p.Id}, Name = {p.Name}, Age = {p.Age}, Breed = {p.Breed}");
                            }
                            break;

                        case "6":
                            // Exit
                            exit = true;
                            Console.WriteLine("Exiting...");
                            break;

                        default:
                            Console.WriteLine("Invalid option. Please select again.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format. Please enter numeric values where required.");
                }
                catch (InvalidPetAgeException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("A null reference occurred. Please check your inputs.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }

                Console.WriteLine(); // Print a blank line for better readability
            }
        }
    }
}
