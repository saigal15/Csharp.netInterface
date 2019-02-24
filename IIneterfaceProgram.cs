using System;
namespace InterfaceExample

{
    interface IInterfaceProgram
    {
        void add(int a , int b);
        void sub(int a, int b);
    }

    class Implementation : IInterfaceProgram
    {
        public void add(int a, int b)
       {
           Console.WriteLine(a+b);
       } 
       public void sub(int a, int b){
           Console.WriteLine(a-b);

       }
       static void Main(){
           Implementation obj = new Implementation();
           obj.add(100,50);

           obj.sub(100,250);
           Console.ReadLine();
       }
    }
}