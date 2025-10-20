using Ejercicio1.Models.Entity;
namespace Ejercicio1.Models.DAL
{
    public class Data
    {
        public static List<clsPerson> getPersonList()
        {
            return new List<clsPerson>
            {
                new clsPerson { name = "Samuel", surname = "Jimenez", age = 19 },
                new clsPerson { name = "Jorge", surname = "Jimenez", age = 19 },
                new clsPerson { name = "Pablo", surname = "Iglesias", age = 20 },
                new clsPerson { name = "Roberto", surname = "Morano", age = 21 },

            };
        }
    }
}

