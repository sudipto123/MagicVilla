using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>()
        {
            new VillaDTO {Id = 1, Name = "Sohini Villa"},
            new VillaDTO {Id = 2, Name= "Sudipto Villa"}
        };
    }        
}
