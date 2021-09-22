using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SpssLibCore.FileParser.Records
{
    public class VariableDisplayInfoCollection: ReadOnlyCollection<VariableDisplayInfo>
    {
        internal VariableDisplayInfoCollection(IList<VariableDisplayInfo> list)
            : base(list)
        {
        }
    }
}
