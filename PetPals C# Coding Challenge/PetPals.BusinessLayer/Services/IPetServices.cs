using PetPals.Entity;
using System.Collections.Generic;
using PetPals.Business.Repository;


namespace PetPals.BusinessLayer.Services
{

    public interface IPetService
    {
            bool AddPet(Pet pet);
            bool UpdatePet(Pet pet);
            bool DeletePet(int petId);
            Pet GetPetById(int petId);
            List<Pet> GetAllPets();
    }
}
