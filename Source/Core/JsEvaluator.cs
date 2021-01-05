namespace Galifee.Core
{
    public static class JsEvaluator
    {
        private static Context Context;

        public static void Init()
        {
            Parser.DefineCustomCodeFragment(typeof(KeysOfOperator));
            Parser.DefineCustomCodeFragment(typeof(UsingStatement));

            //init js engine
            Context = new Context();
        }

        public static void Evaluate(string source)
        {
            Context.Eval(source);
        }
    }
}