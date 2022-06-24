using System;

//namespace CatClass
class Program
{
  public static void Main (string[] args) 
    {
      Cat myCat = new Cat(true, 11.22, 4, "orange", "Pebbles");

      myCat.run(34);
      Console.WriteLine("");
      myCat.feed();

      Console.WriteLine("");
    
      Bird myBird = new Bird(true, 4.6, 9, "red and blue", "Sprinkles");

      myBird.fly(20);
      Console.WriteLine("");
      myBird.feed();

			//Console.WriteLine(myCat.name);
			//Console.WriteLine(myCat.isHappy);
    }
}

  //CLASS CAT
  //
  //
  //

  class Cat
	{
		//Fields and Properties
		string name;
		string furColor;
		int numStripes;
		double weight;
		bool isHappy;
    
    int maxFood;
    int currentFood;

		//Constructor
		public Cat(bool _isHappy, double _weight, int _numStripes, string _furColor, string _name)
		{
			isHappy = _isHappy;
			weight = _weight;
			numStripes = _numStripes;
			furColor = _furColor;
			name = _name;

      maxFood = 40;
		}

    public void run(int currentFood)
    {
      if(currentFood < 0)
      {
        Console.WriteLine(name + " is too tired.");
      }
      else
      {
        for(int i = 0; i < maxFood; i++)
        {
          currentFood -= 4;
          Console.WriteLine(name + " is running over!");
          Console.WriteLine(currentFood);
        }
      }
    }

    public void feed()
    {
      Console.WriteLine("Filling the bowl:");
      while(currentFood < maxFood)
      {
        currentFood += 8;
        Console.WriteLine(currentFood);
      }
    }
  }

  //CLASS BIRD
  //
  //
  //

  class Bird
	{
		//Fields and Properties
		string name;
		string color;
		int numFeathers;
		double weight;
		bool isHappy;
    
    int maxFood;
    int currentFood;

		//Constructor
		public Bird(bool _isHappy, double _weight, int _numFeathers, string _color, string _name)
		{
			isHappy = _isHappy;
			weight = _weight;
			numFeathers = _numFeathers;
			color = _color;
			name = _name;

      maxFood = 30;
		}

    public void fly(int currentFood)
    {
      if(currentFood < 0)
      {
        Console.WriteLine(name + " is too tired.");
      }
      else
      {
        for(int i = 0; i < maxFood; i++)
        {
          currentFood -= 2;
          Console.WriteLine(name + " is flying over!");
          Console.WriteLine(currentFood);
        }
      }
    }

    public void feed()
    {
      Console.WriteLine("Filling the birdfeeder:");
      while(currentFood < maxFood)
      {
        currentFood += 3;
        Console.WriteLine(currentFood);
      }
    }
  }