using System.Collections.Generic;
using System.Dynamic;

namespace Galifrei.Core
{
    public class DynamicPropertyObject : DynamicObject
    {
        public DynamicPropertyObject(SetupContext context)
        {
            Context = context;
        }

        public SetupContext Context { get; }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            Context.Properties.SetProperty(binder.Name, value);
            return true;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            result = Context.Properties[binder.Name];

            return true;
        }
    }
}