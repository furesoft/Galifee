namespace Galifee.Core
{
    public static class JsEvaluator
    {
        private static Context Context;

        public static void Init()
        {
            //init js engine
            Context = new Context();
        }

        public static JsValue Evaluate(string source)
        {
            return Context.Eval(source);
        }
    }
}