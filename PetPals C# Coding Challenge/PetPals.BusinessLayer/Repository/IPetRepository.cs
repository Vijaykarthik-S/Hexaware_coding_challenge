using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetPals.BusinessLayer.Services;

using PetPals.Entity;


namespace PetPals.Business.Repository
{
    public interface IPetRepository
    {
        bool AddPet(Pet pet);
        bool UpdatePet(Pet pet);
        bool DeletePet(int petId);
        Pet GetPetById(int petId);
        List<Pet> GetAllPets();
    }
}

