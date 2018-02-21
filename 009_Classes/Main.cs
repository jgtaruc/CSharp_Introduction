using System;

public class HospitalEmployee {
    public string firstName;
    public string lastName;
    public int remainingVacationDays;

    public HospitalEmployee(string firstName, string lastName, int remainingVacationDays) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.remainingVacationDays = remainingVacationDays;
    }

    public string getName() {
        return firstName + " " + lastName;
    }

    public int getRemainingVacationDays() {
        return remainingVacationDays;
    }

    public void approveDayOff() {
        remainingVacationDays--;
    }
}

public class Doctor : HospitalEmployee {
    public Doctor(string firstName, string lastName) 
    : base(firstName, lastName, 10) { }
}

public class Classes {
    public static void Main(string[] args) {
        Doctor doctor1 = new Doctor("Juan", "Gabriel");
        Console.WriteLine(doctor1.getName());
        Console.WriteLine(doctor1.getRemainingVacationDays());
        doctor1.approveDayOff();
        Console.WriteLine(doctor1.getRemainingVacationDays());
    }
}