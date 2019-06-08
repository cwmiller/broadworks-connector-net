using BroadWorksConnector.Ocip.Models.C;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip
{
    [XmlRootAttribute(Namespace = "C")]
    public class BroadsoftDocument : OCIMessage
    {
        [XmlAttribute(AttributeName = "protocol")]
        public string Protocol { get; set; }
    }
}
