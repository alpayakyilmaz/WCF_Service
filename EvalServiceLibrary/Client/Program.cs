using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.EvalServiceReferance;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press <Enter> to run the client...");
            Console.ReadLine();

            EvalServiceClient client = new EvalServiceClient("WsEndPoint");
            Eval eval = new Eval();
            eval.Comments = "Bu programdan geliyor";
            eval.Submitter = "Program";
            eval.TimeSubmitted = DateTime.Now;
            client.SubmitEval(eval);

            Eval[] evals = client.GetEval();
            foreach (Eval ev in evals)
            {
                Console.WriteLine(ev.Comments);
            }

            Console.ReadLine();

        }
    }
}
