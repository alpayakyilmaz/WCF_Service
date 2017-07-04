using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Threading.Tasks;

namespace EvalServiceLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    //[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class EvalService : IEvalService
    {
        List<Eval> evals = new List<Eval>();

        public void SubmitEval(Eval eval)
        {
            eval.id = Guid.NewGuid().ToString();
         

            evals.Add(eval);
        }

        public List<Eval> GetEval()
        {
            return evals;
        }

        public void RemoveEval(string id)
        {
           // evals.Remove(evals.Find(delegate(Eval e) { return e.id.Equals(id); }));
            evals.Remove(evals.Find(e => e.id.Equals(id)));
        }
    }
}
