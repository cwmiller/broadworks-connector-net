using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum ExecutiveCallFilteringCriteriaDnSelection{
    Any,
    AnyInternal,
    AnyExternal,
    SpecifiedOnly,
 }
}
