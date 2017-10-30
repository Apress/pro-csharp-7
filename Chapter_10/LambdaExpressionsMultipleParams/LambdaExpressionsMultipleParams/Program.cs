using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsMultipleParams
{
    #region SimpleMath (with delegates)
    public class SimpleMath
    {
        public delegate void MathMessage( string msg, int result );
        private MathMessage mmDelegate;

        public void SetMathHandler( MathMessage target )
        { mmDelegate = target; }

        public void Add(int x, int y)
        {
            mmDelegate?.Invoke("Adding has completed!", x + y);
        }

    }
    #endregion

    class Program
    {
        static void Main( string[] args )
        {
            // Register w/ delegate as a lambda expression.
            SimpleMath m = new SimpleMath();
            m.SetMathHandler(( msg, result ) =>
            { Console.WriteLine("Message: {0}, Result: {1}", msg, result); });

            // This will execute the lambda expression.
            m.Add(10, 10);
            Console.ReadLine();
        }
    }
}
