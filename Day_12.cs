using System;
using System.Linq;

class Person {
	protected string firstName;
	protected string lastName;
	protected int id;
	public Person(){}
	public Person(string firstName, string lastName, int identification) {
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	}
	public void printPerson() {
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	}
}

class Student : Person {
    private int[] testScores;
    public Student(string firstName, string lastName, int id, int[] testScore)
        : base(firstName, lastName, id) {
        testScores = new int[testScore.Length];
        for (int i = 0; i < testScore.Length; i++)
            testScores[i] = testScore[i];
    }

    public char Calculate() {
        int sum = testScores.Sum();
        int avg = sum / testScores.Length;
        return (avg <= 100 && avg >= 90) ? 'O' :
               (avg < 90 && avg >= 80) ? 'E' :
               (avg < 80 && avg >= 70) ? 'A' :
               (avg < 70 && avg >= 55) ? 'P' :
               (avg < 55 && avg >= 40) ? 'D' : 'T';
    }
}

class Solution {
	static void Main() {
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
	  	string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
	  	int[] scores = new int[numScores];
		for(int i = 0; i < numScores; i++) {
			scores[i]= Convert.ToInt32(inputs[i]);
		}
		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}