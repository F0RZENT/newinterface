public class Car :IComparable<Car>{
    public string brend;
    public int price;
    public int maxspeed;
    public string color;

public Car (string brend, int price, int maxspeed, string color){
    this.brend = brend;
    this.price = price;
    this.maxspeed = maxspeed;
    this.color = color;
}

public int CompareTo(Car? value){
   if(value is Car machine){
    return price.CompareTo(machine.price);
   } else{
    throw new ArgumentException();
   }
}

}
public class Program{
    public static void Main(){
    Car auto1 = new Car("Matiz", 160000, 80, "Dark red");
    Car auto2 = new Car("Bugatti", 150000000, 1000, "Black - Blue");
    Car auto3 = new Car("Ford Focus", 2000000, 130, "Dark grey");
    Car auto4 = new Car("Hyundai Solaris", 1500000, 100, "White");


    Car[] auto = {auto1, auto2, auto3, auto4};
        Array.Sort(auto);

    foreach(Car machine in auto){
        Console.WriteLine($"{machine.brend} - {machine.price}, {machine.maxspeed}, {machine.color}");
        }
    }
}
