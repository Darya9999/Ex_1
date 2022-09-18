Console.WriteLine("Введите число:");
     string n1 = Console.ReadLine();
     int n = Convert.ToInt32(n1);
     int i;
     
     bool otv = true;
     for (i=2;i<n;i++) {
        if (n % i == 0) {
            otv = false;
        }
     }
     if (otv == true){
        Console.WriteLine("число простое");
     } else{
        Console.WriteLine("число не простое");
     }
    

    
