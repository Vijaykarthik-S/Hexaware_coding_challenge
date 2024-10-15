using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetPals.Entity;
using PetPals.Business.Repository;

namespace PetPals.BusinessLayer.Services
{
    public class PetService : IPetService
    {
        private readonly IPetRepository _petRepository;

        public PetService(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public bool AddPet(Pet pet)
        {
            return _petRepository.AddPet(pet);
        }

        public bool UpdatePet(Pet pet)
        {
            return _petRepository.UpdatePet(pet);
        }

        public bool DeletePet(int petId)
        {
            return _petRepository.DeletePet(petId);
        }

        public Pet GetPetById(int petId)
        {
            return _petRepository.GetPetById(petId);
        }

        public List<Pet> GetAllPets()
        {
            return _petRepository.GetAllPets();
        }

    }
}


