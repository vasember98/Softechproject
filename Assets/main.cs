using System.Collections;
using System.Collections.Generic;
using System;

class Mezo {
    protected readonly Point position {get;}
    protected int cost {get; set;}
    protected bool isOnFire {get; set;}
    protected bool isRoadConnected {get; set;}
    protected int level {get; set;} // 0 - nincs beépitve 0-3
    protected int timeUntilEvolve {get; set;}
    protected double chaceOfFire {get; set;}
    /*
    Rendor + Lakas + Szolg -> 0.0025
    FireDep = 0
    Ipar -> 0.005
    */
    protected bool nearPolice {get; set;}
}
class Ipar : Mezo {
    
}

class Szolgaltatas : Mezo {

}

class Lakas : Mezo {

}

class Stadion : Mezo {

}

class Rendor : Mezo {

}

class Tuzolto : Mezo {

}

class Road : Mezo {

}

class Lakos {
    private Mezo munkahely {get;} // szolgaltatas vagy ipar vagy stadion
    private Lakas lakas {get;} // csak lakas
    private int elegedettseg {get; set;} // 0-100
}

// tarolo osztalyok ebbe megy minden
class Game {
    private Map map;
    private List<Lakos> lakosok = new List<>();
    //hogy lassuk mi mihez tartozik, ilyen sorrendben átrendezem az adatokat:
    // ball felül->jobb felül, ball alul->jobb alul
    //felül
    private List<Button> times = new List<>();
    private int tick; //0, 1, 2 es 4
    private string TimeSpeedName();

    private button Exit;

    private int lakosokszama();
    private int munkasokszama();
    private int szolgaltszama();
    
    //alul
    private List<Button> tax = new List<>();
    private int taxModifier; // 0.75 , 1 , 1,25
    private string TaxAmountName();

    private int money;
    private uint Satisfaction();
    private int MaintenanceCosts();
    private int Income();
    private DateTime date;

    private List<Button> sideChoices;
    

    
    
    public Game();
    
    public Start();
    public End();
}

class Map {

}