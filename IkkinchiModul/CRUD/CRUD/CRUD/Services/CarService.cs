using CRUD.Models;

namespace CRUD.Services
{
    public class CarService
    {
        private List<Car> Cars = new List<Car>();

        public Guid AddCar(Car car)
        {
            car.CarId = Guid.NewGuid();
            car.Created = DateTime.UtcNow;
            Cars.Add(car);
            return car.CarId;
        }

        public Guid DeleteCar(Guid carId)
        {
            Car car = null;

            foreach (var c in Cars)
            {
                if (c.CarId == carId)
                {
                    car = c;
                    break;
                }
            }

            if (car != null)
            {
                Cars.Remove(car);
                return carId;
            }

            return Guid.Empty;
        }

        public List<Car> GetAllCars()
        {
            return new List<Car>(Cars);
        }

        public void UpdateCar(Car updatedCar)
        {
            Car existingCar = null;

            foreach (var c in Cars)
            {
                if (c.CarId == updatedCar.CarId)
                {
                    existingCar = c;
                    break;
                }
            }

            if (existingCar != null)
            {
                existingCar.CarName = updatedCar.CarName;
                existingCar.CarDescription = updatedCar.CarDescription;
                existingCar.CarColor = updatedCar.CarColor;
                existingCar.CarBrand = updatedCar.CarBrand;
                existingCar.CarPrice = updatedCar.CarPrice;
                existingCar.CarSpeed = updatedCar.CarSpeed;
                existingCar.Created = updatedCar.Created;
                existingCar.UpdatedAd = DateTime.UtcNow;

            }
        }

        public Car GetById(Guid carId)
        {
            foreach (var c in Cars)
            {
                if (c.CarId == carId)
                {
                    return c;
                }
            }

            return null;
        }
    }
}
