using System;
using System.Threading;

namespace Full_GRASP_And_SOLID
{
    /*   
            Adapter actua como un envoltorio entre dos objetos. Recepciona llamadas por un objeto y las transforma
            en formato o interfaz reconocible por el segundo objeto.
    
            El patron Adaptor tiene tres componentes:
            - la clase target (Recipe)
            - la clase adapter (Adapter)
            - la interfaz adaptee (TimerClient)
            Adaptee es una interfaz existente que se adapta por el adaptador a una clase target.
    
    */
    public class Adapter : TimerClient
    {
        CountdownTimer countdown = new CountdownTimer();

        public void TimeOut()
        {
            
        }
        public void RegisterNew(int time)
        {
            countdown.Register(time,this);
        }
    }
}