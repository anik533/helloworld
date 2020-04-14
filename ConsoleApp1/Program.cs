using System;

namespace ConsoleApp1
{

    public class ICoffeeMachin
    { 
        public static void main(String[] args)
        {
            ICofeeMachine x = new CofeeMachine();

            Resourses res = new Resourses();

      //      x.makeCoffee();

      //      x.addResource;
               
        }
                          
    }

         
    public interface ICofeeMachine
    {
        void addResource (Resourses res);
        void makeCoffee(int Sg, coffeeType);
                     
    }


    class Resourses
    {

  

    }



    public class CofeeMachine: ICofeeMachine
    {
        

        

        //  private int cup;
    private int credit;  // ??????

    public int cup;   //  1 piece
    public int spoon;
    public int water;    //  mg.
    public int sugar;
    public int coffee;
    public int milk;   // mg
    public int choco;

    public int money;  // boolean or int? both?




    public void addResource (int cu, int sp, int wt, int sg, int cf, int ml, int ch)  //to add resources 
        {
            cup = add(cup, cu);
            spoon = add(spoon,sp);
            water = add(water, wt);
            sugar =  add(sugar, sg);
            coffee = add(coffee, cf);
            milk = add(milk, ml);
            choco = add(choco, ch);
        }


        static int add ( int a, int b)
            {
            int result = a + b;
            return result;
            }



        static int substracting(int a, int b)
        {
            int result = a - b;
            return result;
        }




        public void espresso(Resourses res)
        {
            coffee = substracting(coffee, 1);
            water = substracting(water, 15);

            //Exception
        }

        public void makeCappuccino(      )
        {
            coffee = substracting(coffee, 1);
            water = substracting(water, 45);


            //Exception

            // return array [water, coffee, milk, sugar]
        }


        public void makeCoffee ( int Sg, coffeeType)   // ll orders in same method ???
        {
            cup = substracting(cup, 1);
            spoon = substracting(spoon, 1);
            sugar = substracting(sugar, sg);
            
            

            switch (get.coffeeType)
            {
                case coffeeType.espresso:           //
                    makeCappucino();
                    break;
                case coffeeType.beans:
                     makeBeans();
                    break;
                default:
                    Console.WriteLine("We Are a Failure");
                    break;
            }
        }    



        // making in 
        public enum coffeeTypeList { espresso, beans, milk, chocolate, blah}  //coffee type  suger???
    
    }

}
