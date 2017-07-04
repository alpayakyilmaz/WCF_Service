using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvalServiceLibrary
{
    [DataContract] // bu sınıf wcf üzerinden taşınan bir sınıf olduğunu göstermem için datacontract ile etiketlemem gerekiyor
    public class Eval
    {
        [DataMember] // Data member olarak işaretlemezsem client tarafında erişemem
        public string id;
        [DataMember]
        public string Submitter;
        [DataMember]
        public string Comments;
        [DataMember]
        public DateTime TimeSubmitted;


    }
}
