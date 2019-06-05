using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    [XmlInclude(typeof(BroadworksConnector.Ocip.Models.EnterpriseDepartmentKey))]
    [XmlInclude(typeof(BroadworksConnector.Ocip.Models.GroupDepartmentKey))]
    public abstract class DepartmentKey
    {
    }
}
