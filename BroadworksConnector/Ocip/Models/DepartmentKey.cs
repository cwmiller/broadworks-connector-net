using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
[XmlInclude(typeof(BroadWorksConnector.Ocip.Models.EnterpriseDepartmentKey))]
[XmlInclude(typeof(BroadWorksConnector.Ocip.Models.GroupDepartmentKey))]
public abstract class DepartmentKey 
{
}
}
