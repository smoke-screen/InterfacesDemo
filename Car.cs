namespace InterfacesDemo {
    class Car : IEquatable<Car> {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        public Car(string make, string model, string year){
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public bool Equals (Car car) {
            return this.Make == car.Make &&
                this.Model == car.Model &&
                this.Year == car.Year;
        }

        override public string ToString(){
            // Old Way:
            // return this.Year + " " + this.Make + " " + this.Model + " ";

            // Cool Way:
            return $"{Year} {Make} {Model}";
        }
    }
}
