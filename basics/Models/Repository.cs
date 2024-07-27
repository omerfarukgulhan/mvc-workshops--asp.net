namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Car> _cars = new();

        static Repository()
        {
            _cars = new List<Car>()
            {
                new Car() {
                    Id = 1,
                    Brand = "Toyota",
                    Model = "Corolla",
                    Image = "1.jpeg",
                    Description = "Reliable and fuel-efficient",
                    IsActive = true,
                    IsHome = true
                },
                new Car() {
                    Id = 2,
                    Brand = "Honda",
                    Model = "Civic",
                    Image = "2.jpeg",
                    Description = "Compact and sporty",
                    IsActive = true,
                    IsHome = true
                },
                new Car() {
                    Id = 3,
                    Brand = "Ford",
                    Model = "Mustang",
                    Image = "3.jpeg",
                    Description = "Powerful and stylish",
                    IsActive = true,
                    IsHome = false
                },
                new Car() {
                    Id = 4,
                    Brand = "Chevrolet",
                    Model = "Camaro",
                    Image = "4.jpeg",
                    Description = "Muscle car with a bold design",
                    IsActive = true,
                    IsHome = true
                },
            };
        }

        public static List<Car> Cars
        {
            get
            {
                return _cars;
            }
        }

        public static Car? GetById(int? id)
        {
            return _cars.FirstOrDefault(c => c.Id == id);
        }
    }
}
