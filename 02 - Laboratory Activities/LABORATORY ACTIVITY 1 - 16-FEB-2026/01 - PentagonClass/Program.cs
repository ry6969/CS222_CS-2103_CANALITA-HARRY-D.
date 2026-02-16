void Main(){

    Pentagon p1 = new Pentagon();
    Console.WriteLine("Pentagon p1");
    Console.WriteLine(new string('-', 25));
    p1.Display();
    
    Console.WriteLine();

    Pentagon p2 = new Pentagon(5);
    Console.WriteLine("Pentagon p2");
    Console.WriteLine(new string('-', 25));
    p2.Display();
}

Main();

class Pentagon{
    private double side;
    public Pentagon(){
        this.side = 0;
    }

    public Pentagon(double side){
        this.side = side;
    }

    public double getPerimeter(){
        return 5 * this.side;
    }

    public double getArea(){
        return (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(this.side, 2)) / 4;
    }

    public void Display(){
        Console.WriteLine($"Side length: {this.side}");
        Console.WriteLine($"Perimeter: {getPerimeter():F3}");
        Console.WriteLine($"Area: {getArea():F3}"); 
    }

}



