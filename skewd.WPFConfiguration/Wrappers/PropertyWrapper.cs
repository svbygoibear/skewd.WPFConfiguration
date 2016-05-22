using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skewd.WPFConfiguration.Wrappers {
    [Serializable]
    public class PropertyWrapper {
        public object WrappedObject { get; set; }

        public PropertyWrapper() { }

        public PropertyWrapper(object wrappedObject) : this() {
            WrappedObject = (WrappedObject != wrappedObject) ? wrappedObject : WrappedObject;
        }
    }
}
