using System;
namespace Interfaceuse{
    interface Bird{
        void birdsound();
    }
class Kokil:Bird{
    public void birdsound(){
    Console.WriteLine("Kokil Sounds kuku");
    }
}

class Programe{
    static void Main(string[]args){
        Kokil myKokil=new Kokil();
        myKokil.birdsound();
    }
}

}











}