using MSTECS.Commun;
using System;

namespace MyNamespace.Commun
{


    public interface IOperationResutl
    {

        bool Succes { get; set; }

        string Message { get; set;  }

    }


    public interface IOperationRersult<T>
    {
        bool Succes { set; get;  }
        string Message { set; get; }

        T Data { get; set;   }
    }


    public class OperationResult : IOperationResutl 
    {
        public bool Succes { set; get; }

        public string Message { set; get; }
        
         public Hability Data { get; internal set; }
    }


    public class OperationResult<T> : IOperationRersult<T>
    {
        public T Data { set; get; }

        public bool Succes { set; get; }

        public string Message { set; get; }

        
    }
}