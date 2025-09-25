using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas;

public class CallCenter
{
    private int _counter;

    public Queue<IncomingCall> Calls { get; private set; } // Removido o '?'

    //Atenção: Metodos contrutores possuem o mesmo nome da classe(regra)
    //São invocados quando controi-se uma instancia do objeto deste tipo

    public CallCenter()
    {
        Calls = new Queue<IncomingCall>();
    }
    //Atenção: Metodos contrutores possuem o mesmo nome da classe(regra)
    //São invocados quando controi-se uma instancia do objeto deste tipo

    public void Call(int clientId) {
        IncomingCall call = new IncomingCall();
        call.Id = ++_counter;
        call.ClientId = clientId;
        call.CallTime = DateTime.Now;

        Calls.Enqueue(call);
    }
    public IncomingCall? Answer(string consultant)
    {
        if (Calls.Count > 0)
        {
            IncomingCall call = Calls.Dequeue();
            call.Consultant = consultant;
            call.StartTime = DateTime.Now;
            return call;
        }
        return null;

    }
    public void End(IncomingCall call) {
        call.EndTime = DateTime.Now;
    }

    public bool AreThereCalls() {
        return Calls.Count > 0;
    }
}

