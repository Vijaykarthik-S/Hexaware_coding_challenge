using PetPals.Business.Repository;
using PetPals.Entity;
using System.Collections.Generic;
using System.Linq;
using PetPals.BusinessLayer.Services;

namespace PetPals.Repositories
{
    public class PetRepository : IPetRepository
    {
        private readonly List<Pet> _pets; // This can be replaced with a real database context

        public PetRepository()
        {
            // Initialize the list or fetch from the database
            _pets = new List<Pet>();
        }

        public bool AddPet(Pet pet)
        {
            _pets.Add(pet);
            return true; // You might want to implement actual database logic here
        }

        public bool UpdatePet(Pet pet)
        {
            var existingPet = _pets.FirstOrDefault(p => p.Id == pet.Id);
            if (existingPet == null) return false;

            existingPet.Name = pet.Name; // Update other properties as needed
            existingPet.Age = pet.Age; // Update age
            existingPet.Breed = pet.Breed; // Update breed

            return true;
        }

        public bool DeletePet(int petId)
        {
            var pet = _pets.FirstOrDefault(p => p.Id == petId);
            if (pet == null) return false;

            _pets.Remove(pet);
            return true;
        }

        public Pet GetPetById(int petId)
        {
            return _pets.FirstOrDefault(p => p.Id == petId);
        }

        public List<Pet> GetAllPets()
        {
            return _pets.ToList();
        }
    }
}
